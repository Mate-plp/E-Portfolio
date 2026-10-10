<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        btnLogin = New Button()
        btnRegister = New Button()
        btnExit = New Button()
        lblWelcome = New Label()
        lblSubtitle = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(354, 240)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(80, 19)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(354, 359)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(77, 19)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(354, 273)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(453, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(358, 396)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(453, 27)
        txtPassword.TabIndex = 3
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(358, 455)
        chkShowPassword.Margin = New Padding(4, 5, 4, 5)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(112, 19)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(430, 498)
        btnLogin.Margin = New Padding(4, 5, 4, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(330, 45)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Transparent
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(508, 604)
        btnRegister.Margin = New Padding(4, 5, 4, 5)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(174, 50)
        btnRegister.TabIndex = 6
        btnRegister.Text = "REGISTER HERE"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(538, 664)
        btnExit.Margin = New Padding(4, 5, 4, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(103, 36)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(326, 104)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(238, 45)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome Back"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.White
        lblSubtitle.Location = New Point(338, 167)
        lblSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(201, 25)
        lblSubtitle.TabIndex = 9
        lblSubtitle.Text = "Log In to your account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(495, 583)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 15)
        Label1.TabIndex = 10
        Label1.Text = "Dont have an account? Click Here"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1661, 920)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(lblSubtitle)
        Controls.Add(lblWelcome)
        Controls.Add(btnExit)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(chkShowPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "Login"
        Text = "LogIn"
        TopMost = True
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents Label1 As Label
End Class
