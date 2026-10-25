Public Class ucDashboard
    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As String = cbChartBox.Text
        Dim year As String = cbYear.Text

        getUserStats()
        PopulateCombos(cbYear)

        If cbYear.SelectedIndex = -1 OrElse cbYear.SelectedItem Is Nothing Then Exit Sub
        If cbYear.DataSource Is Nothing Then Exit Sub

        SwitchChart(chtProgress, cbChartBox.Text, cbYear.Text)

        PopulateTotals(lblTotal, lblVerified, lblSkills)

        FormatChart(chtProgress)
    End Sub

    Private Sub cbChartBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbChartBox.SelectedIndexChanged
        Dim table As String = cbChartBox.Text
        Dim year As String = cbYear.Text

        If cbYear.SelectedIndex = -1 OrElse cbYear.SelectedItem Is Nothing Then Exit Sub
        If cbYear.DataSource Is Nothing Then Exit Sub

        SwitchChart(chtProgress, cbChartBox.Text, cbYear.Text)
    End Sub

    Private Sub cbYear_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbYear.SelectedIndexChanged
        Dim table As String = cbChartBox.Text
        Dim year As String = cbYear.Text

        If cbYear.SelectedIndex = -1 OrElse cbYear.SelectedItem Is Nothing Then Exit Sub
        If cbYear.DataSource Is Nothing Then Exit Sub

        SwitchChart(chtProgress, cbChartBox.Text, cbYear.Text)

    End Sub

End Class
