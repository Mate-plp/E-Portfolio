<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        lblTitle = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        lblConfirmPassword = New Label()
        chkShowPassword = New CheckBox()
        lblPasswordStrength = New Label()
        pnlCreateAcc = New Panel()
        Label1 = New Label()
        txtStudentId = New TextBox()
        lblStudentId = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtMiddleName = New TextBox()
        lblMiddleName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        btnBack = New RoundedButton()
        btnRegister = New RoundedButton()
        txtUsername = New TextBox()
        txtConfirm = New TextBox()
        txtPassword = New TextBox()
        pnlCreateAcc.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(333, 60)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(297, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CREATE ACCOUNT"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(568, 154)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(76, 19)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.None
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(569, 216)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(73, 19)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.Anchor = AnchorStyles.None
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.BackColor = Color.Transparent
        lblConfirmPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmPassword.ForeColor = Color.White
        lblConfirmPassword.Location = New Point(570, 278)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(131, 19)
        lblConfirmPassword.TabIndex = 3
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.Anchor = AnchorStyles.None
        chkShowPassword.AutoSize = True
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(576, 342)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 7
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblPasswordStrength
        ' 
        lblPasswordStrength.Anchor = AnchorStyles.None
        lblPasswordStrength.AutoSize = True
        lblPasswordStrength.BackColor = Color.Transparent
        lblPasswordStrength.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPasswordStrength.ForeColor = Color.White
        lblPasswordStrength.Location = New Point(712, 388)
        lblPasswordStrength.Name = "lblPasswordStrength"
        lblPasswordStrength.Size = New Size(21, 19)
        lblPasswordStrength.TabIndex = 8
        lblPasswordStrength.Text = "..."
        ' 
        ' pnlCreateAcc
        ' 
        pnlCreateAcc.Anchor = AnchorStyles.None
        pnlCreateAcc.BackColor = Color.FromArgb(CByte(5), CByte(53), CByte(44))
        pnlCreateAcc.BorderStyle = BorderStyle.Fixed3D
        pnlCreateAcc.Controls.Add(Label1)
        pnlCreateAcc.Controls.Add(txtStudentId)
        pnlCreateAcc.Controls.Add(lblStudentId)
        pnlCreateAcc.Controls.Add(txtLastName)
        pnlCreateAcc.Controls.Add(lblLastName)
        pnlCreateAcc.Controls.Add(txtMiddleName)
        pnlCreateAcc.Controls.Add(lblMiddleName)
        pnlCreateAcc.Controls.Add(txtFirstName)
        pnlCreateAcc.Controls.Add(lblFirstName)
        pnlCreateAcc.Controls.Add(btnBack)
        pnlCreateAcc.Controls.Add(btnRegister)
        pnlCreateAcc.Controls.Add(txtUsername)
        pnlCreateAcc.Controls.Add(txtConfirm)
        pnlCreateAcc.Controls.Add(txtPassword)
        pnlCreateAcc.Controls.Add(lblTitle)
        pnlCreateAcc.Controls.Add(lblUsername)
        pnlCreateAcc.Controls.Add(lblPasswordStrength)
        pnlCreateAcc.Controls.Add(chkShowPassword)
        pnlCreateAcc.Controls.Add(lblPassword)
        pnlCreateAcc.Controls.Add(lblConfirmPassword)
        pnlCreateAcc.Location = New Point(477, 184)
        pnlCreateAcc.Name = "pnlCreateAcc"
        pnlCreateAcc.Size = New Size(966, 713)
        pnlCreateAcc.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(568, 388)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 19)
        Label1.TabIndex = 29
        Label1.Text = "Password Strength:"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Anchor = AnchorStyles.None
        txtStudentId.BackColor = Color.White
        txtStudentId.Font = New Font("Arial", 8.0F)
        txtStudentId.ForeColor = Color.Black
        txtStudentId.Location = New Point(45, 366)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(350, 20)
        txtStudentId.TabIndex = 28
        ' 
        ' lblStudentId
        ' 
        lblStudentId.Anchor = AnchorStyles.None
        lblStudentId.AutoSize = True
        lblStudentId.BackColor = Color.Transparent
        lblStudentId.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentId.ForeColor = Color.White
        lblStudentId.Location = New Point(45, 340)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(84, 19)
        lblStudentId.TabIndex = 27
        lblStudentId.Text = "Student ID*"
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.None
        txtLastName.BackColor = Color.White
        txtLastName.Font = New Font("Arial", 8.0F)
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(45, 304)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(350, 20)
        txtLastName.TabIndex = 26
        ' 
        ' lblLastName
        ' 
        lblLastName.Anchor = AnchorStyles.None
        lblLastName.AutoSize = True
        lblLastName.BackColor = Color.Transparent
        lblLastName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLastName.ForeColor = Color.White
        lblLastName.Location = New Point(45, 278)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(85, 19)
        lblLastName.TabIndex = 25
        lblLastName.Text = "Last Name*"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Anchor = AnchorStyles.None
        txtMiddleName.BackColor = Color.White
        txtMiddleName.Font = New Font("Arial", 8.0F)
        txtMiddleName.ForeColor = Color.Black
        txtMiddleName.Location = New Point(45, 242)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(350, 20)
        txtMiddleName.TabIndex = 24
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.Anchor = AnchorStyles.None
        lblMiddleName.AutoSize = True
        lblMiddleName.BackColor = Color.Transparent
        lblMiddleName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMiddleName.ForeColor = Color.White
        lblMiddleName.Location = New Point(45, 216)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(100, 19)
        lblMiddleName.TabIndex = 23
        lblMiddleName.Text = "Middle Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.None
        txtFirstName.BackColor = Color.White
        txtFirstName.Font = New Font("Arial", 8.0F)
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(45, 180)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(350, 20)
        txtFirstName.TabIndex = 22
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Anchor = AnchorStyles.None
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFirstName.ForeColor = Color.White
        lblFirstName.Location = New Point(45, 154)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(87, 19)
        lblFirstName.TabIndex = 21
        lblFirstName.Text = "First Name*"
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnBack.Location = New Point(389, 528)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(165, 50)
        btnBack.TabIndex = 20
        btnBack.Text = "BACK TO LOGIN"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnRegister.Location = New Point(407, 456)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(128, 50)
        btnRegister.TabIndex = 12
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = Color.White
        txtUsername.Font = New Font("Arial", 8.0F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(568, 180)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(350, 20)
        txtUsername.TabIndex = 19
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Anchor = AnchorStyles.None
        txtConfirm.BackColor = Color.White
        txtConfirm.Font = New Font("Arial", 8.0F)
        txtConfirm.ForeColor = Color.Black
        txtConfirm.Location = New Point(568, 304)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(350, 20)
        txtConfirm.TabIndex = 18
        txtConfirm.UseSystemPasswordChar = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Arial", 8.0F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(568, 242)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(350, 20)
        txtPassword.TabIndex = 17
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1920, 1080)
        Controls.Add(pnlCreateAcc)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(1280, 720)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registraion Form"
        WindowState = FormWindowState.Maximized
        pnlCreateAcc.ResumeLayout(False)
        pnlCreateAcc.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents pnlCreateAcc As Panel
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentId As Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnRegister As RoundedButton
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents Label1 As Label
End Class
