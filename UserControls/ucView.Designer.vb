<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucView))
        dgvEntries = New DataGridView()
        RoundedPanel1 = New RoundedPanel()
        lblSubmitActivity = New Label()
        CType(dgvEntries, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvEntries
        ' 
        dgvEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEntries.Location = New Point(65, 96)
        dgvEntries.Name = "dgvEntries"
        dgvEntries.Size = New Size(1598, 859)
        dgvEntries.TabIndex = 2
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.Controls.Add(lblSubmitActivity)
        RoundedPanel1.FillColor = Color.FromArgb(CByte(12), CByte(69), CByte(36))
        RoundedPanel1.Location = New Point(11, 9)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1707, 70)
        RoundedPanel1.TabIndex = 3
        ' 
        ' lblSubmitActivity
        ' 
        lblSubmitActivity.AutoSize = True
        lblSubmitActivity.Font = New Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubmitActivity.ForeColor = Color.FromArgb(CByte(243), CByte(185), CByte(39))
        lblSubmitActivity.Location = New Point(739, 20)
        lblSubmitActivity.Name = "lblSubmitActivity"
        lblSubmitActivity.Size = New Size(220, 31)
        lblSubmitActivity.TabIndex = 1
        lblSubmitActivity.Text = "View Activities"
        ' 
        ' ucView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(RoundedPanel1)
        Controls.Add(dgvEntries)
        DoubleBuffered = True
        Name = "ucView"
        Size = New Size(1728, 1005)
        CType(dgvEntries, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvEntries As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblSubmitActivity As Label

End Class
