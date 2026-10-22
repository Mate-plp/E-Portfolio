Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ucSubmit
    Private attachFile As String = ""
    Private Const MaxFileBytes As Integer = 5 * 1024 * 1024   ' 5 MB per file

    Private Sub ucSubmit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return

        txtTitle.MaxLength = 100
        txtDescription.MaxLength = 250
        dtpDate.Value = Date.Today
        cboType.DropDownStyle = ComboBoxStyle.DropDownList
        cboFaculty.DropDownStyle = ComboBoxStyle.DropDownList

        LoadLookups()

        chkPLP.Checked = False
        UpdateFacultyState()

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
        Catch ex As Exception
            MessageBox.Show("Could not load form data: " & ex.Message)
        End Try
    End Sub

    ' Checked = needs verification (pick a faculty member). Unchecked = no verification needed.
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
            lblFile.Text = Path.GetFileName(attachFile)
        End Using
    End Sub

    Private Sub btnRemoveFile_Click(sender As Object, e As EventArgs) Handles btnRemoveFile.Click
        attachFile = ""
        lblFile.Text = "No file selected"
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
        chkPLP.Checked = False
        UpdateFacultyState()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
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

        ' Checked = pending (0) with a faculty member. Unchecked = verified (1), no faculty.
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
        If attachFile <> "" AndAlso Not File.Exists(attachFile) Then
            Notify("The attached file can't be found. Please choose it again.")
            Return
        End If

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using tx As MySqlTransaction = con.BeginTransaction()

                    ' The entry
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

                    ' Skills
                    For Each item As Object In clbSkills.CheckedItems
                        Dim skillId As Integer = Convert.ToInt32(DirectCast(item, DataRowView)("skill_id"))
                        Using cmd As New MySqlCommand(
                            "INSERT INTO portfolio_skills (entry_id, skill_id) VALUES (@e, @s)", con, tx)
                            cmd.Parameters.AddWithValue("@e", entryId)
                            cmd.Parameters.AddWithValue("@s", skillId)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' Attachments
                    If attachFile <> "" Then
                        Using cmd As New MySqlCommand(
                            "INSERT INTO attachments (file_type, img_data, entry_id) VALUES (@ft, @img, @e)", con, tx)
                            cmd.Parameters.AddWithValue("@ft", Path.GetExtension(attachFile).TrimStart("."c).ToLower())
                            cmd.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = File.ReadAllBytes(attachFile)
                            cmd.Parameters.AddWithValue("@e", entryId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    tx.Commit()
                End Using
            End Using

            ClearForm()
            If verified = 0 Then
                Notify("Entry submitted. Waiting for verification by " & professorName & ".")
            Else
                Notify("Entry submitted.")
            End If

        Catch ex As Exception
            Notify("Could not submit: " & ex.Message)
        End Try
    End Sub
End Class