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

        Dim sql As String =
        "SELECT e.entry_id, " &
        "       e.activity_title AS Title, " &
        "       e.`date` AS `Date`, " &
        "       t.type_name AS Type, " &
        "       IF(e.verified = 1, 'Verified', 'Pending') AS Status, " &
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
End Class
