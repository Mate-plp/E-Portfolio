<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        lblTitle = New Label()
        pnlContent = New Panel()
        pnlSidebar.SuspendLayout()
        pnlPortfolio.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(btnGrades)
        pnlSidebar.Controls.Add(pnlPortfolio)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Location = New Point(12, 118)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 320)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnGrades
        ' 
        btnGrades.Dock = DockStyle.Top
        btnGrades.FlatAppearance.BorderSize = 0
        btnGrades.FlatStyle = FlatStyle.Flat
        btnGrades.ForeColor = Color.Black
        btnGrades.Location = New Point(0, 150)
        btnGrades.Name = "btnGrades"
        btnGrades.Size = New Size(200, 50)
        btnGrades.TabIndex = 6
        btnGrades.Text = "Grades"
        btnGrades.TextAlign = ContentAlignment.MiddleLeft
        btnGrades.UseVisualStyleBackColor = True
        ' 
        ' pnlPortfolio
        ' 
        pnlPortfolio.Controls.Add(btnView)
        pnlPortfolio.Controls.Add(btnSubmit)
        pnlPortfolio.Controls.Add(btnPortfolio)
        pnlPortfolio.Dock = DockStyle.Top
        pnlPortfolio.Location = New Point(0, 100)
        pnlPortfolio.Name = "pnlPortfolio"
        pnlPortfolio.Size = New Size(200, 50)
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
        btnView.Size = New Size(200, 40)
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
        btnSubmit.Size = New Size(200, 40)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit Activity"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnPortfolio
        ' 
        btnPortfolio.Dock = DockStyle.Top
        btnPortfolio.FlatAppearance.BorderSize = 0
        btnPortfolio.FlatStyle = FlatStyle.Flat
        btnPortfolio.ForeColor = Color.Black
        btnPortfolio.Location = New Point(0, 0)
        btnPortfolio.Name = "btnPortfolio"
        btnPortfolio.Size = New Size(200, 50)
        btnPortfolio.TabIndex = 6
        btnPortfolio.Text = "Portfolio"
        btnPortfolio.TextAlign = ContentAlignment.MiddleLeft
        btnPortfolio.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(0, 270)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(200, 50)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Log Out"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnProfile
        ' 
        btnProfile.Dock = DockStyle.Top
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.ForeColor = Color.Black
        btnProfile.Location = New Point(0, 50)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(200, 50)
        btnProfile.TabIndex = 0
        btnProfile.Text = "Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.Black
        btnDashboard.Location = New Point(0, 0)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(200, 50)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(275, 38)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(278, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(112, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(30, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Title"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlContent
        ' 
        pnlContent.Anchor = AnchorStyles.None
        pnlContent.Location = New Point(218, 132)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(570, 306)
        pnlContent.TabIndex = 0
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSidebar)
        DoubleBuffered = True
        Name = "frmDashboard"
        Text = "Dashboard"
        pnlSidebar.ResumeLayout(False)
        pnlPortfolio.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
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
End Class
