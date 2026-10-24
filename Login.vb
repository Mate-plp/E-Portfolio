Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundAll(Me, 10)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim RegisterForm As New Register
        RegisterForm.Show()
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim
        Dim password = txtPassword.Text

        If username = "" OrElse password = "" Then
            ShowToast(Me, "Please enter your username and password.")
            Return
        End If

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim sql =
                "SELECT f.professor_id, u.first_name, u.last_name " &
                "FROM users u " &
                "INNER JOIN faculty f ON f.username = u.username " &
                "WHERE u.username = @u AND u.password = @p AND u.account_type = 'Faculty' " &
                "LIMIT 1"

                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)

                    Using reader = cmd.ExecuteReader
                        If reader.Read Then
                            CurrentProfessorId = reader("professor_id").ToString
                            CurrentProfessorName = reader("first_name").ToString & " " & reader("last_name").ToString


                            Dim FacultyForm As New Dashboard
                            FacultyForm.Show()
                            Close()
                        Else
                            ShowToast(Me, "Invalid username or password.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ShowToast(Me, "Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub
End Class