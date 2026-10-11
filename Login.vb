Public Class Login
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim RegisterForm As New Register()
        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim DashboardForm As New Dashboard()
        DashboardForm.Show()
        Me.Close()
    End Sub
End Class