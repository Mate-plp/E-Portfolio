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
        lblPassword = New Label()
        lblAddress = New Label()
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
        Label5 = New Label()
        tbFN = New TextBox()
        tbUsername = New TextBox()
        cgbPass = New RoundedPanel()
        btnCfmPass = New RoundedButton()
        btnNewPass = New RoundedButton()
        btnOldPass = New RoundedButton()
        tbCfmPass = New TextBox()
        Label15 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        tbNewPass = New TextBox()
        tbOldPass = New TextBox()
        Label3 = New Label()
        cgbStudent = New RoundedPanel()
        btnYear = New RoundedButton()
        btnProgram = New RoundedButton()
        Label6 = New Label()
        tbYear = New TextBox()
        tbProgram = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        tbID = New TextBox()
        cgbAdd = New RoundedPanel()
        btnRegion = New RoundedButton()
        btnBar = New RoundedButton()
        btnCity = New RoundedButton()
        btnLine2 = New RoundedButton()
        btnLine1 = New RoundedButton()
        tbRegion = New TextBox()
        tbBar = New TextBox()
        tbCity = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        tbLine1 = New TextBox()
        tbLine2 = New TextBox()
        Label11 = New Label()
        btnSave = New RoundedButton()
        btnDiscard = New RoundedButton()
        Panel1.SuspendLayout()
        cgbUser.SuspendLayout()
        cgbPass.SuspendLayout()
        cgbStudent.SuspendLayout()
        cgbAdd.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.None
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblPassword.Location = New Point(61, 136)
        lblPassword.Margin = New Padding(18, 45, 18, 15)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(112, 25)
        lblPassword.TabIndex = 6
        lblPassword.Text = "First Name:"
        ' 
        ' lblAddress
        ' 
        lblAddress.Anchor = AnchorStyles.None
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblAddress.Location = New Point(106, 69)
        lblAddress.Margin = New Padding(18, 45, 18, 15)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(70, 25)
        lblAddress.TabIndex = 7
        lblAddress.Text = "Line 1:"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblUsername.Location = New Point(65, 75)
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
        lblID.Location = New Point(63, 68)
        lblID.Margin = New Padding(18, 15, 18, 15)
        lblID.Name = "lblID"
        lblID.Size = New Size(113, 25)
        lblID.TabIndex = 5
        lblID.Text = "Student ID:"
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
        lblName.Dock = DockStyle.Fill
        lblName.Font = New Font("Verdana", 18.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.White
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
        cgbUser.BackColor = Color.Transparent
        cgbUser.Controls.Add(btnLN)
        cgbUser.Controls.Add(btnMN)
        cgbUser.Controls.Add(btnFN)
        cgbUser.Controls.Add(btnUsername)
        cgbUser.Controls.Add(tbMN)
        cgbUser.Controls.Add(Label9)
        cgbUser.Controls.Add(tbLN)
        cgbUser.Controls.Add(Label8)
        cgbUser.Controls.Add(Label5)
        cgbUser.Controls.Add(tbFN)
        cgbUser.Controls.Add(tbUsername)
        cgbUser.Controls.Add(lblUsername)
        cgbUser.Controls.Add(lblPassword)
        cgbUser.CornerRadius = 15
        cgbUser.FillColor = Color.Transparent
        cgbUser.ForeColor = Color.Black
        cgbUser.Location = New Point(37, 100)
        cgbUser.Name = "cgbUser"
        cgbUser.Size = New Size(547, 367)
        cgbUser.TabIndex = 9
        ' 
        ' btnLN
        ' 
        btnLN.Anchor = AnchorStyles.None
        btnLN.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLN.FlatStyle = FlatStyle.Flat
        btnLN.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnLN.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnLN.Location = New Point(480, 234)
        btnLN.Name = "btnLN"
        btnLN.Size = New Size(50, 50)
        btnLN.TabIndex = 14
        btnLN.UseVisualStyleBackColor = False
        ' 
        ' btnMN
        ' 
        btnMN.Anchor = AnchorStyles.None
        btnMN.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnMN.FlatStyle = FlatStyle.Flat
        btnMN.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnMN.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnMN.Location = New Point(480, 178)
        btnMN.Name = "btnMN"
        btnMN.Size = New Size(50, 50)
        btnMN.TabIndex = 14
        btnMN.UseVisualStyleBackColor = False
        ' 
        ' btnFN
        ' 
        btnFN.Anchor = AnchorStyles.None
        btnFN.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnFN.FlatStyle = FlatStyle.Flat
        btnFN.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnFN.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnFN.Location = New Point(480, 116)
        btnFN.Name = "btnFN"
        btnFN.Size = New Size(50, 50)
        btnFN.TabIndex = 14
        btnFN.UseVisualStyleBackColor = False
        ' 
        ' btnUsername
        ' 
        btnUsername.Anchor = AnchorStyles.None
        btnUsername.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnUsername.FlatStyle = FlatStyle.Flat
        btnUsername.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnUsername.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnUsername.Location = New Point(480, 56)
        btnUsername.Name = "btnUsername"
        btnUsername.Size = New Size(50, 50)
        btnUsername.TabIndex = 14
        btnUsername.UseVisualStyleBackColor = False
        ' 
        ' tbMN
        ' 
        tbMN.Anchor = AnchorStyles.None
        tbMN.BackColor = Color.White
        tbMN.Enabled = False
        tbMN.Font = New Font("Tahoma", 11F)
        tbMN.ForeColor = Color.Black
        tbMN.Location = New Point(195, 189)
        tbMN.Name = "tbMN"
        tbMN.Size = New Size(266, 25)
        tbMN.TabIndex = 3
        tbMN.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(35, 201)
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
        tbLN.Location = New Point(195, 251)
        tbLN.Name = "tbLN"
        tbLN.Size = New Size(266, 25)
        tbLN.TabIndex = 4
        tbLN.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(61, 263)
        Label8.Margin = New Padding(18, 45, 18, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 25)
        Label8.TabIndex = 10
        Label8.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label5.Location = New Point(55, 15)
        Label5.Margin = New Padding(18, 15, 18, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 37)
        Label5.TabIndex = 9
        Label5.Text = "User Info"
        ' 
        ' tbFN
        ' 
        tbFN.Anchor = AnchorStyles.None
        tbFN.BackColor = Color.White
        tbFN.Enabled = False
        tbFN.Font = New Font("Tahoma", 11F)
        tbFN.ForeColor = Color.Black
        tbFN.Location = New Point(195, 128)
        tbFN.Name = "tbFN"
        tbFN.Size = New Size(266, 25)
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
        tbUsername.Location = New Point(195, 68)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(266, 25)
        tbUsername.TabIndex = 1
        tbUsername.TabStop = False
        tbUsername.Text = "TEST DELETE THIS"
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
        cgbPass.Controls.Add(Label7)
        cgbPass.Controls.Add(Label2)
        cgbPass.Controls.Add(tbNewPass)
        cgbPass.Controls.Add(tbOldPass)
        cgbPass.Controls.Add(Label3)
        cgbPass.CornerRadius = 15
        cgbPass.FillColor = Color.Transparent
        cgbPass.ForeColor = Color.Black
        cgbPass.Location = New Point(37, 479)
        cgbPass.Name = "cgbPass"
        cgbPass.Size = New Size(547, 277)
        cgbPass.TabIndex = 10
        ' 
        ' btnCfmPass
        ' 
        btnCfmPass.Anchor = AnchorStyles.None
        btnCfmPass.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnCfmPass.FlatStyle = FlatStyle.Flat
        btnCfmPass.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnCfmPass.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnCfmPass.Location = New Point(494, 195)
        btnCfmPass.Name = "btnCfmPass"
        btnCfmPass.Size = New Size(50, 50)
        btnCfmPass.TabIndex = 14
        btnCfmPass.UseVisualStyleBackColor = False
        ' 
        ' btnNewPass
        ' 
        btnNewPass.Anchor = AnchorStyles.None
        btnNewPass.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnNewPass.FlatStyle = FlatStyle.Flat
        btnNewPass.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnNewPass.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnNewPass.Location = New Point(480, 119)
        btnNewPass.Name = "btnNewPass"
        btnNewPass.Size = New Size(50, 50)
        btnNewPass.TabIndex = 14
        btnNewPass.UseVisualStyleBackColor = False
        ' 
        ' btnOldPass
        ' 
        btnOldPass.Anchor = AnchorStyles.None
        btnOldPass.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnOldPass.FlatStyle = FlatStyle.Flat
        btnOldPass.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnOldPass.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnOldPass.Location = New Point(480, 49)
        btnOldPass.Name = "btnOldPass"
        btnOldPass.Size = New Size(50, 50)
        btnOldPass.TabIndex = 14
        btnOldPass.UseVisualStyleBackColor = False
        ' 
        ' tbCfmPass
        ' 
        tbCfmPass.Anchor = AnchorStyles.None
        tbCfmPass.BackColor = Color.White
        tbCfmPass.Enabled = False
        tbCfmPass.Font = New Font("Tahoma", 11F)
        tbCfmPass.ForeColor = Color.Black
        tbCfmPass.Location = New Point(216, 207)
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
        Label15.Location = New Point(24, 205)
        Label15.Margin = New Padding(18, 45, 18, 15)
        Label15.Name = "Label15"
        Label15.Size = New Size(180, 25)
        Label15.TabIndex = 16
        Label15.Text = "Confirm Password:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label7.Location = New Point(55, 15)
        Label7.Margin = New Padding(18, 15, 18, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(242, 37)
        Label7.TabIndex = 10
        Label7.Text = "Change Password"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(31, 155)
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
        tbNewPass.Location = New Point(200, 139)
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
        tbOldPass.Location = New Point(200, 61)
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
        Label3.Location = New Point(37, 72)
        Label3.Margin = New Padding(18, 45, 18, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 25)
        Label3.TabIndex = 6
        Label3.Text = "Old Password:"
        ' 
        ' cgbStudent
        ' 
        cgbStudent.Anchor = AnchorStyles.None
        cgbStudent.BackColor = Color.Transparent
        cgbStudent.Controls.Add(btnYear)
        cgbStudent.Controls.Add(btnProgram)
        cgbStudent.Controls.Add(Label6)
        cgbStudent.Controls.Add(tbYear)
        cgbStudent.Controls.Add(tbProgram)
        cgbStudent.Controls.Add(Label4)
        cgbStudent.Controls.Add(Label1)
        cgbStudent.Controls.Add(tbID)
        cgbStudent.Controls.Add(lblID)
        cgbStudent.CornerRadius = 15
        cgbStudent.FillColor = Color.Transparent
        cgbStudent.ForeColor = Color.Black
        cgbStudent.Location = New Point(595, 100)
        cgbStudent.Name = "cgbStudent"
        cgbStudent.Size = New Size(531, 312)
        cgbStudent.TabIndex = 11
        ' 
        ' btnYear
        ' 
        btnYear.Anchor = AnchorStyles.None
        btnYear.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnYear.FlatStyle = FlatStyle.Flat
        btnYear.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnYear.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnYear.Location = New Point(441, 158)
        btnYear.Name = "btnYear"
        btnYear.Size = New Size(50, 50)
        btnYear.TabIndex = 14
        btnYear.UseVisualStyleBackColor = False
        ' 
        ' btnProgram
        ' 
        btnProgram.Anchor = AnchorStyles.None
        btnProgram.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnProgram.FlatStyle = FlatStyle.Flat
        btnProgram.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnProgram.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnProgram.Location = New Point(441, 103)
        btnProgram.Name = "btnProgram"
        btnProgram.Size = New Size(50, 50)
        btnProgram.TabIndex = 14
        btnProgram.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label6.Location = New Point(71, 15)
        Label6.Margin = New Padding(18, 15, 18, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 37)
        Label6.TabIndex = 12
        Label6.Text = "Student Info"
        ' 
        ' tbYear
        ' 
        tbYear.Anchor = AnchorStyles.None
        tbYear.BackColor = Color.White
        tbYear.Enabled = False
        tbYear.Font = New Font("Tahoma", 11F)
        tbYear.ForeColor = Color.Black
        tbYear.Location = New Point(221, 170)
        tbYear.Name = "tbYear"
        tbYear.Size = New Size(200, 25)
        tbYear.TabIndex = 7
        tbYear.TabStop = False
        ' 
        ' tbProgram
        ' 
        tbProgram.Anchor = AnchorStyles.None
        tbProgram.BackColor = Color.White
        tbProgram.Enabled = False
        tbProgram.Font = New Font("Tahoma", 11F)
        tbProgram.ForeColor = Color.Black
        tbProgram.Location = New Point(221, 116)
        tbProgram.Name = "tbProgram"
        tbProgram.Size = New Size(200, 25)
        tbProgram.TabIndex = 6
        tbProgram.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(71, 178)
        Label4.Margin = New Padding(18, 15, 18, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 25)
        Label4.TabIndex = 9
        Label4.Text = "Year Level:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(80, 123)
        Label1.Margin = New Padding(18, 15, 18, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 8
        Label1.Text = "Program:"
        ' 
        ' tbID
        ' 
        tbID.Anchor = AnchorStyles.None
        tbID.BackColor = Color.White
        tbID.Enabled = False
        tbID.Font = New Font("Tahoma", 11F)
        tbID.ForeColor = Color.Black
        tbID.Location = New Point(221, 59)
        tbID.Name = "tbID"
        tbID.Size = New Size(200, 25)
        tbID.TabIndex = 5
        tbID.TabStop = False
        ' 
        ' cgbAdd
        ' 
        cgbAdd.Anchor = AnchorStyles.None
        cgbAdd.BackColor = Color.Transparent
        cgbAdd.Controls.Add(btnRegion)
        cgbAdd.Controls.Add(btnBar)
        cgbAdd.Controls.Add(btnCity)
        cgbAdd.Controls.Add(btnLine2)
        cgbAdd.Controls.Add(btnLine1)
        cgbAdd.Controls.Add(tbRegion)
        cgbAdd.Controls.Add(tbBar)
        cgbAdd.Controls.Add(tbCity)
        cgbAdd.Controls.Add(Label14)
        cgbAdd.Controls.Add(Label13)
        cgbAdd.Controls.Add(Label12)
        cgbAdd.Controls.Add(Label10)
        cgbAdd.Controls.Add(tbLine1)
        cgbAdd.Controls.Add(tbLine2)
        cgbAdd.Controls.Add(Label11)
        cgbAdd.Controls.Add(lblAddress)
        cgbAdd.CornerRadius = 15
        cgbAdd.FillColor = Color.Transparent
        cgbAdd.ForeColor = Color.Black
        cgbAdd.Location = New Point(595, 418)
        cgbAdd.Name = "cgbAdd"
        cgbAdd.Size = New Size(729, 338)
        cgbAdd.TabIndex = 12
        ' 
        ' btnRegion
        ' 
        btnRegion.Anchor = AnchorStyles.None
        btnRegion.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegion.FlatStyle = FlatStyle.Flat
        btnRegion.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnRegion.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnRegion.Location = New Point(584, 268)
        btnRegion.Name = "btnRegion"
        btnRegion.Size = New Size(50, 50)
        btnRegion.TabIndex = 14
        btnRegion.UseVisualStyleBackColor = False
        ' 
        ' btnBar
        ' 
        btnBar.Anchor = AnchorStyles.None
        btnBar.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnBar.FlatStyle = FlatStyle.Flat
        btnBar.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnBar.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnBar.Location = New Point(666, 165)
        btnBar.Name = "btnBar"
        btnBar.Size = New Size(50, 50)
        btnBar.TabIndex = 14
        btnBar.UseVisualStyleBackColor = False
        ' 
        ' btnCity
        ' 
        btnCity.Anchor = AnchorStyles.None
        btnCity.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnCity.FlatStyle = FlatStyle.Flat
        btnCity.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnCity.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnCity.Location = New Point(253, 165)
        btnCity.Name = "btnCity"
        btnCity.Size = New Size(50, 50)
        btnCity.TabIndex = 14
        btnCity.UseVisualStyleBackColor = False
        ' 
        ' btnLine2
        ' 
        btnLine2.Anchor = AnchorStyles.None
        btnLine2.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLine2.FlatStyle = FlatStyle.Flat
        btnLine2.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnLine2.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnLine2.Location = New Point(666, 102)
        btnLine2.Name = "btnLine2"
        btnLine2.Size = New Size(50, 50)
        btnLine2.TabIndex = 14
        btnLine2.UseVisualStyleBackColor = False
        ' 
        ' btnLine1
        ' 
        btnLine1.Anchor = AnchorStyles.None
        btnLine1.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLine1.FlatStyle = FlatStyle.Flat
        btnLine1.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnLine1.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnLine1.Location = New Point(666, 41)
        btnLine1.Name = "btnLine1"
        btnLine1.Size = New Size(50, 50)
        btnLine1.TabIndex = 14
        btnLine1.UseVisualStyleBackColor = False
        ' 
        ' tbRegion
        ' 
        tbRegion.Anchor = AnchorStyles.None
        tbRegion.BackColor = Color.White
        tbRegion.Enabled = False
        tbRegion.Font = New Font("Tahoma", 11F)
        tbRegion.ForeColor = Color.Black
        tbRegion.Location = New Point(197, 281)
        tbRegion.Name = "tbRegion"
        tbRegion.Size = New Size(381, 25)
        tbRegion.TabIndex = 13
        tbRegion.TabStop = False
        ' 
        ' tbBar
        ' 
        tbBar.Anchor = AnchorStyles.None
        tbBar.BackColor = Color.White
        tbBar.Enabled = False
        tbBar.Font = New Font("Tahoma", 11F)
        tbBar.ForeColor = Color.Black
        tbBar.Location = New Point(441, 174)
        tbBar.Name = "tbBar"
        tbBar.Size = New Size(219, 25)
        tbBar.TabIndex = 11
        tbBar.TabStop = False
        ' 
        ' tbCity
        ' 
        tbCity.Anchor = AnchorStyles.None
        tbCity.BackColor = Color.White
        tbCity.Enabled = False
        tbCity.Font = New Font("Tahoma", 11F)
        tbCity.ForeColor = Color.Black
        tbCity.Location = New Point(115, 174)
        tbCity.Name = "tbCity"
        tbCity.Size = New Size(132, 25)
        tbCity.TabIndex = 10
        tbCity.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(100, 293)
        Label14.Margin = New Padding(18, 15, 18, 15)
        Label14.Name = "Label14"
        Label14.Size = New Size(80, 25)
        Label14.TabIndex = 15
        Label14.Text = "Region:"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(43, 190)
        Label13.Margin = New Padding(18, 15, 18, 15)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 25)
        Label13.TabIndex = 14
        Label13.Text = "City:"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label12.Location = New Point(106, 127)
        Label12.Margin = New Padding(18, 45, 18, 15)
        Label12.Name = "Label12"
        Label12.Size = New Size(70, 25)
        Label12.TabIndex = 13
        Label12.Text = "Line 2:"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label10.Location = New Point(61, 15)
        Label10.Margin = New Padding(18, 15, 18, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 37)
        Label10.TabIndex = 12
        Label10.Text = "Address"
        ' 
        ' tbLine1
        ' 
        tbLine1.Anchor = AnchorStyles.None
        tbLine1.BackColor = Color.White
        tbLine1.Enabled = False
        tbLine1.Font = New Font("Tahoma", 11F)
        tbLine1.ForeColor = Color.Black
        tbLine1.Location = New Point(197, 53)
        tbLine1.Name = "tbLine1"
        tbLine1.Size = New Size(463, 25)
        tbLine1.TabIndex = 8
        tbLine1.TabStop = False
        ' 
        ' tbLine2
        ' 
        tbLine2.Anchor = AnchorStyles.None
        tbLine2.BackColor = Color.White
        tbLine2.Enabled = False
        tbLine2.Font = New Font("Tahoma", 11F)
        tbLine2.ForeColor = Color.Black
        tbLine2.Location = New Point(197, 111)
        tbLine2.Name = "tbLine2"
        tbLine2.Size = New Size(463, 25)
        tbLine2.TabIndex = 9
        tbLine2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(339, 186)
        Label11.Margin = New Padding(18, 15, 18, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 25)
        Label11.TabIndex = 9
        Label11.Text = "Barangay:"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.None
        btnSave.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnSave.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnSave.Location = New Point(1242, 825)
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
        btnDiscard.Location = New Point(1036, 825)
        btnDiscard.Name = "btnDiscard"
        btnDiscard.Size = New Size(174, 50)
        btnDiscard.TabIndex = 14
        btnDiscard.Text = "DISCARD CHANGES"
        btnDiscard.UseVisualStyleBackColor = False
        ' 
        ' ucProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        Controls.Add(btnDiscard)
        Controls.Add(btnSave)
        Controls.Add(cgbAdd)
        Controls.Add(cgbStudent)
        Controls.Add(cgbPass)
        Controls.Add(cgbUser)
        Controls.Add(Panel1)
        Name = "ucProfile"
        Size = New Size(1728, 1005)
        Panel1.ResumeLayout(False)
        cgbUser.ResumeLayout(False)
        cgbUser.PerformLayout()
        cgbPass.ResumeLayout(False)
        cgbPass.PerformLayout()
        cgbStudent.ResumeLayout(False)
        cgbStudent.PerformLayout()
        cgbAdd.ResumeLayout(False)
        cgbAdd.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblAddress As Label
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
    Friend WithEvents tbYear As System.Windows.Forms.TextBox
    Friend WithEvents tbProgram As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMN As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbLN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cgbAdd As RoundedPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbLine1 As System.Windows.Forms.TextBox
    Friend WithEvents tbLine2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbRegion As System.Windows.Forms.TextBox
    Friend WithEvents tbBar As System.Windows.Forms.TextBox
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents tbCfmPass As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents btnLN As RoundedButton
    Friend WithEvents btnMN As RoundedButton
    Friend WithEvents btnFN As RoundedButton
    Friend WithEvents btnUsername As RoundedButton
    Friend WithEvents btnOldPass As RoundedButton
    Friend WithEvents btnYear As RoundedButton
    Friend WithEvents btnProgram As RoundedButton
    Friend WithEvents btnCfmPass As RoundedButton
    Friend WithEvents btnNewPass As RoundedButton
    Friend WithEvents btnRegion As RoundedButton
    Friend WithEvents btnBar As RoundedButton
    Friend WithEvents btnCity As RoundedButton
    Friend WithEvents btnLine2 As RoundedButton
    Friend WithEvents btnLine1 As RoundedButton
    Friend WithEvents btnDiscard As RoundedButton

End Class
