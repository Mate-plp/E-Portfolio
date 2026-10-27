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
                    ApplySearch()
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

        Dim row = dgvEntries.Rows(e.RowIndex)
        Dim entryId As Integer = Convert.ToInt32(row.Cells("entry_id").Value)
        Dim status As String = row.Cells("Status").Value?.ToString()
        Dim isCurrentlyVerified As Boolean = (status = "Verified")

        Dim newStatus As Boolean = Not isCurrentlyVerified

        Dim message As String = If(isCurrentlyVerified, "Would you like to unverify this entry?", "Mark this entry as verified?")

        Dim title As String = If(isCurrentlyVerified, "Unverify entry", "Verify entry")

        If MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim affectedRows As Integer = SetEntryVerification(con, entryId, newStatus)

                If affectedRows = 0 Then
                    ShowToast(Me.FindForm(), "Entry was not updated. Its status may have changed.")
                End If
            End Using

            LoadEntries()

        Catch ex As Exception
            ShowToast(Me.FindForm(), "Could not update entry: " & ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplySearch()
    End Sub

    Private Sub ApplySearch()
        Dim dt = TryCast(dgvEntries.DataSource, DataTable)
        If dt Is Nothing Then Return

        Dim s As String = txtSearch.Text.Trim()
        If s = "" Then
            dt.DefaultView.RowFilter = ""
            Return
        End If

        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In s
            Select Case c
                Case "*"c, "%"c, "["c, "]"c
                    sb.Append("[").Append(c).Append("]")
                Case "'"c
                    sb.Append("''")
                Case Else
                    sb.Append(c)
            End Select
        Next

        dt.DefaultView.RowFilter = String.Format(
            "[Student Name] LIKE '%{0}%' OR [Student ID] LIKE '%{0}%' OR [Title] LIKE '%{0}%' OR [Type] LIKE '%{0}%' OR [Status] LIKE '%{0}%'",
            sb.ToString())
    End Sub

    Private Function SetEntryVerification(con As MySqlConnection, entryId As Integer, isVerified As Boolean, Optional transaction As MySqlTransaction = Nothing) As Integer
        Using cmd As New MySqlCommand(
            "UPDATE portfolio_entries SET verified = @verified " &
            "WHERE entry_id = @e AND professor_id = @pid " &
            "AND verified <> @verified", con)

            cmd.Transaction = transaction
            cmd.Parameters.AddWithValue("@verified", If(isVerified, 1, 0))
            cmd.Parameters.AddWithValue("@e", entryId)
            cmd.Parameters.AddWithValue("@pid", CurrentProfessorId)
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    Private Sub SetVisibleEntriesVerification(isVerified As Boolean)
        Dim visibleEntryIds As New List(Of Integer)

        For Each row As DataGridViewRow In dgvEntries.Rows
            If row.IsNewRow OrElse Not row.Visible Then Continue For
            If row.Cells("entry_id").Value Is Nothing OrElse row.Cells("entry_id").Value Is DBNull.Value Then Continue For

            visibleEntryIds.Add(Convert.ToInt32(row.Cells("entry_id").Value))
        Next

        Dim action As String = If(isVerified, "verify", "unverify")

        If visibleEntryIds.Count = 0 Then
            ShowToast(Me.FindForm(), $"There are no visible entries to {action}.")
            Return
        End If

        Dim title As String = If(isVerified, "Verify All", "Unverify All")
        Dim message As String = $"Are you sure you want to {action} all {visibleEntryIds.Count} visible entries?"

        If MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Try
                        For Each entryId As Integer In visibleEntryIds
                            SetEntryVerification(con, entryId, isVerified, transaction)
                        Next

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            LoadEntries()
            ShowToast(Me.FindForm(), $"All visible entries have been {If(isVerified, "verified", "unverified")}.")

        Catch ex As Exception
            ShowToast(Me.FindForm(), $"Could not {action} entries: " & ex.Message)
        End Try
    End Sub

    Private Sub btnVerifyAll_Click(sender As Object, e As EventArgs) Handles btnVerifyAll.Click
        SetVisibleEntriesVerification(True)
    End Sub

    Private Sub btnUnverifyAll_Click(sender As Object, e As EventArgs) Handles btnUnverifyAll.Click
        SetVisibleEntriesVerification(False)
    End Sub
End Class
