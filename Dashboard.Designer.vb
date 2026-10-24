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
        btnLogout = New RoundedButton()
        btnProfile = New RoundedButton()
        btnView = New RoundedButton()
        pnlHeader = New Panel()
        PnlHead = New Panel()
        lblWelcome = New Label()
        picLogo = New PictureBox()
        lblTitle = New Label()
        pnlContent = New Panel()
        pnlSidebar.SuspendLayout()
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
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(btnView)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 75)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Padding = New Padding(0, 0, 0, 161)
        pnlSidebar.Size = New Size(192, 1005)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 794)
        btnLogout.Margin = New Padding(4, 8, 10, 8)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(192, 50)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Log Out"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Transparent
        btnProfile.BackgroundImageLayout = ImageLayout.None
        btnProfile.Dock = DockStyle.Top
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Verdana", 18F, FontStyle.Bold)
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(0, 50)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(192, 50)
        btnProfile.TabIndex = 0
        btnProfile.Text = "Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.Transparent
        btnView.BackgroundImageLayout = ImageLayout.None
        btnView.Dock = DockStyle.Top
        btnView.FlatAppearance.BorderSize = 0
        btnView.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnView.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Verdana", 18F, FontStyle.Bold)
        btnView.ForeColor = Color.White
        btnView.Location = New Point(0, 0)
        btnView.Name = "btnView"
        btnView.Size = New Size(192, 50)
        btnView.TabIndex = 5
        btnView.Text = "Requests"
        btnView.TextAlign = ContentAlignment.MiddleLeft
        btnView.UseVisualStyleBackColor = False
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
        pnlContent.BackColor = Color.FromArgb(CByte(13), CByte(34), CByte(24))
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
    Friend WithEvents lblTitle As Label
    Friend WithEvents PnlHead As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnView As RoundedButton
End Class
