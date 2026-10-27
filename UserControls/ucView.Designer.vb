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
        txtSearch = New TextBox()
        Label1 = New Label()
        btnStatusChange = New RoundedButton()
        CType(dgvEntries, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvEntries
        ' 
        dgvEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEntries.Location = New Point(65, 159)
        dgvEntries.Name = "dgvEntries"
        dgvEntries.Size = New Size(1598, 796)
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
        lblSubmitActivity.Location = New Point(671, 20)
        lblSubmitActivity.Name = "lblSubmitActivity"
        lblSubmitActivity.Size = New Size(365, 31)
        lblSubmitActivity.TabIndex = 1
        lblSubmitActivity.Text = "Requests for Verification"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(65, 130)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1286, 23)
        txtSearch.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(155, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(1103, 21)
        Label1.TabIndex = 5
        Label1.Text = "LOYOLA AYUSIN MO TO OK KAHIT SAN MO LAGAY YUNG BUTTON BASTA MAGANDA TIGNAN TAPOS NAGMAMAKE SENSE (also delete this label)"
        ' 
        ' btnStatusChange
        ' 
        btnStatusChange.Anchor = AnchorStyles.None
        btnStatusChange.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnStatusChange.FlatStyle = FlatStyle.Flat
        btnStatusChange.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnStatusChange.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnStatusChange.Location = New Point(1320, 74)
        btnStatusChange.Name = "btnStatusChange"
        btnStatusChange.Size = New Size(354, 79)
        btnStatusChange.TabIndex = 15
        btnStatusChange.Text = "verify/unverify all visible entries " & vbCrLf & "(pwede mo rin iseparate yung text na " & vbCrLf & "to lagay mo sa label kung mas maganda"
        btnStatusChange.UseVisualStyleBackColor = False
        ' 
        ' ucView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(btnStatusChange)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Controls.Add(RoundedPanel1)
        Controls.Add(dgvEntries)
        DoubleBuffered = True
        Name = "ucView"
        Size = New Size(1728, 1005)
        CType(dgvEntries, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvEntries As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblSubmitActivity As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStatusChange As RoundedButton

End Class
