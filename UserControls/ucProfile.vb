Imports System.ComponentModel

Public Class ucProfile
    Private Sub ucProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        RoundAll(Me, 10)
    End Sub

    Private Sub editInfo(txt As TextBox)
        txt.ReadOnly = Not txt.ReadOnly
        txt.Enabled = Not txt.Enabled
        txt.Focus()
    End Sub

    Private Sub btnUsername_Click(sender As Object, e As EventArgs) Handles btnUsername.Click
        editInfo(tbUsername)
    End Sub

    Private Sub btnFN_Click(sender As Object, e As EventArgs) Handles btnFN.Click
        editInfo(tbFN)
    End Sub
    Private Sub btnMN_Click(sender As Object, e As EventArgs) Handles btnMN.Click
        editInfo(tbMN)
    End Sub

    Private Sub btnLN_Click(sender As Object, e As EventArgs) Handles btnLN.Click
        editInfo(tbLN)
    End Sub

    Private Sub btnOldPass_Click(sender As Object, e As EventArgs) Handles btnOldPass.Click
        editInfo(tbOldPass)
    End Sub

    Private Sub btnNewPass_Click(sender As Object, e As EventArgs) Handles btnNewPass.Click
        editInfo(tbNewPass)
    End Sub

    Private Sub btnCfmPass_Click(sender As Object, e As EventArgs) Handles btnCfmPass.Click
        editInfo(tbCfmPass)
    End Sub

    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        editInfo(tbID)
    End Sub

    Private Sub btnProgram_Click(sender As Object, e As EventArgs) Handles btnProgram.Click
        editInfo(tbProgram)
    End Sub

    Private Sub btnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        editInfo(tbYear)
    End Sub

    Private Sub btnLine1_Click(sender As Object, e As EventArgs) Handles btnLine1.Click
        editInfo(tbLine1)
    End Sub

    Private Sub btnLine2_Click(sender As Object, e As EventArgs) Handles btnLine2.Click
        editInfo(tbLine2)
    End Sub

    Private Sub btnCity_Click(sender As Object, e As EventArgs) Handles btnCity.Click
        editInfo(tbCity)
    End Sub

    Private Sub btnBar_Click(sender As Object, e As EventArgs) Handles btnBar.Click
        editInfo(tbBar)
    End Sub

    Private Sub btnRegion_Click(sender As Object, e As EventArgs) Handles btnRegion.Click
        editInfo(tbRegion)
    End Sub
End Class
