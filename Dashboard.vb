Public Class frmDashboard

    Private Sub frmDashboardLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPage(New ucDashboard(), btnDashboard)
    End Sub

    Private Sub ShowPage(page As UserControl, activeButton As Button)
        For Each c As Control In pnlContent.Controls
            c.Dispose()
        Next
        pnlContent.Controls.Clear()
        page.Dock = DockStyle.Fill
        pnlContent.Controls.Add(page)

        HighlightButton(activeButton)
        lblTitle.Text = activeButton.Text
    End Sub

    Private Sub HighlightButton(active As Button)
        ResetButtons(pnlSidebar)
        active.BackColor = Color.FromArgb(10, 100, 50) 'selected
    End Sub

    Private Sub ResetButtons(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = If(ctrl.Parent Is pnlPortfolio AndAlso ctrl IsNot btnPortfolio,
                                Color.FromArgb(224, 224, 224), 'unselected sub buttons
                                Color.FromArgb(110, 111, 110)) 'unselected main buttons
            ElseIf ctrl.HasChildren Then
                ResetButtons(ctrl)
            End If
        Next
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowPage(New ucDashboard(), btnDashboard)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ShowPage(New ucProfile(), btnProfile)
    End Sub

    Private Sub btnPortfolio_Click(sender As Object, e As EventArgs) Handles btnPortfolio.Click
        If pnlPortfolio.Height = 50 Then
            pnlPortfolio.Height = 130
        Else
            pnlPortfolio.Height = 50
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ShowPage(New ucSubmit(), btnSubmit)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ShowPage(New ucView(), btnView)
    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        ShowPage(New ucGrades(), btnGrades)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New Login()
            loginForm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class