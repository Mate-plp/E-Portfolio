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
        txtStudentId = New ReaLTaiizor.Controls.CyberTextBox()
        lblStudentId = New Label()
        txtLastName = New ReaLTaiizor.Controls.CyberTextBox()
        lblLastName = New Label()
        txtMiddleName = New ReaLTaiizor.Controls.CyberTextBox()
        lblMiddleName = New Label()
        txtFirstName = New ReaLTaiizor.Controls.CyberTextBox()
        lblFirstName = New Label()
        btnBack = New ReaLTaiizor.Controls.CyberButton()
        btnRegister = New ReaLTaiizor.Controls.CyberButton()
        txtUsername = New ReaLTaiizor.Controls.CyberTextBox()
        txtConfirm = New ReaLTaiizor.Controls.CyberTextBox()
        txtPassword = New ReaLTaiizor.Controls.CyberTextBox()
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
        lblUsername.Location = New Point(568, 159)
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
        lblPassword.Location = New Point(569, 221)
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
        lblConfirmPassword.Location = New Point(570, 283)
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
        lblPasswordStrength.Location = New Point(568, 388)
        lblPasswordStrength.Name = "lblPasswordStrength"
        lblPasswordStrength.Size = New Size(138, 19)
        lblPasswordStrength.TabIndex = 8
        lblPasswordStrength.Text = "Password Strength:"
        ' 
        ' pnlCreateAcc
        ' 
        pnlCreateAcc.Anchor = AnchorStyles.None
        pnlCreateAcc.BackColor = Color.FromArgb(CByte(5), CByte(53), CByte(44))
        pnlCreateAcc.BorderStyle = BorderStyle.Fixed3D
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
        ' txtStudentId
        ' 
        txtStudentId.Alpha = 20
        txtStudentId.Anchor = AnchorStyles.None
        txtStudentId.BackColor = Color.Transparent
        txtStudentId.Background_WidthPen = 3.0F
        txtStudentId.BackgroundPen = True
        txtStudentId.ColorBackground = Color.White
        txtStudentId.ColorBackground_Pen = Color.Black
        txtStudentId.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtStudentId.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtStudentId.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtStudentId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtStudentId.Font = New Font("Arial", 5.0F)
        txtStudentId.ForeColor = Color.Black
        txtStudentId.Lighting = False
        txtStudentId.LinearGradientPen = False
        txtStudentId.Location = New Point(45, 366)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.PasswordChar = "*"c
        txtStudentId.PenWidth = 15
        txtStudentId.RGB = False
        txtStudentId.Rounding = True
        txtStudentId.RoundingInt = 60
        txtStudentId.Size = New Size(350, 23)
        txtStudentId.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtStudentId.TabIndex = 28
        txtStudentId.Tag = "Cyber"
        txtStudentId.TextAlign = HorizontalAlignment.Left
        txtStudentId.TextButton = ""
        txtStudentId.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtStudentId.Timer_RGB = 300
        ' 
        ' lblStudentId
        ' 
        lblStudentId.Anchor = AnchorStyles.None
        lblStudentId.AutoSize = True
        lblStudentId.BackColor = Color.Transparent
        lblStudentId.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentId.ForeColor = Color.White
        lblStudentId.Location = New Point(45, 345)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(78, 19)
        lblStudentId.TabIndex = 27
        lblStudentId.Text = "Student ID"
        ' 
        ' txtLastName
        ' 
        txtLastName.Alpha = 20
        txtLastName.Anchor = AnchorStyles.None
        txtLastName.BackColor = Color.Transparent
        txtLastName.Background_WidthPen = 3.0F
        txtLastName.BackgroundPen = True
        txtLastName.ColorBackground = Color.White
        txtLastName.ColorBackground_Pen = Color.Black
        txtLastName.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtLastName.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtLastName.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtLastName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtLastName.Font = New Font("Arial", 5.0F)
        txtLastName.ForeColor = Color.Black
        txtLastName.Lighting = False
        txtLastName.LinearGradientPen = False
        txtLastName.Location = New Point(45, 304)
        txtLastName.Name = "txtLastName"
        txtLastName.PasswordChar = "*"c
        txtLastName.PenWidth = 15
        txtLastName.RGB = False
        txtLastName.Rounding = True
        txtLastName.RoundingInt = 60
        txtLastName.Size = New Size(350, 23)
        txtLastName.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtLastName.TabIndex = 26
        txtLastName.Tag = "Cyber"
        txtLastName.TextAlign = HorizontalAlignment.Left
        txtLastName.TextButton = ""
        txtLastName.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtLastName.Timer_RGB = 300
        ' 
        ' lblLastName
        ' 
        lblLastName.Anchor = AnchorStyles.None
        lblLastName.AutoSize = True
        lblLastName.BackColor = Color.Transparent
        lblLastName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLastName.ForeColor = Color.White
        lblLastName.Location = New Point(45, 283)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(79, 19)
        lblLastName.TabIndex = 25
        lblLastName.Text = "Last Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Alpha = 20
        txtMiddleName.Anchor = AnchorStyles.None
        txtMiddleName.BackColor = Color.Transparent
        txtMiddleName.Background_WidthPen = 3.0F
        txtMiddleName.BackgroundPen = True
        txtMiddleName.ColorBackground = Color.White
        txtMiddleName.ColorBackground_Pen = Color.Black
        txtMiddleName.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtMiddleName.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtMiddleName.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtMiddleName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtMiddleName.Font = New Font("Arial", 5.0F)
        txtMiddleName.ForeColor = Color.Black
        txtMiddleName.Lighting = False
        txtMiddleName.LinearGradientPen = False
        txtMiddleName.Location = New Point(45, 242)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.PasswordChar = "*"c
        txtMiddleName.PenWidth = 15
        txtMiddleName.RGB = False
        txtMiddleName.Rounding = True
        txtMiddleName.RoundingInt = 60
        txtMiddleName.Size = New Size(350, 23)
        txtMiddleName.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtMiddleName.TabIndex = 24
        txtMiddleName.Tag = "Cyber"
        txtMiddleName.TextAlign = HorizontalAlignment.Left
        txtMiddleName.TextButton = ""
        txtMiddleName.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtMiddleName.Timer_RGB = 300
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.Anchor = AnchorStyles.None
        lblMiddleName.AutoSize = True
        lblMiddleName.BackColor = Color.Transparent
        lblMiddleName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMiddleName.ForeColor = Color.White
        lblMiddleName.Location = New Point(45, 221)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(172, 19)
        lblMiddleName.TabIndex = 23
        lblMiddleName.Text = "Middle Name (Optional)"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Alpha = 20
        txtFirstName.Anchor = AnchorStyles.None
        txtFirstName.BackColor = Color.Transparent
        txtFirstName.Background_WidthPen = 3.0F
        txtFirstName.BackgroundPen = True
        txtFirstName.ColorBackground = Color.White
        txtFirstName.ColorBackground_Pen = Color.Black
        txtFirstName.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtFirstName.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtFirstName.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtFirstName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtFirstName.Font = New Font("Arial", 5.0F)
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Lighting = False
        txtFirstName.LinearGradientPen = False
        txtFirstName.Location = New Point(45, 180)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PasswordChar = "*"c
        txtFirstName.PenWidth = 15
        txtFirstName.RGB = False
        txtFirstName.Rounding = True
        txtFirstName.RoundingInt = 60
        txtFirstName.Size = New Size(350, 23)
        txtFirstName.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtFirstName.TabIndex = 22
        txtFirstName.Tag = "Cyber"
        txtFirstName.TextAlign = HorizontalAlignment.Left
        txtFirstName.TextButton = ""
        txtFirstName.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtFirstName.Timer_RGB = 300
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Anchor = AnchorStyles.None
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFirstName.ForeColor = Color.White
        lblFirstName.Location = New Point(45, 159)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(81, 19)
        lblFirstName.TabIndex = 21
        lblFirstName.Text = "First Name"
        ' 
        ' btnBack
        ' 
        btnBack.Alpha = 20
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackColor = Color.Transparent
        btnBack.Background = True
        btnBack.Background_WidthPen = 4.0F
        btnBack.BackgroundPen = True
        btnBack.ColorBackground = Color.Transparent
        btnBack.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnBack.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnBack.ColorBackground_Pen = Color.Transparent
        btnBack.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnBack.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnBack.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnBack.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnBack.Effect_1 = True
        btnBack.Effect_1_ColorBackground = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        btnBack.Effect_1_Transparency = 25
        btnBack.Effect_2 = True
        btnBack.Effect_2_ColorBackground = Color.White
        btnBack.Effect_2_Transparency = 20
        btnBack.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnBack.Lighting = False
        btnBack.LinearGradient_Background = False
        btnBack.LinearGradientPen = False
        btnBack.Location = New Point(389, 528)
        btnBack.Name = "btnBack"
        btnBack.PenWidth = 15
        btnBack.Rounding = True
        btnBack.RoundingInt = 70
        btnBack.Size = New Size(165, 50)
        btnBack.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnBack.TabIndex = 20
        btnBack.Tag = "Cyber"
        btnBack.TextButton = "BACK TO LOGIN"
        btnBack.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnBack.Timer_Effect_1 = 5
        btnBack.Timer_RGB = 300
        ' 
        ' btnRegister
        ' 
        btnRegister.Alpha = 20
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.Background = True
        btnRegister.Background_WidthPen = 4.0F
        btnRegister.BackgroundPen = True
        btnRegister.ColorBackground = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.ColorBackground_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnRegister.ColorBackground_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnRegister.ColorBackground_Pen = Color.Transparent
        btnRegister.ColorLighting = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.ColorPen_1 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        btnRegister.ColorPen_2 = Color.FromArgb(CByte(41), CByte(63), CByte(86))
        btnRegister.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        btnRegister.Effect_1 = True
        btnRegister.Effect_1_ColorBackground = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        btnRegister.Effect_1_Transparency = 25
        btnRegister.Effect_2 = True
        btnRegister.Effect_2_ColorBackground = Color.White
        btnRegister.Effect_2_Transparency = 20
        btnRegister.Font = New Font("Arial", 11.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnRegister.Lighting = False
        btnRegister.LinearGradient_Background = False
        btnRegister.LinearGradientPen = False
        btnRegister.Location = New Point(407, 456)
        btnRegister.Name = "btnRegister"
        btnRegister.PenWidth = 15
        btnRegister.Rounding = True
        btnRegister.RoundingInt = 70
        btnRegister.Size = New Size(128, 50)
        btnRegister.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        btnRegister.TabIndex = 12
        btnRegister.Tag = "Cyber"
        btnRegister.TextButton = "REGISTER"
        btnRegister.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnRegister.Timer_Effect_1 = 5
        btnRegister.Timer_RGB = 300
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
        txtUsername.Font = New Font("Arial", 5.0F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Lighting = False
        txtUsername.LinearGradientPen = False
        txtUsername.Location = New Point(568, 180)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = "*"c
        txtUsername.PenWidth = 15
        txtUsername.RGB = False
        txtUsername.Rounding = True
        txtUsername.RoundingInt = 60
        txtUsername.Size = New Size(350, 23)
        txtUsername.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtUsername.TabIndex = 19
        txtUsername.Tag = "Cyber"
        txtUsername.TextAlign = HorizontalAlignment.Left
        txtUsername.TextButton = ""
        txtUsername.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtUsername.Timer_RGB = 300
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Alpha = 20
        txtConfirm.Anchor = AnchorStyles.None
        txtConfirm.BackColor = Color.Transparent
        txtConfirm.Background_WidthPen = 3.0F
        txtConfirm.BackgroundPen = True
        txtConfirm.ColorBackground = Color.White
        txtConfirm.ColorBackground_Pen = Color.Black
        txtConfirm.ColorLighting = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtConfirm.ColorPen_1 = Color.FromArgb(CByte(29), CByte(200), CByte(238))
        txtConfirm.ColorPen_2 = Color.FromArgb(CByte(37), CByte(52), CByte(68))
        txtConfirm.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        txtConfirm.Font = New Font("Arial", 5.0F)
        txtConfirm.ForeColor = Color.Black
        txtConfirm.Lighting = False
        txtConfirm.LinearGradientPen = False
        txtConfirm.Location = New Point(568, 304)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Password = True
        txtConfirm.PasswordChar = "*"c
        txtConfirm.PenWidth = 15
        txtConfirm.RGB = False
        txtConfirm.Rounding = True
        txtConfirm.RoundingInt = 60
        txtConfirm.Size = New Size(350, 23)
        txtConfirm.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtConfirm.TabIndex = 18
        txtConfirm.Tag = "Cyber"
        txtConfirm.TextAlign = HorizontalAlignment.Left
        txtConfirm.TextButton = ""
        txtConfirm.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtConfirm.Timer_RGB = 300
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
        txtPassword.Font = New Font("Arial", 5.0F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Lighting = False
        txtPassword.LinearGradientPen = False
        txtPassword.Location = New Point(568, 242)
        txtPassword.Name = "txtPassword"
        txtPassword.Password = True
        txtPassword.PasswordChar = "*"c
        txtPassword.PenWidth = 15
        txtPassword.RGB = False
        txtPassword.Rounding = True
        txtPassword.RoundingInt = 60
        txtPassword.Size = New Size(350, 23)
        txtPassword.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        txtPassword.TabIndex = 17
        txtPassword.Tag = "Cyber"
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TextButton = ""
        txtPassword.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        txtPassword.Timer_RGB = 300
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
    Friend WithEvents txtConfirm As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents txtPassword As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents txtUsername As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents btnRegister As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents btnBack As ReaLTaiizor.Controls.CyberButton
    Friend WithEvents txtStudentId As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents lblStudentId As Label
    Friend WithEvents txtLastName As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtMiddleName As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtFirstName As ReaLTaiizor.Controls.CyberTextBox
    Friend WithEvents lblFirstName As Label
End Class
