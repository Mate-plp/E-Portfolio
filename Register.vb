Public Class Register
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim LoginForm As New Login()
        LoginForm.Show()
        Me.Close()
    End Sub
End Class