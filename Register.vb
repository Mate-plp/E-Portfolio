Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Register
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim LoginForm As New Login
        LoginForm.Show()
        Close()
    End Sub

    Private Function GetPasswordStrength(pw As String) As Integer
        Dim score As Integer = 0

        If pw.Length >= 8 Then score += 1
        If pw.Length >= 12 Then score += 1
        If pw.Any(Function(c) Char.IsLower(c)) AndAlso pw.Any(Function(c) Char.IsUpper(c)) Then score += 1
        If pw.Any(Function(c) Char.IsDigit(c)) Then score += 1
        If pw.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then score += 1

        Return score
    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim pw As String = txtPassword.Text

        If pw = "" Then
            lblPasswordStrength.Text = ""
            Return
        End If

        Select Case GetPasswordStrength(pw)
            Case 0, 1
                lblPasswordStrength.Text = "Weak"
                lblPasswordStrength.ForeColor = Color.Firebrick
            Case 2, 3
                lblPasswordStrength.Text = "Fair"
                lblPasswordStrength.ForeColor = Color.DarkOrange
            Case 4
                lblPasswordStrength.Text = "Strong"
                lblPasswordStrength.ForeColor = Color.ForestGreen
            Case Else
                lblPasswordStrength.Text = "Very strong"
                lblPasswordStrength.ForeColor = Color.DarkGreen
        End Select
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim firstName = txtFirstName.Text.Trim
        Dim middleName = txtMiddleName.Text.Trim
        Dim lastName = txtLastName.Text.Trim
        Dim professorId = txtProfessorId.Text.Trim
        Dim username = txtUsername.Text.Trim
        Dim password = txtPassword.Text

        If firstName = "" OrElse lastName = "" OrElse professorId = "" OrElse
   username = "" OrElse password = "" Then
            ShowToast(Me, "Please fill in all required fields.")
            Return
        End If

        If firstName.Length > 50 OrElse lastName.Length > 50 OrElse middleName.Length > 25 Then
            ShowToast(Me, "A name is too long.")
            Return
        End If

        If username.Length > 25 Then
            ShowToast(Me, "Username can be at most 25 characters.")
            txtUsername.Focus()
            Return
        End If

        If password.Length > 50 Then
            ShowToast(Me, "Password can be at most 50 characters.")
            txtPassword.Focus()
            Return
        End If

        If Not Regex.IsMatch(professorId, "^\d{2}-\d{5}$") Then
            ShowToast(Me, "Faculty ID example: 25-00123.")
            txtProfessorId.Focus()
            Return
        End If

        If GetPasswordStrength(password) < 2 Then
            ShowToast(Me, "Password is too weak.")
            txtPassword.Focus()
            Return
        End If

        If password <> txtConfirm.Text Then
            ShowToast(Me, "Passwords do not match.")
            txtConfirm.Focus()
            Return
        End If

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim checkSql =
            "SELECT (SELECT COUNT(*) FROM users WHERE username = @u), " &
            "(SELECT COUNT(*) FROM faculty WHERE professor_id = @pid)"

                Using checkCmd As New MySqlCommand(checkSql, con)
                    checkCmd.Parameters.AddWithValue("@u", username)
                    checkCmd.Parameters.AddWithValue("@pid", professorId)

                    Using r = checkCmd.ExecuteReader
                        r.Read()

                        If Convert.ToInt32(r(0)) > 0 Then
                            ShowToast(Me, "That username is already taken.")
                            Return
                        End If
                        If Convert.ToInt32(r(1)) > 0 Then
                            ShowToast(Me, "That faculty ID is already registered.")
                            Return
                        End If
                    End Using
                End Using

                Using tx = con.BeginTransaction
                    Try
                        Dim userSql =
                    "INSERT INTO users (username, password, account_type, first_name, middle_name, last_name) " &
                    "VALUES (@u, @p, 'Faculty', @fn, @mn, @ln)"

                        Using cmd As New MySqlCommand(userSql, con, tx)
                            cmd.Parameters.AddWithValue("@u", username)
                            cmd.Parameters.AddWithValue("@p", password)
                            cmd.Parameters.AddWithValue("@fn", firstName)
                            cmd.Parameters.AddWithValue("@mn", If(middleName = "", DBNull.Value, middleName))
                            cmd.Parameters.AddWithValue("@ln", lastName)
                            cmd.ExecuteNonQuery()
                        End Using

                        Using cmd As New MySqlCommand(
                    "INSERT INTO faculty (professor_id, username) VALUES (@pid, @u)", con, tx)
                            cmd.Parameters.AddWithValue("@pid", professorId)
                            cmd.Parameters.AddWithValue("@u", username)
                            cmd.ExecuteNonQuery()
                        End Using

                        tx.Commit()
                    Catch
                        tx.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Registration Successful! You can now log in.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim LoginForm As New Login
            LoginForm.Show()
            Close()

        Catch ex As Exception
            ShowToast(Me, "Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundAll(Me, 10)
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirm.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub
End Class