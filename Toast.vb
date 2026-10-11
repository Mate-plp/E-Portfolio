Public Class Toast
    Public Enum ToastType
        Info
        Success
        Warning
    End Enum

    Public Sub New(message As String)
        InitializeComponent()
        lblMessage.Text = message
    End Sub

    Private Sub Toast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Owner IsNot Nothing Then
            Me.Location = New Point(Me.Owner.Left + (Me.Owner.Width - Me.Width) \ 2, Me.Owner.Top + (Me.Owner.Height - Me.Height) \ 2)
        End If
        tmrToast.Start()
    End Sub

    Private Sub tmrToast_Tick(sender As Object, e As EventArgs) Handles tmrToast.Tick
        Me.Close()
    End Sub
End Class