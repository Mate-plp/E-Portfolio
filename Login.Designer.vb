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
        btnLogin = New ReaLTaiizor.Controls.CyberButton()
        btnRegister = New ReaLTaiizor.Controls.CyberButton()
        btnExit = New ReaLTaiizor.Controls.CyberButton()
        txtPassword = New ReaLTaiizor.Controls.CyberTextBox()
        txtUsername = New ReaLTaiizor.Controls.CyberTextBox()
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
        lblUsername.Location = New Point(732, 509)
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
        lblPassword.Location = New Point(736, 632)
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
        chkShowPassword.Location = New Point(736, 702)
        chkShowPassword.Margin = New Padding(4, 5, 4, 5)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(112, 19)
        chkShowPassword.TabIndex = 4
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
        lblWelcome.Location = New Point(646, 420)
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
        lblSubtitle.Location = New Point(683, 465)
        lblSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(201, 25)
        lblSubtitle.TabIndex = 9
        lblSubtitle.Text = "Log In to your account"
        ' 
        ' btnLogin
        ' 
        btnLogin.Alpha = 20
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLogin.Background = True
        btnLogin.Background_WidthPen = 4.0F
        btnLogin.BackgroundPen = True
        btnLogin.ColorBackground = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLogin.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnLogin.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnLogin.ColorBackground_Pen = Color.Transparent
        btnLogin.ColorLighting = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLogin.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnLogin.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnLogin.Effect_1 = True
        btnLogin.Effect_1_ColorBackground = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnLogin.Effect_1_Transparency = 25
        btnLogin.Effect_2 = True
        btnLogin.Effect_2_ColorBackground = Color.White
        btnLogin.Effect_2_Transparency = 20
        btnLogin.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnLogin.Lighting = False
        btnLogin.LinearGradient_Background = False
        btnLogin.LinearGradientPen = False
        btnLogin.Location = New Point(795, 743)
        btnLogin.Name = "btnLogin"
        btnLogin.PenWidth = 15
        btnLogin.Rounding = True
        btnLogin.RoundingInt = 70
        btnLogin.Size = New Size(330, 50)
        btnLogin.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnLogin.TabIndex = 11
        btnLogin.Tag = "Cyber"
        btnLogin.TextButton = "LOG IN"
        btnLogin.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnLogin.Timer_Effect_1 = 5
        btnLogin.Timer_RGB = 300
        ' 
        ' btnRegister
        ' 
        btnRegister.Alpha = 20
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.Transparent
        btnRegister.Background = True
        btnRegister.Background_WidthPen = 4.0F
        btnRegister.BackgroundPen = True
        btnRegister.ColorBackground = Color.Transparent
        btnRegister.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnRegister.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnRegister.ColorBackground_Pen = Color.Transparent
        btnRegister.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnRegister.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnRegister.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnRegister.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnRegister.Effect_1 = True
        btnRegister.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnRegister.Effect_1_Transparency = 25
        btnRegister.Effect_2 = True
        btnRegister.Effect_2_ColorBackground = Color.White
        btnRegister.Effect_2_Transparency = 20
        btnRegister.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnRegister.Lighting = False
        btnRegister.LinearGradient_Background = False
        btnRegister.LinearGradientPen = False
        btnRegister.Location = New Point(887, 867)
        btnRegister.Name = "btnRegister"
        btnRegister.PenWidth = 15
        btnRegister.Rounding = True
        btnRegister.RoundingInt = 70
        btnRegister.Size = New Size(147, 50)
        btnRegister.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnRegister.TabIndex = 12
        btnRegister.Tag = "Cyber"
        btnRegister.TextButton = "REGISTER HERE"
        btnRegister.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnRegister.Timer_Effect_1 = 5
        btnRegister.Timer_RGB = 300
        ' 
        ' btnExit
        ' 
        btnExit.Alpha = 20
        btnExit.Anchor = AnchorStyles.None
        btnExit.BackColor = Color.Transparent
        btnExit.Background = True
        btnExit.Background_WidthPen = 4.0F
        btnExit.BackgroundPen = True
        btnExit.ColorBackground = Color.Transparent
        btnExit.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnExit.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnExit.ColorBackground_Pen = Color.Transparent
        btnExit.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnExit.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnExit.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnExit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnExit.Effect_1 = True
        btnExit.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnExit.Effect_1_Transparency = 25
        btnExit.Effect_2 = True
        btnExit.Effect_2_ColorBackground = Color.White
        btnExit.Effect_2_Transparency = 20
        btnExit.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnExit.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnExit.Lighting = False
        btnExit.LinearGradient_Background = False
        btnExit.LinearGradientPen = False
        btnExit.Location = New Point(887, 923)
        btnExit.Name = "btnExit"
        btnExit.PenWidth = 15
        btnExit.Rounding = True
        btnExit.RoundingInt = 70
        btnExit.Size = New Size(147, 50)
        btnExit.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnExit.TabIndex = 13
        btnExit.Tag = "Cyber"
        btnExit.TextButton = "Exit"
        btnExit.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnExit.Timer_Effect_1 = 5
        btnExit.Timer_RGB = 300
        ' 
        ' txtPassword
        ' 
        txtPassword.Alpha = 20
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.Transparent
        txtPassword.Background_WidthPen = 3.0F
        txtPassword.BackgroundPen = True
        txtPassword.ColorBackground = Color.White
        txtPassword.ColorBackground_Pen = Color.Black
        txtPassword.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtPassword.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtPassword.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtPassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtPassword.Font = New Font("Arial", 10.0F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Lighting = False
        txtPassword.LinearGradientPen = False
        txtPassword.Location = New Point(732, 654)
        txtPassword.Name = "txtPassword"
        txtPassword.Password = True
        txtPassword.PasswordChar = "*"c
        txtPassword.PenWidth = 15
        txtPassword.RGB = False
        txtPassword.Rounding = True
        txtPassword.RoundingInt = 60
        txtPassword.Size = New Size(453, 40)
        txtPassword.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtPassword.TabIndex = 14
        txtPassword.Tag = "Cyber"
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TextButton = ""
        txtPassword.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtPassword.Timer_RGB = 300
        ' 
        ' txtUsername
        ' 
        txtUsername.Alpha = 20
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = Color.Transparent
        txtUsername.Background_WidthPen = 3.0F
        txtUsername.BackgroundPen = True
        txtUsername.ColorBackground = Color.White
        txtUsername.ColorBackground_Pen = Color.Black
        txtUsername.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtUsername.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtUsername.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtUsername.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtUsername.Font = New Font("Arial", 10.0F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Lighting = False
        txtUsername.LinearGradientPen = False
        txtUsername.Location = New Point(732, 531)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = "*"c
        txtUsername.PenWidth = 15
        txtUsername.RGB = False
        txtUsername.Rounding = True
        txtUsername.RoundingInt = 60
        txtUsername.Size = New Size(453, 40)
        txtUsername.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtUsername.TabIndex = 15
        txtUsername.Tag = "Cyber"
        txtUsername.TextAlign = HorizontalAlignment.Left
        txtUsername.TextButton = ""
        txtUsername.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtUsername.Timer_RGB = 300
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(884, 839)
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
        ClientSize = New Size(1920, 1080)
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
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents btnLogin As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnRegister As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnExit As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents txtPassword As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents txtUsername As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents Label1 As Label
End Class
