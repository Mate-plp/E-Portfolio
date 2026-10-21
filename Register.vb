Public Class Register
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim LoginForm As New Login()
        LoginForm.Show()
        Me.Close()
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

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)
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
                lblPasswordStrength.Text = "Medium"
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
        If GetPasswordStrength(txtPassword.Text) < 2 Then
            ShowToast(Me, "Password is too weak.")
            Return
        End If

        If txtPassword.Text <> txtConfirm.Text Then
            ShowToast(Me, "Passwords do not match.")
            txtConfirm.Focus()
            Return
        End If
    End Sub


End Class