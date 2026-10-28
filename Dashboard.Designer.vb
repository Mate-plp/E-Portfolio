<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        pnlSidebar = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnView = New RoundedButton()
        btnExport = New RoundedButton()
        btnSubmit = New RoundedButton()
        btnLogout = New RoundedButton()
        btnProfile = New RoundedButton()
        btnDashboard = New RoundedButton()
        SpaceSeparatorVertical1 = New Panel()
        pnlHeader = New Panel()
        PnlHead = New Panel()
        lblWelcome = New Label()
        picLogo = New PictureBox()
        lblTitle = New Label()
        pnlContent = New Panel()
        pnlSidebar.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        PnlHead.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.AutoScroll = True
        pnlSidebar.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        pnlSidebar.BackgroundImage = CType(resources.GetObject("pnlSidebar.BackgroundImage"), Image)
        pnlSidebar.BackgroundImageLayout = ImageLayout.Stretch
        pnlSidebar.Controls.Add(PictureBox6)
        pnlSidebar.Controls.Add(PictureBox5)
        pnlSidebar.Controls.Add(PictureBox4)
        pnlSidebar.Controls.Add(PictureBox3)
        pnlSidebar.Controls.Add(PictureBox2)
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Controls.Add(btnView)
        pnlSidebar.Controls.Add(btnExport)
        pnlSidebar.Controls.Add(btnSubmit)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(SpaceSeparatorVertical1)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 75)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Padding = New Padding(0, 0, 0, 161)
        pnlSidebar.Size = New Size(192, 1005)
        pnlSidebar.TabIndex = 0
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(16, 742)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(30, 30)
        PictureBox6.TabIndex = 15
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(16, 685)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 30)
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(14, 206)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(30, 30)
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(12, 148)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(30, 30)
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(12, 92)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(11, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' btnView
        ' 
        btnView.Anchor = AnchorStyles.None
        btnView.BackColor = Color.Transparent
        btnView.FlatAppearance.BorderSize = 0
        btnView.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnView.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnView.ForeColor = Color.White
        btnView.Location = New Point(-19, 196)
        btnView.Name = "btnView"
        btnView.Size = New Size(211, 50)
        btnView.TabIndex = 8
        btnView.Text = "          View Activities"
        btnView.TextAlign = ContentAlignment.MiddleLeft
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.None
        btnExport.BackColor = Color.Transparent
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExport.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(0, 676)
        btnExport.Margin = New Padding(4, 8, 10, 8)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(192, 50)
        btnExport.TabIndex = 10
        btnExport.Text = " Export to PDF"
        btnExport.TextAlign = ContentAlignment.MiddleLeft
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.None
        btnSubmit.BackColor = Color.Transparent
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSubmit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(-19, 139)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(211, 50)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "          Submit Activity"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.None
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(11, 731)
        btnLogout.Margin = New Padding(4, 8, 10, 8)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(171, 50)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Log Out"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.Anchor = AnchorStyles.None
        btnProfile.BackColor = Color.Transparent
        btnProfile.BackgroundImageLayout = ImageLayout.None
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(-46, 81)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(238, 50)
        btnProfile.TabIndex = 0
        btnProfile.Text = "Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.None
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.BackgroundImageLayout = ImageLayout.None
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = SystemColors.Window
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(-17, 23)
        btnDashboard.Margin = New Padding(3, 10, 3, 3)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(209, 50)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' SpaceSeparatorVertical1
        ' 
        SpaceSeparatorVertical1.BackColor = Color.FromArgb(CByte(11), CByte(93), CByte(52))
        SpaceSeparatorVertical1.Dock = DockStyle.Top
        SpaceSeparatorVertical1.Font = New Font("Verdana", 8F)
        SpaceSeparatorVertical1.Location = New Point(0, 0)
        SpaceSeparatorVertical1.Name = "SpaceSeparatorVertical1"
        SpaceSeparatorVertical1.Size = New Size(192, 10)
        SpaceSeparatorVertical1.TabIndex = 9
        SpaceSeparatorVertical1.Text = "SpaceSeparatorVertical1"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(PnlHead)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1920, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' PnlHead
        ' 
        PnlHead.BackColor = Color.FromArgb(CByte(11), CByte(93), CByte(52))
        PnlHead.BackgroundImage = CType(resources.GetObject("PnlHead.BackgroundImage"), Image)
        PnlHead.BackgroundImageLayout = ImageLayout.Zoom
        PnlHead.Controls.Add(lblWelcome)
        PnlHead.Controls.Add(picLogo)
        PnlHead.Controls.Add(lblTitle)
        PnlHead.Dock = DockStyle.Top
        PnlHead.Location = New Point(0, 0)
        PnlHead.Margin = New Padding(3, 2, 3, 2)
        PnlHead.Name = "PnlHead"
        PnlHead.Size = New Size(1920, 75)
        PnlHead.TabIndex = 1
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(105, 44)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(70, 17)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome, "
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(16, 5)
        picLogo.Margin = New Padding(3, 2, 3, 2)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(79, 64)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Georgia", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(101, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(110, 31)
        lblTitle.TabIndex = 0
        lblTitle.Text = "STARS"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(8), CByte(35), CByte(18))
        pnlContent.BackgroundImageLayout = ImageLayout.Zoom
        pnlContent.Dock = DockStyle.Fill
        pnlContent.ForeColor = SystemColors.ControlText
        pnlContent.Location = New Point(192, 75)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(13, 11, 13, 11)
        pnlContent.Size = New Size(1728, 1005)
        pnlContent.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1920, 1080)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(1080, 720)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        PnlHead.ResumeLayout(False)
        PnlHead.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnLogout As RoundedButton
    Friend WithEvents btnProfile As RoundedButton
    Friend WithEvents btnView As RoundedButton
    Friend WithEvents btnSubmit As RoundedButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDashboard As RoundedButton
    Friend WithEvents PnlHead As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents SpaceSeparatorVertical1 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnExport As RoundedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
