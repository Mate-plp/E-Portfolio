Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class ucView
    Private Sub ucView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return

        SetupGrid()
        LoadEntries()
    End Sub

    Private Sub SetupGrid()
        With dgvEntries
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Public Sub LoadEntries()
        If String.IsNullOrEmpty(CurrentProfessorId) Then Return

        Dim sql As String = "SELECT e.entry_id, " &
                            "       CONCAT(u.first_name, ' ', u.last_name) AS 'Student Name', " &
                            "       e.student_id AS `Student ID`, " &
                            "       e.activity_title AS Title, " &
                            "       e.`date` AS `Date`, " &
                            "       t.type_name AS Type, " &
                            "       IF(e.verified = 1, 'Verified', 'Unverified') AS Status " &
                            "FROM portfolio_entries e " &
                            "INNER JOIN activity_type t ON t.type_id = e.type_id " &
                            "INNER JOIN student s ON s.student_id = e.student_id " &
                            "INNER JOIN users u ON u.username = s.username " &
                            "WHERE e.professor_id = @id " &
                            "ORDER BY e.verified ASC, e.`date` DESC, e.entry_id DESC"

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using da As New MySqlDataAdapter(sql, con)
                    da.SelectCommand.Parameters.AddWithValue("@id", CurrentProfessorId)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvEntries.DataSource = dt
                End Using
            End Using

            dgvEntries.Columns("entry_id").Visible = False
            dgvEntries.Columns("Date").DefaultCellStyle.Format = "MMM dd, yyyy"
            dgvEntries.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Could not load entries: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvEntries_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntries.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim entryId = Convert.ToInt32(dgvEntries.Rows(e.RowIndex).Cells("entry_id").Value)
        Dim status = dgvEntries.Rows(e.RowIndex).Cells("Status").Value.ToString()

        If status = "Verified" Then
            If MessageBox.Show("Would you like to unverify this entry?", "Unverify entry",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Using con As New MySqlConnection(conString)
                    con.Open()
                    Using cmd As New MySqlCommand(
                        "UPDATE portfolio_entries SET verified = 0 " &
                        "WHERE entry_id = @e AND professor_id = @pid AND verified = 1", con)
                        cmd.Parameters.AddWithValue("@e", entryId)
                        cmd.Parameters.AddWithValue("@pid", CurrentProfessorId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadEntries()
            Catch ex As Exception
                ShowToast(Me.FindForm(), "Could not unverify: " & ex.Message)
            End Try
            Return
        End If

        If MessageBox.Show("Mark this entry as verified?", "Verify entry",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE portfolio_entries SET verified = 1 " &
                    "WHERE entry_id = @e AND professor_id = @pid AND verified = 0", con)
                    cmd.Parameters.AddWithValue("@e", entryId)
                    cmd.Parameters.AddWithValue("@pid", CurrentProfessorId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadEntries()
        Catch ex As Exception
            ShowToast(Me.FindForm(), "Could not verify: " & ex.Message)
        End Try
    End Sub


End Class
