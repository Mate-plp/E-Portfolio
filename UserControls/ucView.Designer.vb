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
        PictureBox3 = New PictureBox()
        lblSubmitActivity = New Label()
        txtSearch = New TextBox()
        btnVerifyAll = New RoundedButton()
        btnUnverifyAll = New RoundedButton()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(dgvEntries, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEntries
        ' 
        dgvEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEntries.Location = New Point(65, 135)
        dgvEntries.Name = "dgvEntries"
        dgvEntries.Size = New Size(1598, 755)
        dgvEntries.TabIndex = 2
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.Controls.Add(PictureBox3)
        RoundedPanel1.Controls.Add(lblSubmitActivity)
        RoundedPanel1.FillColor = Color.FromArgb(CByte(12), CByte(69), CByte(36))
        RoundedPanel1.Location = New Point(11, 9)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1707, 70)
        RoundedPanel1.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(17, 9)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(61, 50)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' lblSubmitActivity
        ' 
        lblSubmitActivity.Anchor = AnchorStyles.None
        lblSubmitActivity.AutoSize = True
        lblSubmitActivity.Font = New Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubmitActivity.ForeColor = Color.FromArgb(CByte(243), CByte(185), CByte(39))
        lblSubmitActivity.Location = New Point(75, 19)
        lblSubmitActivity.Name = "lblSubmitActivity"
        lblSubmitActivity.Size = New Size(365, 31)
        lblSubmitActivity.TabIndex = 1
        lblSubmitActivity.Text = "Requests for Verification"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(65, 106)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by Name, Student ID, Title, Type, or Status..."
        txtSearch.Size = New Size(1286, 23)
        txtSearch.TabIndex = 4
        ' 
        ' btnVerifyAll
        ' 
        btnVerifyAll.Anchor = AnchorStyles.None
        btnVerifyAll.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnVerifyAll.FlatStyle = FlatStyle.Flat
        btnVerifyAll.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnVerifyAll.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnVerifyAll.Location = New Point(1123, 910)
        btnVerifyAll.Name = "btnVerifyAll"
        btnVerifyAll.Size = New Size(269, 66)
        btnVerifyAll.TabIndex = 15
        btnVerifyAll.Text = "Verify All Visible"
        btnVerifyAll.TextAlign = ContentAlignment.MiddleRight
        btnVerifyAll.UseVisualStyleBackColor = False
        ' 
        ' btnUnverifyAll
        ' 
        btnUnverifyAll.Anchor = AnchorStyles.None
        btnUnverifyAll.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnUnverifyAll.FlatStyle = FlatStyle.Flat
        btnUnverifyAll.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnUnverifyAll.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnUnverifyAll.Location = New Point(1408, 910)
        btnUnverifyAll.Name = "btnUnverifyAll"
        btnUnverifyAll.Size = New Size(258, 66)
        btnUnverifyAll.TabIndex = 16
        btnUnverifyAll.Text = "   Unverify All Visible"
        btnUnverifyAll.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1430, 922)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(1155, 923)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 40)
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' ucView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnUnverifyAll)
        Controls.Add(txtSearch)
        Controls.Add(RoundedPanel1)
        Controls.Add(dgvEntries)
        Controls.Add(btnVerifyAll)
        DoubleBuffered = True
        Name = "ucView"
        Size = New Size(1728, 1005)
        CType(dgvEntries, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvEntries As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblSubmitActivity As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnVerifyAll As RoundedButton
    Friend WithEvents btnUnverifyAll As RoundedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
