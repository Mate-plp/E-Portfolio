Public Class ucDashboard



    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getUserStats()
        populateRange(cbYear)

        PopulateChart(chtProgress, "Total Skills", "All")
    End Sub

    Private Sub cbChartBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbChartBox.SelectionChangeCommitted
        PopulateChart(chtProgress, cbChartBox.SelectedItem.ToString(), cbYear.SelectedItem.ToString())
    End Sub
End Class
