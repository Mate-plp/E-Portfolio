Module mdlToast
    Public Sub ShowToast(owner As Form, message As String)
        Dim toast As New Toast(message)
        toast.Show(owner)
    End Sub
End Module
