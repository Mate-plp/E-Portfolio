Public Class Login
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim RegisterForm As New Register()
        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            ShowToast(Me, "Please enter username and password.")
            Return
        End If

        Dim DashboardForm As New Dashboard()
        DashboardForm.Show()
        Me.Close()
    End Sub
End Class