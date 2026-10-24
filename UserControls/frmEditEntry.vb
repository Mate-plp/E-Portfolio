Public Class frmEditEntry
    Private ReadOnly entryId As Integer
    Private WithEvents editor As ucSubmit

    Public Saved As Boolean = False
    Public ResultMessage As String = ""

    Public Sub New(entryId As Integer)
        InitializeComponent()
        Me.entryId = entryId

        editor = New ucSubmit()
        Me.ClientSize = editor.Size
        editor.Dock = DockStyle.Fill
        Me.Controls.Add(editor)
    End Sub

    Private Sub frmEditEntry_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        editor.LoadForEdit(entryId)
    End Sub

    Private Sub editor_EditFinished(saved As Boolean) Handles editor.EditFinished
        Me.Saved = saved
        Me.ResultMessage = editor.ResultMessage
        Me.DialogResult = If(saved, DialogResult.OK, DialogResult.Cancel)
        Me.Close()
    End Sub
End Class