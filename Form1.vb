Imports System.Drawing.Drawing2D

Public Class Form1

    Private failedAttempts As Integer = 0
    Private Const MaxAttempts As Integer = 3

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

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        RoundControl(txtUsername, 15)
        RoundControl(txtPassword, 15)
        RoundControl(btnLogin, 20)
        RoundControl(btnRegister, 20)
        RoundControl(btnExit, 20)

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ChrW(0)
        Else
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter your username and password.",
                "Login Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        If txtUsername.Text.Trim() = "admin" AndAlso txtPassword.Text = "admin123" Then

            failedAttempts = 0

            MessageBox.Show(
                "Login successful!",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Else

            failedAttempts += 1

            Dim remainingAttempts As Integer = MaxAttempts - failedAttempts

            If failedAttempts >= MaxAttempts Then

                MessageBox.Show(
                    "Too many failed login attempts. The login has been disabled.",
                    "Account Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtUsername.Enabled = False
                txtPassword.Enabled = False
                btnLogin.Enabled = False

            Else

                MessageBox.Show(
                    "Invalid username or password." & Environment.NewLine &
                    "Remaining attempts: " & remainingAttempts,
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtPassword.Clear()
                txtPassword.Focus()

            End If

        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Me.Hide()
        Register.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

End Class