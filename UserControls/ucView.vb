Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class ucView
    Private Sub ucView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return

        SetupGrid()
        LoadEntries()
        RoundAll(Me, 10)
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
        If String.IsNullOrEmpty(CurrentStudentId) Then Return

        Dim sql As String =
        "SELECT e.entry_id, " &
        "       e.activity_title AS Title, " &
        "       e.`date` AS `Date`, " &
        "       t.type_name AS Type, " &
        "       IF(e.verified = 1, 'Verified', 'Unverified') AS Status, " &
        "       COALESCE(CONCAT(u.first_name, ' ', u.last_name), '-') AS Verifier " &
        "FROM portfolio_entries e " &
        "INNER JOIN activity_type t ON t.type_id = e.type_id " &
        "LEFT JOIN faculty f ON f.professor_id = e.professor_id " &
        "LEFT JOIN users u ON u.username = f.username " &
        "WHERE e.student_id = @id " &
        "ORDER BY e.`date` DESC, e.entry_id DESC"

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using da As New MySqlDataAdapter(sql, con)
                    da.SelectCommand.Parameters.AddWithValue("@id", CurrentStudentId)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvEntries.DataSource = dt
                End Using
            End Using

            dgvEntries.Columns("entry_id").Visible = False
            dgvEntries.Columns("Date").DefaultCellStyle.Format = "MMM dd, yyyy"
            dgvEntries.ClearSelection()
            ApplySearch()

        Catch ex As Exception
            MessageBox.Show("Could not load entries: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvEntries_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntries.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim entryId As Integer = Convert.ToInt32(dgvEntries.Rows(e.RowIndex).Cells("entry_id").Value)

        Using dlg As New frmEditEntry(entryId)
            If dlg.ShowDialog(Me.FindForm()) = DialogResult.OK Then
                LoadEntries()
                ShowToast(Me.FindForm(), dlg.ResultMessage)
            End If
        End Using
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
            "[Title] LIKE '%{0}%' OR [Type] LIKE '%{0}%' OR [Status] LIKE '%{0}%' OR [Verifier] LIKE '%{0}%'",
            sb.ToString())
    End Sub
End Class
