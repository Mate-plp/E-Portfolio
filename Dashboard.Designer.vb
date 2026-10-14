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
        btnGrades = New Button()
        pnlPortfolio = New Panel()
        btnView = New Button()
        btnSubmit = New Button()
        btnPortfolio = New Button()
        btnLogout = New Button()
        btnProfile = New Button()
        btnDashboard = New Button()
        pnlHeader = New Panel()
        PnlHead = New Panel()
        picLogo = New PictureBox()
        lblTitle = New Label()
        pnlContent = New Panel()
        pnlSidebar.SuspendLayout()
        pnlPortfolio.SuspendLayout()
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
        pnlSidebar.BackgroundImageLayout = ImageLayout.Zoom
        pnlSidebar.Controls.Add(btnGrades)
        pnlSidebar.Controls.Add(pnlPortfolio)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 75)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(192, 606)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnGrades
        ' 
        btnGrades.BackColor = Color.Transparent
        btnGrades.Dock = DockStyle.Top
        btnGrades.FlatAppearance.BorderSize = 0
        btnGrades.FlatStyle = FlatStyle.Flat
        btnGrades.ForeColor = Color.White
        btnGrades.Location = New Point(0, 150)
        btnGrades.Name = "btnGrades"
        btnGrades.Size = New Size(192, 50)
        btnGrades.TabIndex = 6
        btnGrades.Text = "Grades"
        btnGrades.TextAlign = ContentAlignment.MiddleLeft
        btnGrades.UseVisualStyleBackColor = False
        ' 
        ' pnlPortfolio
        ' 
        pnlPortfolio.Controls.Add(btnView)
        pnlPortfolio.Controls.Add(btnSubmit)
        pnlPortfolio.Controls.Add(btnPortfolio)
        pnlPortfolio.Dock = DockStyle.Top
        pnlPortfolio.Location = New Point(0, 100)
        pnlPortfolio.Name = "pnlPortfolio"
        pnlPortfolio.Size = New Size(192, 50)
        pnlPortfolio.TabIndex = 5
        ' 
        ' btnView
        ' 
        btnView.Dock = DockStyle.Top
        btnView.FlatAppearance.BorderSize = 0
        btnView.FlatStyle = FlatStyle.Flat
        btnView.ForeColor = Color.Black
        btnView.Location = New Point(0, 90)
        btnView.Name = "btnView"
        btnView.Size = New Size(192, 40)
        btnView.TabIndex = 8
        btnView.Text = "View Activities"
        btnView.TextAlign = ContentAlignment.MiddleLeft
        btnView.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Dock = DockStyle.Top
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(0, 50)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(192, 40)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit Activity"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnPortfolio
        ' 
        btnPortfolio.BackColor = Color.Transparent
        btnPortfolio.Dock = DockStyle.Top
        btnPortfolio.FlatAppearance.BorderSize = 0
        btnPortfolio.FlatStyle = FlatStyle.Flat
        btnPortfolio.ForeColor = Color.White
        btnPortfolio.Location = New Point(0, 0)
        btnPortfolio.Name = "btnPortfolio"
        btnPortfolio.Size = New Size(192, 50)
        btnPortfolio.TabIndex = 6
        btnPortfolio.Text = "Portfolio"
        btnPortfolio.TextAlign = ContentAlignment.MiddleLeft
        btnPortfolio.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 554)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(192, 52)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Log Out"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Transparent
        btnProfile.Dock = DockStyle.Top
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(0, 50)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(192, 50)
        btnProfile.TabIndex = 0
        btnProfile.Text = "Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(0, 0)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(192, 50)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(PnlHead)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1264, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' PnlHead
        ' 
        PnlHead.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        PnlHead.BackgroundImage = CType(resources.GetObject("PnlHead.BackgroundImage"), Image)
        PnlHead.BackgroundImageLayout = ImageLayout.Zoom
        PnlHead.Controls.Add(picLogo)
        PnlHead.Controls.Add(lblTitle)
        PnlHead.Dock = DockStyle.Top
        PnlHead.Location = New Point(0, 0)
        PnlHead.Margin = New Padding(3, 2, 3, 2)
        PnlHead.Name = "PnlHead"
        PnlHead.Size = New Size(1264, 75)
        PnlHead.TabIndex = 1
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
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(115, 28)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(30, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Title"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.WhiteSmoke
        pnlContent.BackgroundImageLayout = ImageLayout.Zoom
        pnlContent.Dock = DockStyle.Fill
        pnlContent.ForeColor = SystemColors.ControlText
        pnlContent.Location = New Point(192, 75)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(13, 11, 13, 11)
        pnlContent.Size = New Size(1072, 606)
        pnlContent.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1264, 681)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        DoubleBuffered = True
        MaximumSize = New Size(1920, 1078)
        MinimumSize = New Size(898, 586)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        pnlSidebar.ResumeLayout(False)
        pnlPortfolio.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        PnlHead.ResumeLayout(False)
        PnlHead.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents pnlPortfolio As Panel
    Friend WithEvents btnGrades As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnPortfolio As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PnlHead As Panel
    Friend WithEvents picLogo As PictureBox
End Class
