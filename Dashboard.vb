Imports PdfSharp

Public Class Dashboard

    Private Sub frmDashboardLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PdfSharpLicense.SetAgplLicense()
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
        active.BackColor = Color.Transparent 'selected
        active.FlatAppearance.BorderSize = 2
        active.FlatAppearance.BorderColor = Color.Gold

    End Sub

    Private Sub ResetButtons(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)

                ctrl.BackColor = If(ctrl.Parent Is pnlPortfolio AndAlso ctrl IsNot btnPortfolio,
                                Color.Transparent, 'unselected sub buttons
                                Color.Transparent) 'unselected main buttons
                btn.FlatAppearance.BorderSize = 0
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Hide()
            Dim loginForm As New Login
            loginForm.ShowDialog()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using dlg As New SaveFileDialog()
            dlg.Filter = "PDF file|*.pdf"
            dlg.FileName = "Portfolio_" & CurrentStudentId & ".pdf"
            If dlg.ShowDialog() <> DialogResult.OK Then Return

            Try
                CreatePortfolioPdf(CurrentStudentId, dlg.FileName)
                Process.Start(New ProcessStartInfo(dlg.FileName) With {.UseShellExecute = True})
            Catch ex As Exception
                ShowToast(Me, "Could not create the PDF: " & ex.Message)
            End Try
        End Using
    End Sub
End Class