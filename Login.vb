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

                Dim sql As String =
                    "SELECT s.student_id, u.first_name, u.last_name " &
                    "FROM users u " &
                    "INNER JOIN student s ON s.username = u.username " &
                    "WHERE u.username = @u AND u.password = @p AND u.account_type = 'Student' " &
                    "LIMIT 1"

                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim studentId As String = reader("student_id").ToString()
                            Dim fullName As String = reader("first_name").ToString() & " " & reader("last_name").ToString()

                            CurrentStudentId = studentId
                            CurrentStudentName = fullName

                            Dim DashboardForm As New Dashboard()
                            DashboardForm.Show()
                            Me.Close()
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
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub
End Class