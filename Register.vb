Imports System.Drawing.Drawing2D

Public Class Register

    Private Sub RoundControl(control As Control, radius As Integer)

        Dim path As New GraphicsPath()
        Dim rect As Rectangle = control.ClientRectangle
        Dim diameter As Integer = radius * 2

        If rect.Width <= diameter OrElse rect.Height <= diameter Then
            Return
        End If

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)

    End Sub

    Private Sub Register_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        RoundControl(txtUsername, 15)
        RoundControl(txtPassword, 15)
        RoundControl(txtConfirmPassword, 15)
        RoundControl(btnRegister, 20)
        RoundControl(btnBack, 20)

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ChrW(0)
            txtConfirmPassword.PasswordChar = ChrW(0)
        Else
            txtPassword.PasswordChar = "*"
            txtConfirmPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        Dim password As String = txtPassword.Text

        If password.Length = 0 Then

            lblPasswordStrength.Text = "Password Strength:"

        ElseIf password.Length < 6 Then

            lblPasswordStrength.Text = "Password Strength: Weak"

        ElseIf password.Length < 8 Then

            lblPasswordStrength.Text = "Password Strength: Medium"

        Else

            Dim hasUpper As Boolean = False
            Dim hasLower As Boolean = False
            Dim hasNumber As Boolean = False
            Dim hasSpecial As Boolean = False

            For Each character As Char In password

                If Char.IsUpper(character) Then
                    hasUpper = True

                ElseIf Char.IsLower(character) Then
                    hasLower = True

                ElseIf Char.IsDigit(character) Then
                    hasNumber = True

                Else
                    hasSpecial = True

                End If

            Next

            If hasUpper AndAlso hasLower AndAlso hasNumber AndAlso hasSpecial Then
                lblPasswordStrength.Text = "Password Strength: Strong"
            Else
                lblPasswordStrength.Text = "Password Strength: Medium"
            End If

        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtUsername.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter a username.",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUsername.Focus()
            Return

        End If

        If txtPassword.Text = "" Then

            MessageBox.Show(
                "Please enter a password.",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPassword.Focus()
            Return

        End If

        If txtConfirmPassword.Text = "" Then

            MessageBox.Show(
                "Please confirm your password.",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtConfirmPassword.Focus()
            Return

        End If

        If txtUsername.Text.Trim().ToLower() = txtPassword.Text.Trim().ToLower() Then

            MessageBox.Show(
                "Username and password must be different.",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPassword.Clear()
            txtConfirmPassword.Clear()
            txtPassword.Focus()
            Return

        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then

            MessageBox.Show(
                "Passwords do not match.",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtConfirmPassword.Clear()
            txtConfirmPassword.Focus()
            Return

        End If

        If txtPassword.Text.Length < 6 Then

            MessageBox.Show(
                "Password must contain at least 6 characters.",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPassword.Focus()
            Return

        End If

        MessageBox.Show(
            "Registration successful!",
            "Registration",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        lblPasswordStrength.Text = "Password Strength:"

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        Form1.Show()

    End Sub

End Class