<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProfile))
        lblPassword = New Label()
        lblUsername = New Label()
        lblID = New Label()
        Panel1 = New Panel()
        lblName = New Label()
        cgbUser = New RoundedPanel()
        btnLN = New RoundedButton()
        btnMN = New RoundedButton()
        btnFN = New RoundedButton()
        btnUsername = New RoundedButton()
        tbMN = New TextBox()
        Label9 = New Label()
        tbLN = New TextBox()
        Label8 = New Label()
        tbFN = New TextBox()
        tbUsername = New TextBox()
        Panel2 = New Panel()
        Label5 = New Label()
        cgbPass = New RoundedPanel()
        btnCfmPass = New RoundedButton()
        btnNewPass = New RoundedButton()
        btnOldPass = New RoundedButton()
        tbCfmPass = New TextBox()
        Label15 = New Label()
        Label2 = New Label()
        tbNewPass = New TextBox()
        tbOldPass = New TextBox()
        Label3 = New Label()
        Label7 = New Label()
        cgbStudent = New RoundedPanel()
        btnPosition = New RoundedButton()
        tbPosition = New TextBox()
        Label1 = New Label()
        tbID = New TextBox()
        Label6 = New Label()
        btnSave = New RoundedButton()
        btnDiscard = New RoundedButton()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        cgbUser.SuspendLayout()
        Panel2.SuspendLayout()
        cgbPass.SuspendLayout()
        cgbStudent.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.None
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblPassword.Location = New Point(18, 127)
        lblPassword.Margin = New Padding(18, 45, 18, 15)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(112, 25)
        lblPassword.TabIndex = 6
        lblPassword.Text = "First Name:"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblUsername.Location = New Point(18, 82)
        lblUsername.Margin = New Padding(18, 15, 18, 15)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(106, 25)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username:"
        ' 
        ' lblID
        ' 
        lblID.Anchor = AnchorStyles.None
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(22, 83)
        lblID.Margin = New Padding(18, 15, 18, 15)
        lblID.Name = "lblID"
        lblID.Size = New Size(127, 25)
        lblID.TabIndex = 5
        lblID.Text = "Professor ID:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        Panel1.Controls.Add(lblName)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1728, 95)
        Panel1.TabIndex = 8
        ' 
        ' lblName
        ' 
        lblName.Anchor = AnchorStyles.None
        lblName.Font = New Font("Georgia", 20.25F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(CByte(243), CByte(185), CByte(39))
        lblName.Location = New Point(0, 0)
        lblName.Margin = New Padding(18, 15, 18, 38)
        lblName.Name = "lblName"
        lblName.Padding = New Padding(50, 5, 5, 5)
        lblName.Size = New Size(1728, 95)
        lblName.TabIndex = 3
        lblName.Text = "PROFILE"
        lblName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cgbUser
        ' 
        cgbUser.Anchor = AnchorStyles.None
        cgbUser.BackColor = Color.White
        cgbUser.Controls.Add(btnLN)
        cgbUser.Controls.Add(btnMN)
        cgbUser.Controls.Add(btnFN)
        cgbUser.Controls.Add(btnUsername)
        cgbUser.Controls.Add(tbMN)
        cgbUser.Controls.Add(Label9)
        cgbUser.Controls.Add(tbLN)
        cgbUser.Controls.Add(Label8)
        cgbUser.Controls.Add(tbFN)
        cgbUser.Controls.Add(tbUsername)
        cgbUser.Controls.Add(lblUsername)
        cgbUser.Controls.Add(lblPassword)
        cgbUser.Controls.Add(Panel2)
        cgbUser.CornerRadius = 15
        cgbUser.FillColor = Color.Transparent
        cgbUser.ForeColor = Color.Black
        cgbUser.Location = New Point(37, 121)
        cgbUser.Name = "cgbUser"
        cgbUser.Size = New Size(547, 367)
        cgbUser.TabIndex = 9
        ' 
        ' btnLN
        ' 
        btnLN.Anchor = AnchorStyles.None
        btnLN.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLN.FlatStyle = FlatStyle.Flat
        btnLN.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnLN.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnLN.Location = New Point(471, 208)
        btnLN.Name = "btnLN"
        btnLN.Size = New Size(50, 37)
        btnLN.TabIndex = 14
        btnLN.Text = "EDIT"
        btnLN.UseVisualStyleBackColor = False
        ' 
        ' btnMN
        ' 
        btnMN.Anchor = AnchorStyles.None
        btnMN.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnMN.FlatStyle = FlatStyle.Flat
        btnMN.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnMN.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnMN.Location = New Point(471, 162)
        btnMN.Name = "btnMN"
        btnMN.Size = New Size(50, 37)
        btnMN.TabIndex = 14
        btnMN.Text = "EDIT"
        btnMN.UseVisualStyleBackColor = False
        ' 
        ' btnFN
        ' 
        btnFN.Anchor = AnchorStyles.None
        btnFN.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnFN.FlatStyle = FlatStyle.Flat
        btnFN.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnFN.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnFN.Location = New Point(471, 123)
        btnFN.Name = "btnFN"
        btnFN.Size = New Size(50, 37)
        btnFN.TabIndex = 14
        btnFN.Text = "EDIT"
        btnFN.UseVisualStyleBackColor = False
        ' 
        ' btnUsername
        ' 
        btnUsername.Anchor = AnchorStyles.None
        btnUsername.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnUsername.BackgroundImageLayout = ImageLayout.Zoom
        btnUsername.FlatStyle = FlatStyle.Flat
        btnUsername.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnUsername.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnUsername.Location = New Point(471, 75)
        btnUsername.Name = "btnUsername"
        btnUsername.Size = New Size(50, 37)
        btnUsername.TabIndex = 14
        btnUsername.Text = "EDIT"
        btnUsername.UseVisualStyleBackColor = False
        ' 
        ' tbMN
        ' 
        tbMN.Anchor = AnchorStyles.None
        tbMN.BackColor = Color.White
        tbMN.Enabled = False
        tbMN.Font = New Font("Tahoma", 11F)
        tbMN.ForeColor = Color.Black
        tbMN.Location = New Point(164, 169)
        tbMN.Name = "tbMN"
        tbMN.Size = New Size(289, 25)
        tbMN.TabIndex = 3
        tbMN.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(18, 167)
        Label9.Margin = New Padding(18, 45, 18, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 25)
        Label9.TabIndex = 12
        Label9.Text = "Middle Name:"
        ' 
        ' tbLN
        ' 
        tbLN.Anchor = AnchorStyles.None
        tbLN.BackColor = Color.White
        tbLN.Enabled = False
        tbLN.Font = New Font("Tahoma", 11F)
        tbLN.ForeColor = Color.Black
        tbLN.Location = New Point(164, 214)
        tbLN.Name = "tbLN"
        tbLN.Size = New Size(289, 25)
        tbLN.TabIndex = 4
        tbLN.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(18, 212)
        Label8.Margin = New Padding(18, 45, 18, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 25)
        Label8.TabIndex = 10
        Label8.Text = "Last Name:"
        ' 
        ' tbFN
        ' 
        tbFN.Anchor = AnchorStyles.None
        tbFN.BackColor = Color.White
        tbFN.Enabled = False
        tbFN.Font = New Font("Tahoma", 11F)
        tbFN.ForeColor = Color.Black
        tbFN.Location = New Point(164, 129)
        tbFN.Name = "tbFN"
        tbFN.Size = New Size(289, 25)
        tbFN.TabIndex = 2
        tbFN.TabStop = False
        ' 
        ' tbUsername
        ' 
        tbUsername.Anchor = AnchorStyles.None
        tbUsername.BackColor = Color.White
        tbUsername.Enabled = False
        tbUsername.Font = New Font("Tahoma", 11F)
        tbUsername.ForeColor = Color.Black
        tbUsername.Location = New Point(164, 82)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(289, 25)
        tbUsername.TabIndex = 1
        tbUsername.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(547, 63)
        Panel2.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(18, 10)
        Label5.Margin = New Padding(18, 15, 18, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 37)
        Label5.TabIndex = 9
        Label5.Text = "User Info"
        ' 
        ' cgbPass
        ' 
        cgbPass.Anchor = AnchorStyles.None
        cgbPass.BackColor = Color.Transparent
        cgbPass.Controls.Add(btnCfmPass)
        cgbPass.Controls.Add(btnNewPass)
        cgbPass.Controls.Add(btnOldPass)
        cgbPass.Controls.Add(tbCfmPass)
        cgbPass.Controls.Add(Label15)
        cgbPass.Controls.Add(Label2)
        cgbPass.Controls.Add(tbNewPass)
        cgbPass.Controls.Add(tbOldPass)
        cgbPass.Controls.Add(Label3)
        cgbPass.CornerRadius = 15
        cgbPass.ForeColor = Color.Black
        cgbPass.Location = New Point(37, 500)
        cgbPass.Name = "cgbPass"
        cgbPass.Size = New Size(547, 277)
        cgbPass.TabIndex = 10
        ' 
        ' btnCfmPass
        ' 
        btnCfmPass.Anchor = AnchorStyles.None
        btnCfmPass.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnCfmPass.FlatStyle = FlatStyle.Flat
        btnCfmPass.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnCfmPass.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnCfmPass.Location = New Point(480, 176)
        btnCfmPass.Name = "btnCfmPass"
        btnCfmPass.Size = New Size(50, 37)
        btnCfmPass.TabIndex = 14
        btnCfmPass.Text = "EDIT"
        btnCfmPass.UseVisualStyleBackColor = False
        ' 
        ' btnNewPass
        ' 
        btnNewPass.Anchor = AnchorStyles.None
        btnNewPass.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnNewPass.FlatStyle = FlatStyle.Flat
        btnNewPass.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnNewPass.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnNewPass.Location = New Point(480, 120)
        btnNewPass.Name = "btnNewPass"
        btnNewPass.Size = New Size(50, 37)
        btnNewPass.TabIndex = 14
        btnNewPass.Text = "EDIT"
        btnNewPass.UseVisualStyleBackColor = False
        ' 
        ' btnOldPass
        ' 
        btnOldPass.Anchor = AnchorStyles.None
        btnOldPass.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnOldPass.FlatStyle = FlatStyle.Flat
        btnOldPass.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnOldPass.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnOldPass.Location = New Point(480, 70)
        btnOldPass.Name = "btnOldPass"
        btnOldPass.Size = New Size(50, 37)
        btnOldPass.TabIndex = 14
        btnOldPass.Text = "EDIT"
        btnOldPass.UseVisualStyleBackColor = False
        ' 
        ' tbCfmPass
        ' 
        tbCfmPass.Anchor = AnchorStyles.None
        tbCfmPass.BackColor = Color.White
        tbCfmPass.Enabled = False
        tbCfmPass.Font = New Font("Tahoma", 11F)
        tbCfmPass.ForeColor = Color.Black
        tbCfmPass.Location = New Point(200, 182)
        tbCfmPass.Name = "tbCfmPass"
        tbCfmPass.Size = New Size(266, 25)
        tbCfmPass.TabIndex = 17
        tbCfmPass.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.None
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label15.Location = New Point(16, 180)
        Label15.Margin = New Padding(18, 45, 18, 15)
        Label15.Name = "Label15"
        Label15.Size = New Size(180, 25)
        Label15.TabIndex = 16
        Label15.Text = "Confirm Password:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(17, 126)
        Label2.Margin = New Padding(18, 45, 18, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 9
        Label2.Text = "New Password:"
        ' 
        ' tbNewPass
        ' 
        tbNewPass.Anchor = AnchorStyles.None
        tbNewPass.BackColor = Color.White
        tbNewPass.Enabled = False
        tbNewPass.Font = New Font("Tahoma", 11F)
        tbNewPass.ForeColor = Color.Black
        tbNewPass.Location = New Point(200, 127)
        tbNewPass.Name = "tbNewPass"
        tbNewPass.Size = New Size(266, 25)
        tbNewPass.TabIndex = 15
        tbNewPass.TabStop = False
        ' 
        ' tbOldPass
        ' 
        tbOldPass.Anchor = AnchorStyles.None
        tbOldPass.BackColor = Color.White
        tbOldPass.Enabled = False
        tbOldPass.Font = New Font("Tahoma", 11F)
        tbOldPass.ForeColor = Color.Black
        tbOldPass.Location = New Point(200, 76)
        tbOldPass.Name = "tbOldPass"
        tbOldPass.Size = New Size(266, 25)
        tbOldPass.TabIndex = 14
        tbOldPass.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(21, 73)
        Label3.Margin = New Padding(18, 45, 18, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 25)
        Label3.TabIndex = 6
        Label3.Text = "Old Password:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(18, 9)
        Label7.Margin = New Padding(18, 15, 18, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(242, 37)
        Label7.TabIndex = 10
        Label7.Text = "Change Password"
        ' 
        ' cgbStudent
        ' 
        cgbStudent.Anchor = AnchorStyles.None
        cgbStudent.BackColor = Color.Transparent
        cgbStudent.Controls.Add(btnPosition)
        cgbStudent.Controls.Add(tbPosition)
        cgbStudent.Controls.Add(Label1)
        cgbStudent.Controls.Add(tbID)
        cgbStudent.Controls.Add(lblID)
        cgbStudent.CornerRadius = 15
        cgbStudent.ForeColor = Color.Black
        cgbStudent.Location = New Point(595, 121)
        cgbStudent.Name = "cgbStudent"
        cgbStudent.Size = New Size(531, 312)
        cgbStudent.TabIndex = 11
        ' 
        ' btnPosition
        ' 
        btnPosition.Anchor = AnchorStyles.None
        btnPosition.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnPosition.FlatStyle = FlatStyle.Flat
        btnPosition.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnPosition.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnPosition.Location = New Point(449, 122)
        btnPosition.Name = "btnPosition"
        btnPosition.Size = New Size(50, 37)
        btnPosition.TabIndex = 14
        btnPosition.Text = "EDIT"
        btnPosition.UseVisualStyleBackColor = False
        ' 
        ' tbPosition
        ' 
        tbPosition.Anchor = AnchorStyles.None
        tbPosition.BackColor = Color.White
        tbPosition.Enabled = False
        tbPosition.Font = New Font("Tahoma", 11F)
        tbPosition.ForeColor = Color.Black
        tbPosition.Location = New Point(158, 128)
        tbPosition.Name = "tbPosition"
        tbPosition.Size = New Size(277, 25)
        tbPosition.TabIndex = 6
        tbPosition.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 127)
        Label1.Margin = New Padding(18, 15, 18, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 25)
        Label1.TabIndex = 8
        Label1.Text = "Position"
        ' 
        ' tbID
        ' 
        tbID.Anchor = AnchorStyles.None
        tbID.BackColor = Color.White
        tbID.Enabled = False
        tbID.Font = New Font("Tahoma", 11F)
        tbID.ForeColor = Color.Black
        tbID.Location = New Point(158, 81)
        tbID.Name = "tbID"
        tbID.Size = New Size(277, 25)
        tbID.TabIndex = 5
        tbID.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(10, 8)
        Label6.Margin = New Padding(18, 15, 18, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 37)
        Label6.TabIndex = 12
        Label6.Text = "Faculty Info"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.None
        btnSave.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnSave.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnSave.Location = New Point(952, 451)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(174, 50)
        btnSave.TabIndex = 13
        btnSave.Text = "SAVE CHANGES"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnDiscard
        ' 
        btnDiscard.Anchor = AnchorStyles.None
        btnDiscard.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnDiscard.FlatStyle = FlatStyle.Flat
        btnDiscard.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnDiscard.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnDiscard.Location = New Point(762, 451)
        btnDiscard.Name = "btnDiscard"
        btnDiscard.Size = New Size(174, 50)
        btnDiscard.TabIndex = 14
        btnDiscard.Text = "DISCARD CHANGES"
        btnDiscard.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(595, 121)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(531, 63)
        Panel3.TabIndex = 16
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.None
        Panel4.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(37, 501)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(547, 57)
        Panel4.TabIndex = 16
        ' 
        ' ucProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(btnDiscard)
        Controls.Add(btnSave)
        Controls.Add(cgbPass)
        Controls.Add(cgbUser)
        Controls.Add(Panel1)
        Controls.Add(cgbStudent)
        DoubleBuffered = True
        Name = "ucProfile"
        Size = New Size(1728, 1005)
        Panel1.ResumeLayout(False)
        cgbUser.ResumeLayout(False)
        cgbUser.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        cgbPass.ResumeLayout(False)
        cgbPass.PerformLayout()
        cgbStudent.ResumeLayout(False)
        cgbStudent.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents cgbUser As RoundedPanel
    Friend WithEvents tbFN As System.Windows.Forms.TextBox
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents cgbPass As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNewPass As System.Windows.Forms.TextBox
    Friend WithEvents tbOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cgbStudent As RoundedPanel
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMN As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbLN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbCfmPass As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents btnLN As RoundedButton
    Friend WithEvents btnMN As RoundedButton
    Friend WithEvents btnFN As RoundedButton
    Friend WithEvents btnUsername As RoundedButton
    Friend WithEvents btnOldPass As RoundedButton
    Friend WithEvents btnPosition As RoundedButton
    Friend WithEvents btnCfmPass As RoundedButton
    Friend WithEvents btnNewPass As RoundedButton
    Friend WithEvents btnDiscard As RoundedButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel

End Class
