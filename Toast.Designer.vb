<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblMessage = New Label()
        tmrToast = New Timer(components)
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.Dock = DockStyle.Fill
        lblMessage.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblMessage.ForeColor = Color.White
        lblMessage.Location = New Point(0, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Padding = New Padding(12)
        lblMessage.Size = New Size(320, 80)
        lblMessage.TabIndex = 0
        lblMessage.Text = "Message"
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tmrToast
        ' 
        tmrToast.Interval = 5000
        ' 
        ' Toast
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(320, 80)
        Controls.Add(lblMessage)
        FormBorderStyle = FormBorderStyle.None
        Name = "Toast"
        Opacity = 0.75R
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "Toast"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents tmrToast As Timer
End Class
