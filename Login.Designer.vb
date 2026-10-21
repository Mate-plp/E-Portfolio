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
        chkShowPassword = New CheckBox()
        lblWelcome = New Label()
        lblSubtitle = New Label()
        btnLogin = New RoundedButton()
        btnRegister = New RoundedButton()
        btnExit = New RoundedButton()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(733, 447)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(80, 19)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.None
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(737, 570)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(77, 19)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.Anchor = AnchorStyles.None
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(737, 640)
        chkShowPassword.Margin = New Padding(4, 5, 4, 5)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(112, 19)
        chkShowPassword.TabIndex = 3
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Anchor = AnchorStyles.None
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(647, 363)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(238, 45)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome Back"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.Anchor = AnchorStyles.None
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.White
        lblSubtitle.Location = New Point(684, 408)
        lblSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(201, 25)
        lblSubtitle.TabIndex = 9
        lblSubtitle.Text = "Log In to your account"
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(791, 686)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(338, 50)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(888, 810)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(147, 50)
        btnRegister.TabIndex = 5
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.None
        btnExit.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnExit.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnExit.Location = New Point(888, 866)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(147, 50)
        btnExit.TabIndex = 6
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Arial", 10.0F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(733, 597)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(453, 23)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = Color.White
        txtUsername.Font = New Font("Arial", 10.0F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(733, 474)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(453, 23)
        txtUsername.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(885, 782)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 19)
        Label1.TabIndex = 16
        Label1.Text = "Don't have an account?"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1920, 1061)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(btnExit)
        Controls.Add(btnRegister)
        Controls.Add(lblSubtitle)
        Controls.Add(lblWelcome)
        Controls.Add(chkShowPassword)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MaximumSize = New Size(1920, 1080)
        MinimizeBox = False
        MinimumSize = New Size(1080, 720)
        Name = "Login"
        StartPosition = FormStartPosition.CenterParent
        Text = "LogIn"
        TopMost = True
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As RoundedButton
    Friend WithEvents btnRegister As RoundedButton
    Friend WithEvents btnExit As RoundedButton
End Class
