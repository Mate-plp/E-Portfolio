Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub frmDashboardLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWelcome()
        ShowPage(New ucView(), btnView)
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

                ctrl.BackColor = Color.Transparent
                btn.FlatAppearance.BorderSize = 0
            ElseIf ctrl.HasChildren Then
                ResetButtons(ctrl)
            End If
        Next
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ShowPage(New ucProfile(), btnProfile)
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

    Private Sub LoadWelcome()
        Using con As New MySqlConnection(conString)
            con.Open()
            Using cmd As New MySqlCommand(
                "SELECT u.first_name FROM users u " &
                "INNER JOIN faculty f ON f.username = u.username " &
                "WHERE f.professor_id = @id", con)
                cmd.Parameters.AddWithValue("@id", CurrentProfessorId)
                lblWelcome.Text = "Welcome, " & Convert.ToString(cmd.ExecuteScalar())
            End Using
        End Using
    End Sub
End Class