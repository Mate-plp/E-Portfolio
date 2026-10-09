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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        chkShowPassword = New CheckBox()
        lblPasswordStrength = New Label()
        btnRegister = New Button()
        btnBack = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(101, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(297, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CREATE ACCOUNT"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(76, 111)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(76, 19)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(77, 180)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(73, 19)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.BackColor = Color.Transparent
        lblConfirmPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmPassword.ForeColor = Color.White
        lblConfirmPassword.Location = New Point(78, 245)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(131, 19)
        lblConfirmPassword.TabIndex = 3
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(80, 136)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(350, 20)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(81, 202)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(348, 20)
        txtPassword.TabIndex = 5
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.White
        txtConfirmPassword.BorderStyle = BorderStyle.None
        txtConfirmPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.ForeColor = Color.Black
        txtConfirmPassword.Location = New Point(81, 268)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(348, 20)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(84, 302)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 7
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblPasswordStrength
        ' 
        lblPasswordStrength.AutoSize = True
        lblPasswordStrength.BackColor = Color.Transparent
        lblPasswordStrength.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPasswordStrength.ForeColor = Color.White
        lblPasswordStrength.Location = New Point(80, 372)
        lblPasswordStrength.Name = "lblPasswordStrength"
        lblPasswordStrength.Size = New Size(138, 19)
        lblPasswordStrength.TabIndex = 8
        lblPasswordStrength.Text = "Password Strength:"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(176, 421)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(128, 52)
        btnRegister.TabIndex = 9
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(160, 507)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(164, 34)
        btnBack.TabIndex = 10
        btnBack.Text = "BACK TO LOGIN"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(5), CByte(53), CByte(44))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(lblUsername)
        Panel1.Controls.Add(lblPasswordStrength)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(chkShowPassword)
        Panel1.Controls.Add(lblPassword)
        Panel1.Controls.Add(txtConfirmPassword)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(lblConfirmPassword)
        Panel1.Location = New Point(598, 175)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 656)
        Panel1.TabIndex = 11
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1586, 989)
        Controls.Add(Panel1)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registraion Form"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
End Class
