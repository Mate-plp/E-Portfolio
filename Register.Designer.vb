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
        Label1 = New Label()
        txtProfessorId = New TextBox()
        lblStudentId = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtMiddleName = New TextBox()
        lblMiddleName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtUsername = New TextBox()
        txtConfirm = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnRegister = New RoundedButton()
        btnBack = New RoundedButton()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(753, 329)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(399, 43)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CREATE ACCOUNT"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblUsername.Location = New Point(1016, 408)
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
        lblPassword.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblPassword.Location = New Point(1016, 461)
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
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblConfirmPassword.Location = New Point(1016, 515)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(131, 19)
        lblConfirmPassword.TabIndex = 3
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.Anchor = AnchorStyles.None
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        chkShowPassword.Location = New Point(1014, 572)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 7
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' lblPasswordStrength
        ' 
        lblPasswordStrength.Anchor = AnchorStyles.None
        lblPasswordStrength.AutoSize = True
        lblPasswordStrength.BackColor = Color.Transparent
        lblPasswordStrength.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPasswordStrength.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblPasswordStrength.Location = New Point(1165, 592)
        lblPasswordStrength.Name = "lblPasswordStrength"
        lblPasswordStrength.Size = New Size(21, 19)
        lblPasswordStrength.TabIndex = 8
        lblPasswordStrength.Text = "..."
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        Label1.Location = New Point(1014, 594)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 19)
        Label1.TabIndex = 29
        Label1.Text = "Password Strength:"
        ' 
        ' txtProfessorId
        ' 
        txtProfessorId.Anchor = AnchorStyles.None
        txtProfessorId.BackColor = Color.White
        txtProfessorId.Font = New Font("Arial", 8F)
        txtProfessorId.ForeColor = Color.Black
        txtProfessorId.Location = New Point(555, 611)
        txtProfessorId.Name = "txtProfessorId"
        txtProfessorId.Size = New Size(350, 20)
        txtProfessorId.TabIndex = 28
        ' 
        ' lblStudentId
        ' 
        lblStudentId.Anchor = AnchorStyles.None
        lblStudentId.AutoSize = True
        lblStudentId.BackColor = Color.Transparent
        lblStudentId.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentId.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblStudentId.Location = New Point(555, 585)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(80, 19)
        lblStudentId.TabIndex = 27
        lblStudentId.Text = "Faculty ID*"
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.None
        txtLastName.BackColor = Color.White
        txtLastName.Font = New Font("Arial", 8F)
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(555, 552)
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
        lblLastName.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblLastName.Location = New Point(555, 526)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(85, 19)
        lblLastName.TabIndex = 25
        lblLastName.Text = "Last Name*"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Anchor = AnchorStyles.None
        txtMiddleName.BackColor = Color.White
        txtMiddleName.Font = New Font("Arial", 8F)
        txtMiddleName.ForeColor = Color.Black
        txtMiddleName.Location = New Point(555, 493)
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
        lblMiddleName.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblMiddleName.Location = New Point(555, 467)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(100, 19)
        lblMiddleName.TabIndex = 23
        lblMiddleName.Text = "Middle Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.None
        txtFirstName.BackColor = Color.White
        txtFirstName.Font = New Font("Arial", 8F)
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(555, 434)
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
        lblFirstName.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblFirstName.Location = New Point(555, 408)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(87, 19)
        lblFirstName.TabIndex = 21
        lblFirstName.Text = "First Name*"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = Color.White
        txtUsername.Font = New Font("Arial", 8F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(1016, 434)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(350, 20)
        txtUsername.TabIndex = 19
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Anchor = AnchorStyles.None
        txtConfirm.BackColor = Color.White
        txtConfirm.Font = New Font("Arial", 8F)
        txtConfirm.ForeColor = Color.Black
        txtConfirm.Location = New Point(1014, 540)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(350, 20)
        txtConfirm.TabIndex = 18
        txtConfirm.UseSystemPasswordChar = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Arial", 8F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(1015, 487)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(350, 20)
        txtPassword.TabIndex = 17
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(555, 734)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 15)
        Label2.TabIndex = 33
        Label2.Text = "Already have an account?"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(90), CByte(104), CByte(96))
        Label3.Location = New Point(753, 372)
        Label3.Name = "Label3"
        Label3.Size = New Size(420, 45)
        Label3.TabIndex = 34
        Label3.Text = " Fill out the required information to register for your STAR portal faculty access" & vbCrLf & vbCrLf & " " & vbCrLf
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(1207, 751)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(200, 38)
        btnRegister.TabIndex = 35
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackColor = Color.White
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBack.ForeColor = Color.Black
        btnBack.Location = New Point(555, 751)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(156, 38)
        btnBack.TabIndex = 36
        btnBack.Text = "BACK TO LOGIN"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(793, 588)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 15)
        Label4.TabIndex = 37
        Label4.Text = "(Example: 12-34567)"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1920, 1080)
        Controls.Add(Label4)
        Controls.Add(btnBack)
        Controls.Add(btnRegister)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Controls.Add(txtProfessorId)
        Controls.Add(txtConfirm)
        Controls.Add(lblTitle)
        Controls.Add(txtPassword)
        Controls.Add(lblStudentId)
        Controls.Add(lblUsername)
        Controls.Add(lblPasswordStrength)
        Controls.Add(lblFirstName)
        Controls.Add(chkShowPassword)
        Controls.Add(txtLastName)
        Controls.Add(lblPassword)
        Controls.Add(txtFirstName)
        Controls.Add(lblConfirmPassword)
        Controls.Add(lblLastName)
        Controls.Add(lblMiddleName)
        Controls.Add(txtMiddleName)
        Controls.Add(Label3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(1280, 720)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registraion Form"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtProfessorId As System.Windows.Forms.TextBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
