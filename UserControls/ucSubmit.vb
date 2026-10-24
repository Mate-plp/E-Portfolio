Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ucSubmit
    ' Raised in edit mode when the user saves or cancels
    Public Event EditFinished(saved As Boolean)
    Public ResultMessage As String = ""

    Private attachFile As String = ""          ' a newly chosen file
    Private Const MaxFileBytes As Integer = 5 * 1024 * 1024
    Private editEntryId As Integer = 0         ' 0 = new entry, otherwise the entry being edited
    Private keptBytes As Byte() = Nothing      ' the existing attachment, kept in memory while editing
    Private keptType As String = ""
    Private lookupsLoaded As Boolean = False

    Private Sub ucSubmit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return

        txtTitle.MaxLength = 100
        txtDescription.MaxLength = 250
        cboType.DropDownStyle = ComboBoxStyle.DropDownList
        cboFaculty.DropDownStyle = ComboBoxStyle.DropDownList

        If Not lookupsLoaded Then LoadLookups()

        If editEntryId = 0 Then
            dtpDate.Value = Date.Today
            chkPLP.Checked = False
            lblFile.Text = "No file selected"
            UpdateFacultyState()
        End If

        RoundAll(Me, 10)
    End Sub

    Private Sub LoadLookups()
        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim types As New DataTable()
                Using da As New MySqlDataAdapter(
                    "SELECT type_id, type_name FROM activity_type ORDER BY type_name", con)
                    da.Fill(types)
                End Using
                cboType.DataSource = types
                cboType.DisplayMember = "type_name"
                cboType.ValueMember = "type_id"
                cboType.SelectedIndex = -1

                Dim skills As New DataTable()
                Using da As New MySqlDataAdapter(
                    "SELECT skill_id, skill_name FROM skills ORDER BY skill_name", con)
                    da.Fill(skills)
                End Using
                clbSkills.DataSource = skills
                clbSkills.DisplayMember = "skill_name"
                clbSkills.ValueMember = "skill_id"

                Dim faculty As New DataTable()
                Using da As New MySqlDataAdapter(
                    "SELECT f.professor_id, CONCAT(u.first_name, ' ', u.last_name) AS full_name " &
                    "FROM faculty f INNER JOIN users u ON u.username = f.username " &
                    "ORDER BY u.last_name, u.first_name", con)
                    da.Fill(faculty)
                End Using
                cboFaculty.DataSource = faculty
                cboFaculty.DisplayMember = "full_name"
                cboFaculty.ValueMember = "professor_id"
                cboFaculty.SelectedIndex = -1
            End Using
            lookupsLoaded = True
        Catch ex As Exception
            MessageBox.Show("Could not load form data: " & ex.Message)
        End Try
    End Sub

    ' Checked
    Private Sub UpdateFacultyState()
        cboFaculty.Enabled = chkPLP.Checked
        If Not chkPLP.Checked Then cboFaculty.SelectedIndex = -1
    End Sub

    Private Sub chkPLP_CheckedChanged(sender As Object, e As EventArgs) Handles chkPLP.CheckedChanged
        UpdateFacultyState()
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        lblCount.Text = txtDescription.TextLength & " / 250"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using dlg As New OpenFileDialog()
            dlg.Filter = "Images|*.png;*.jpg;*.jpeg"
            dlg.Multiselect = False
            If dlg.ShowDialog() <> DialogResult.OK Then Return

            If New FileInfo(dlg.FileName).Length > MaxFileBytes Then
                Notify(Path.GetFileName(dlg.FileName) & " is over 5 MB.")
                Return
            End If

            attachFile = dlg.FileName
            keptBytes = Nothing
            lblFile.Text = Path.GetFileName(attachFile)
            pbFile.Image = Image.FromFile(attachFile)
        End Using
    End Sub

    Private Sub btnRemoveFile_Click(sender As Object, e As EventArgs) Handles btnRemoveFile.Click
        attachFile = ""
        keptBytes = Nothing
        lblFile.Text = "No file selected"
        pbFile.Image = Nothing
    End Sub

    Private Sub Notify(msg As String)
        ShowToast(Me.FindForm(), msg)
    End Sub

    Private Sub ClearForm()
        txtTitle.Clear()
        txtDescription.Clear()
        dtpDate.Value = Date.Today
        cboType.SelectedIndex = -1
        For i As Integer = 0 To clbSkills.Items.Count - 1
            clbSkills.SetItemChecked(i, False)
        Next
        attachFile = ""
        keptBytes = Nothing
        lblFile.Text = "No file selected"
        pbFile.Image = Nothing
        chkPLP.Checked = False
        UpdateFacultyState()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RaiseEvent EditFinished(False)
    End Sub

    ' ---- Load the form with an existing entry ----
    Public Sub LoadForEdit(entryId As Integer)
        If Not lookupsLoaded Then LoadLookups()
        editEntryId = entryId

        btnCancel.Visible = True
        btnClear.Visible = False
        btnSubmit.Text = "SAVE CHANGES"

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                ' The entry
                Dim pid As String = ""
                Using cmd As New MySqlCommand(
                    "SELECT activity_title, `date`, type_id, description, professor_id " &
                    "FROM portfolio_entries WHERE entry_id = @e AND student_id = @sid", con)
                    cmd.Parameters.AddWithValue("@e", entryId)
                    cmd.Parameters.AddWithValue("@sid", CurrentStudentId)
                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If Not r.Read() Then
                            MessageBox.Show("That entry could not be found.")
                            RaiseEvent EditFinished(False)
                            Return
                        End If
                        txtTitle.Text = r.GetString("activity_title")
                        dtpDate.Value = r.GetDateTime("date")
                        cboType.SelectedValue = r.GetInt32("type_id")
                        txtDescription.Text = r.GetString("description")
                        If Not r.IsDBNull(r.GetOrdinal("professor_id")) Then
                            pid = r.GetString("professor_id")
                        End If
                    End Using
                End Using

                chkPLP.Checked = (pid <> "")
                UpdateFacultyState()
                If pid <> "" Then cboFaculty.SelectedValue = pid

                ' Skills
                Dim picked As New HashSet(Of Integer)
                Using cmd As New MySqlCommand(
                    "SELECT skill_id FROM portfolio_skills WHERE entry_id = @e", con)
                    cmd.Parameters.AddWithValue("@e", entryId)
                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        While r.Read()
                            picked.Add(r.GetInt32("skill_id"))
                        End While
                    End Using
                End Using
                For i As Integer = 0 To clbSkills.Items.Count - 1
                    Dim id As Integer = Convert.ToInt32(DirectCast(clbSkills.Items(i), DataRowView)("skill_id"))
                    clbSkills.SetItemChecked(i, picked.Contains(id))
                Next

                ' Existing attachment kept in memory
                keptBytes = Nothing
                attachFile = ""
                lblFile.Text = "No file selected"
                pbFile.Image = Nothing
                Using cmd As New MySqlCommand(
                    "SELECT file_type, img_data FROM attachments WHERE entry_id = @e LIMIT 1", con)
                    cmd.Parameters.AddWithValue("@e", entryId)
                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If r.Read() Then
                            keptType = r.GetString("file_type")
                            keptBytes = DirectCast(r("img_data"), Byte())
                            lblFile.Text = "Current attachment (" & keptType & ")"
                            Using ms As New MemoryStream(keptBytes)
                                pbFile.Image = Image.FromStream(ms)
                            End Using
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Could not load the entry: " & ex.Message)
            RaiseEvent EditFinished(False)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim title As String = txtTitle.Text.Trim()
        Dim desc As String = txtDescription.Text.Trim()

        ' ---- Validate ----
        If title = "" OrElse desc = "" Then
            Notify("Title and description are required.")
            Return
        End If
        If cboType.SelectedValue Is Nothing Then
            Notify("Please choose an activity type.")
            Return
        End If
        If dtpDate.Value.Date > Date.Today Then
            Notify("The date can't be in the future.")
            Return
        End If
        If attachFile <> "" AndAlso Not File.Exists(attachFile) Then
            Notify("The attached file can't be found. Please choose it again.")
            Return
        End If

        ' Checked
        Dim verified As Integer = If(chkPLP.Checked, 0, 1)
        Dim professorId As Object = DBNull.Value
        Dim professorName As String = ""

        If chkPLP.Checked Then
            If cboFaculty.SelectedValue Is Nothing Then
                Notify("Please choose a faculty member to verify this entry.")
                Return
            End If
            Dim pid As String = cboFaculty.SelectedValue.ToString()
            If pid.Length > 8 Then
                Notify("That faculty ID is longer than 8 characters and can't be saved.")
                Return
            End If
            professorId = pid
            professorName = cboFaculty.Text
        End If

        ' ---- Save ----
        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using tx As MySqlTransaction = con.BeginTransaction()

                    ' 0. Editing
                    If editEntryId <> 0 Then
                        Using cmd As New MySqlCommand(
                            "DELETE FROM portfolio_entries WHERE entry_id = @old AND student_id = @sid", con, tx)
                            cmd.Parameters.AddWithValue("@old", editEntryId)
                            cmd.Parameters.AddWithValue("@sid", CurrentStudentId)
                            If cmd.ExecuteNonQuery() <> 1 Then
                                Notify("That entry no longer exists.")
                                Return
                            End If
                        End Using
                    End If

                    ' 1. The entry
                    Dim entryId As Long
                    Using cmd As New MySqlCommand(
                        "INSERT INTO portfolio_entries " &
                        "(activity_title, `date`, type_id, description, verified, student_id, professor_id) " &
                        "VALUES (@t, @d, @type, @desc, @ver, @sid, @pid)", con, tx)
                        cmd.Parameters.AddWithValue("@t", title)
                        cmd.Parameters.AddWithValue("@d", dtpDate.Value.Date)
                        cmd.Parameters.AddWithValue("@type", Convert.ToInt32(cboType.SelectedValue))
                        cmd.Parameters.AddWithValue("@desc", desc)
                        cmd.Parameters.AddWithValue("@ver", verified)
                        cmd.Parameters.AddWithValue("@sid", CurrentStudentId)
                        cmd.Parameters.AddWithValue("@pid", professorId)
                        cmd.ExecuteNonQuery()
                        entryId = cmd.LastInsertedId
                    End Using

                    ' 2. Skills
                    For Each item As Object In clbSkills.CheckedItems
                        Dim skillId As Integer = Convert.ToInt32(DirectCast(item, DataRowView)("skill_id"))
                        Using cmd As New MySqlCommand(
                            "INSERT INTO portfolio_skills (entry_id, skill_id) VALUES (@e, @s)", con, tx)
                            cmd.Parameters.AddWithValue("@e", entryId)
                            cmd.Parameters.AddWithValue("@s", skillId)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' 3. Attachment
                    Dim fileBytes As Byte() = Nothing
                    Dim fileType As String = ""
                    If attachFile <> "" Then
                        fileBytes = File.ReadAllBytes(attachFile)
                        fileType = Path.GetExtension(attachFile).TrimStart("."c).ToLower()
                    ElseIf keptBytes IsNot Nothing Then
                        fileBytes = keptBytes
                        fileType = keptType
                    End If

                    If fileBytes IsNot Nothing Then
                        Using cmd As New MySqlCommand(
                            "INSERT INTO attachments (file_type, img_data, entry_id) VALUES (@ft, @img, @e)", con, tx)
                            cmd.Parameters.AddWithValue("@ft", fileType)
                            cmd.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = fileBytes
                            cmd.Parameters.AddWithValue("@e", entryId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    tx.Commit()
                End Using
            End Using

            Dim msg As String = If(editEntryId <> 0, "Entry updated.", "Entry submitted.")
            If verified = 0 Then msg &= " Waiting for verification by " & professorName & "."

            If editEntryId <> 0 Then
                ResultMessage = msg
                RaiseEvent EditFinished(True)
            Else
                ClearForm()
                Notify(msg)
            End If

        Catch ex As Exception
            Notify("Could not submit: " & ex.Message)
        End Try
    End Sub
End Class