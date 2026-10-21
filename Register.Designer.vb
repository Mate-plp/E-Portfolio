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
        txtUsername = New TextBox()
        txtConfirm = New TextBox()
        txtPassword = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(734, 268)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(495, 54)
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
        lblUsername.Location = New Point(1034, 373)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(89, 23)
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
        lblPassword.Location = New Point(1034, 444)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(85, 23)
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
        lblConfirmPassword.Location = New Point(1034, 516)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(156, 23)
        lblConfirmPassword.TabIndex = 3
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.Anchor = AnchorStyles.None
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        chkShowPassword.Location = New Point(1032, 592)
        chkShowPassword.Margin = New Padding(3, 4, 3, 4)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
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
        lblPasswordStrength.Location = New Point(1204, 619)
        lblPasswordStrength.Name = "lblPasswordStrength"
        lblPasswordStrength.Size = New Size(25, 23)
        lblPasswordStrength.TabIndex = 8
        lblPasswordStrength.Text = "..."
        ' 
        ' pnlCreateAcc
        ' 
        pnlCreateAcc.Anchor = AnchorStyles.None
        pnlCreateAcc.BackColor = Color.FromArgb(CByte(5), CByte(53), CByte(44))
        pnlCreateAcc.BorderStyle = BorderStyle.Fixed3D
        pnlCreateAcc.Location = New Point(322, 359)
        pnlCreateAcc.Margin = New Padding(3, 4, 3, 4)
        pnlCreateAcc.Name = "pnlCreateAcc"
        pnlCreateAcc.Size = New Size(73, 368)
        pnlCreateAcc.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        Label1.Location = New Point(1032, 621)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 23)
        Label1.TabIndex = 29
        Label1.Text = "Password Strength:"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Anchor = AnchorStyles.None
        txtStudentId.BackColor = Color.White
        txtStudentId.Font = New Font("Arial", 8F)
        txtStudentId.ForeColor = Color.Black
        txtStudentId.Location = New Point(507, 644)
        txtStudentId.Margin = New Padding(3, 4, 3, 4)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(399, 23)
        txtStudentId.TabIndex = 28
        ' 
        ' lblStudentId
        ' 
        lblStudentId.Anchor = AnchorStyles.None
        lblStudentId.AutoSize = True
        lblStudentId.BackColor = Color.Transparent
        lblStudentId.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentId.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblStudentId.Location = New Point(507, 609)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(105, 23)
        lblStudentId.TabIndex = 27
        lblStudentId.Text = "Student ID*"
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.None
        txtLastName.BackColor = Color.White
        txtLastName.Font = New Font("Arial", 8F)
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(507, 565)
        txtLastName.Margin = New Padding(3, 4, 3, 4)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(399, 23)
        txtLastName.TabIndex = 26
        ' 
        ' lblLastName
        ' 
        lblLastName.Anchor = AnchorStyles.None
        lblLastName.AutoSize = True
        lblLastName.BackColor = Color.Transparent
        lblLastName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLastName.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblLastName.Location = New Point(507, 531)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(102, 23)
        lblLastName.TabIndex = 25
        lblLastName.Text = "Last Name*"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Anchor = AnchorStyles.None
        txtMiddleName.BackColor = Color.White
        txtMiddleName.Font = New Font("Arial", 8F)
        txtMiddleName.ForeColor = Color.Black
        txtMiddleName.Location = New Point(507, 487)
        txtMiddleName.Margin = New Padding(3, 4, 3, 4)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(399, 23)
        txtMiddleName.TabIndex = 24
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.Anchor = AnchorStyles.None
        lblMiddleName.AutoSize = True
        lblMiddleName.BackColor = Color.Transparent
        lblMiddleName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMiddleName.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblMiddleName.Location = New Point(507, 452)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(119, 23)
        lblMiddleName.TabIndex = 23
        lblMiddleName.Text = "Middle Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.None
        txtFirstName.BackColor = Color.White
        txtFirstName.Font = New Font("Arial", 8F)
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(507, 408)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(399, 23)
        txtFirstName.TabIndex = 22
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Anchor = AnchorStyles.None
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFirstName.ForeColor = Color.FromArgb(CByte(28), CByte(43), CByte(34))
        lblFirstName.Location = New Point(507, 373)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(105, 23)
        lblFirstName.TabIndex = 21
        lblFirstName.Text = "First Name*"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = Color.White
        txtUsername.Font = New Font("Arial", 8F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(1034, 408)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(399, 23)
        txtUsername.TabIndex = 19
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Anchor = AnchorStyles.None
        txtConfirm.BackColor = Color.White
        txtConfirm.Font = New Font("Arial", 8F)
        txtConfirm.ForeColor = Color.Black
        txtConfirm.Location = New Point(1032, 550)
        txtConfirm.Margin = New Padding(3, 4, 3, 4)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(399, 23)
        txtConfirm.TabIndex = 18
        txtConfirm.UseSystemPasswordChar = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Arial", 8F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(1033, 479)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(399, 23)
        txtPassword.TabIndex = 17
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Location = New Point(946, 759)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 50)
        Button1.TabIndex = 30
        Button1.Text = "BACK TO LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1130, 759)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 50)
        Button2.TabIndex = 31
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1256, 759)
        Button3.Name = "Button3"
        Button3.Size = New Size(229, 50)
        Button3.TabIndex = 32
        Button3.Text = "SUBMIT AND REGISTER"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(507, 774)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 20)
        Label2.TabIndex = 33
        Label2.Text = "Already have an account?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(90), CByte(104), CByte(96))
        Label3.Location = New Point(713, 322)
        Label3.Name = "Label3"
        Label3.Size = New Size(534, 60)
        Label3.TabIndex = 34
        Label3.Text = " Fill out the required information to register for your STAR portal student access" & vbCrLf & vbCrLf & " " & vbCrLf
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1942, 1102)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(pnlCreateAcc)
        Controls.Add(txtUsername)
        Controls.Add(txtStudentId)
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
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximumSize = New Size(2194, 1440)
        MinimumSize = New Size(1463, 960)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
