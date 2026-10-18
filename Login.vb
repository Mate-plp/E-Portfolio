Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim RegisterForm As New Register()
        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "" OrElse password = "" Then
            ShowToast(Me, "Please enter your username and password.")
            Return
        End If

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Dim sql As String = "SELECT COUNT(*) FROM users WHERE username = @u AND password = @p"

                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)

                    If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                        ShowToast(Me, "Login successful!")
                        Dim DashboardForm As New Dashboard()
                        DashboardForm.Show()
                        Me.Close()
                    Else
                        ShowToast(Me, "Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowToast(Me, "Database error: " & ex.Message)
        End Try
    End Sub
End Class