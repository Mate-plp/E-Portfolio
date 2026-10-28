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
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnLogin = New RoundedButton()
        btnRegister = New RoundedButton()
        btnExit = New RoundedButton()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(731, 458)
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
        lblPassword.ForeColor = Color.Black
        lblPassword.Location = New Point(735, 547)
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
        chkShowPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.ForeColor = Color.Black
        chkShowPassword.Location = New Point(735, 612)
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
        lblWelcome.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = SystemColors.Desktop
        lblWelcome.Location = New Point(855, 356)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(211, 41)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome Back"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.Anchor = AnchorStyles.None
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.Black
        lblSubtitle.Location = New Point(860, 415)
        lblSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(201, 25)
        lblSubtitle.TabIndex = 9
        lblSubtitle.Text = "Log In to your account"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Arial", 10F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(731, 574)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(453, 23)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = Color.White
        txtUsername.Font = New Font("Arial", 10F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(731, 485)
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
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(887, 764)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 19)
        Label1.TabIndex = 16
        Label1.Text = "Don't have an account?"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(714, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(492, 56)
        Label2.TabIndex = 20
        Label2.Text = "FACULTY PORTAL"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(758, 306)
        Label3.Name = "Label3"
        Label3.Size = New Size(404, 21)
        Label3.TabIndex = 21
        Label3.Text = "Student Tracker of Achievements and Records System"
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(731, 645)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(453, 65)
        btnLogin.TabIndex = 22
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(731, 799)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(207, 61)
        btnRegister.TabIndex = 23
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.None
        btnExit.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(977, 799)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(207, 61)
        btnExit.TabIndex = 24
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Georgia", 20F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        Label4.Location = New Point(767, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(386, 31)
        Label4.TabIndex = 25
        Label4.Text = "STARS FOR CCS FACULTY"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(880, 883)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 19)
        Label5.TabIndex = 26
        Label5.Text = "For faculty and staff only"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1920, 1061)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnExit)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
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
        Text = "F"
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
    Friend WithEvents btnRegister As RoundedButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As RoundedButton
    Friend WithEvents btnExit As RoundedButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
