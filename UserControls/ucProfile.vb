Imports ReaLTaiizor.Controls

Public Class ucProfile

    Private Sub editInfo(ByVal panel As CyberGroupBox)
        Dim textBoxes = panel.Controls.OfType(Of ReaLTaiizor.Controls.BigTextBox)

        For Each txt In textBoxes
            If txt.ReadOnly = False Then
                txt.ReadOnly = True
            Else
                txt.ReadOnly = False
            End If
        Next
    End Sub
    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        editInfo(cgbStudent)
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        editInfo(cgbUser)
    End Sub

    Private Sub btnEditPass_Click(sender As Object, e As EventArgs) Handles btnEditPass.Click
        editInfo(cgbPass)
    End Sub

    Private Sub btnEditAdd_Click(sender As Object, e As EventArgs) Handles btnEditAdd.Click
        editInfo(cgbAdd)
    End Sub
End Class
