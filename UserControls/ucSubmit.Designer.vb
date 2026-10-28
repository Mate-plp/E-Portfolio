<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSubmit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSubmit))
        lblID = New Label()
        txtTitle = New TextBox()
        Label4 = New Label()
        txtDescription = New TextBox()
        lblCount = New Label()
        Label6 = New Label()
        dtpDate = New DateTimePicker()
        Label7 = New Label()
        cboType = New ComboBox()
        Label8 = New Label()
        clbSkills = New CheckedListBox()
        chkPLP = New CheckBox()
        btnBrowse = New RoundedButton()
        btnRemoveFile = New RoundedButton()
        btnClear = New RoundedButton()
        btnSubmit = New RoundedButton()
        cboFaculty = New ComboBox()
        lblFile = New Label()
        lblSubmitActivity = New Label()
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        RoundedPanel4 = New RoundedPanel()
        RoundedPanel3 = New RoundedPanel()
        pbFile = New PictureBox()
        btnCancel = New RoundedButton()
        RoundedPanel5 = New RoundedPanel()
        Label1 = New Label()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        CType(pbFile, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblID
        ' 
        lblID.Anchor = AnchorStyles.None
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(59, 104)
        lblID.Margin = New Padding(18, 15, 18, 15)
        lblID.Name = "lblID"
        lblID.Padding = New Padding(26, 15, 18, 0)
        lblID.Size = New Size(103, 35)
        lblID.TabIndex = 6
        lblID.Text = "Title:"
        ' 
        ' txtTitle
        ' 
        txtTitle.Anchor = AnchorStyles.None
        txtTitle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(89, 144)
        txtTitle.Margin = New Padding(3, 2, 3, 2)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(514, 29)
        txtTitle.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(2, 11)
        Label4.Margin = New Padding(18, 15, 18, 15)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(26, 15, 18, 0)
        Label4.Size = New Size(169, 35)
        Label4.TabIndex = 8
        Label4.Text = "Description:"
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.None
        txtDescription.BackColor = Color.White
        txtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.ForeColor = Color.Black
        txtDescription.Location = New Point(98, 270)
        txtDescription.Margin = New Padding(3, 2, 3, 2)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(817, 295)
        txtDescription.TabIndex = 9
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblCount.AutoSize = True
        lblCount.BackColor = Color.Transparent
        lblCount.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCount.Location = New Point(676, 356)
        lblCount.Margin = New Padding(18, 15, 18, 15)
        lblCount.Name = "lblCount"
        lblCount.Padding = New Padding(26, 15, 18, 0)
        lblCount.Size = New Size(188, 32)
        lblCount.TabIndex = 10
        lblCount.Text = "0/250 characters"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(614, 102)
        Label6.Margin = New Padding(18, 15, 18, 15)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(26, 15, 18, 0)
        Label6.Size = New Size(104, 35)
        Label6.TabIndex = 11
        Label6.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.Anchor = AnchorStyles.None
        dtpDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(644, 144)
        dtpDate.Margin = New Padding(3, 2, 3, 2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(296, 29)
        dtpDate.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(73, 75)
        Label7.Margin = New Padding(18, 15, 18, 15)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(26, 15, 18, 0)
        Label7.Size = New Size(185, 35)
        Label7.TabIndex = 13
        Label7.Text = "Activity Type:"
        ' 
        ' cboType
        ' 
        cboType.Anchor = AnchorStyles.None
        cboType.FormattingEnabled = True
        cboType.Location = New Point(273, 88)
        cboType.Margin = New Padding(3, 2, 3, 2)
        cboType.Name = "cboType"
        cboType.Size = New Size(203, 23)
        cboType.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(73, 266)
        Label8.Margin = New Padding(18, 15, 18, 15)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(26, 15, 18, 0)
        Label8.Size = New Size(217, 35)
        Label8.TabIndex = 15
        Label8.Text = "Skills Developed:"
        ' 
        ' clbSkills
        ' 
        clbSkills.Anchor = AnchorStyles.None
        clbSkills.FormattingEnabled = True
        clbSkills.Items.AddRange(New Object() {"Leadership", "Communication", "Teamwork", "Visual Basic", "C#"})
        clbSkills.Location = New Point(124, 319)
        clbSkills.Name = "clbSkills"
        clbSkills.Size = New Size(352, 148)
        clbSkills.TabIndex = 16
        ' 
        ' chkPLP
        ' 
        chkPLP.AutoSize = True
        chkPLP.BackColor = Color.Transparent
        chkPLP.Location = New Point(124, 490)
        chkPLP.Name = "chkPLP"
        chkPLP.Size = New Size(78, 19)
        chkPLP.TabIndex = 17
        chkPLP.Text = "PLP Event"
        chkPLP.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        btnBrowse.FlatAppearance.BorderColor = Color.Yellow
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(29, 286)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(134, 39)
        btnBrowse.TabIndex = 18
        btnBrowse.Text = "Add File"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveFile
        ' 
        btnRemoveFile.BackColor = Color.White
        btnRemoveFile.FlatAppearance.BorderSize = 0
        btnRemoveFile.FlatStyle = FlatStyle.Flat
        btnRemoveFile.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnRemoveFile.Location = New Point(171, 286)
        btnRemoveFile.Name = "btnRemoveFile"
        btnRemoveFile.Size = New Size(192, 39)
        btnRemoveFile.TabIndex = 19
        btnRemoveFile.Text = "Remove File"
        btnRemoveFile.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(1127, 882)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(211, 56)
        btnClear.TabIndex = 20
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(10), CByte(52), CByte(33))
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(1344, 882)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(211, 56)
        btnSubmit.TabIndex = 21
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' cboFaculty
        ' 
        cboFaculty.Anchor = AnchorStyles.None
        cboFaculty.FormattingEnabled = True
        cboFaculty.Location = New Point(208, 486)
        cboFaculty.Margin = New Padding(3, 2, 3, 2)
        cboFaculty.Name = "cboFaculty"
        cboFaculty.Size = New Size(268, 23)
        cboFaculty.TabIndex = 22
        ' 
        ' lblFile
        ' 
        lblFile.AutoSize = True
        lblFile.BackColor = Color.Transparent
        lblFile.Location = New Point(371, 298)
        lblFile.Name = "lblFile"
        lblFile.Size = New Size(94, 15)
        lblFile.TabIndex = 23
        lblFile.Text = "No File Selected."
        ' 
        ' lblSubmitActivity
        ' 
        lblSubmitActivity.AutoSize = True
        lblSubmitActivity.Font = New Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubmitActivity.ForeColor = Color.FromArgb(CByte(243), CByte(185), CByte(39))
        lblSubmitActivity.Location = New Point(738, 20)
        lblSubmitActivity.Name = "lblSubmitActivity"
        lblSubmitActivity.Size = New Size(228, 31)
        lblSubmitActivity.TabIndex = 0
        lblSubmitActivity.Text = "Submit Activity"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.Controls.Add(lblSubmitActivity)
        RoundedPanel1.FillColor = Color.FromArgb(CByte(12), CByte(69), CByte(36))
        RoundedPanel1.Location = New Point(12, 11)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1704, 70)
        RoundedPanel1.TabIndex = 25
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.Transparent
        RoundedPanel2.Controls.Add(RoundedPanel4)
        RoundedPanel2.FillColor = Color.FromArgb(CByte(180), CByte(255), CByte(255), CByte(255))
        RoundedPanel2.Location = New Point(66, 200)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(878, 395)
        RoundedPanel2.TabIndex = 26
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.Transparent
        RoundedPanel4.Controls.Add(Label4)
        RoundedPanel4.Controls.Add(lblCount)
        RoundedPanel4.FillColor = Color.FromArgb(CByte(180), CByte(255), CByte(255), CByte(255))
        RoundedPanel4.Location = New Point(3, 1)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(877, 398)
        RoundedPanel4.TabIndex = 11
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = Color.Transparent
        RoundedPanel3.Controls.Add(cboFaculty)
        RoundedPanel3.Controls.Add(Label7)
        RoundedPanel3.Controls.Add(cboType)
        RoundedPanel3.Controls.Add(chkPLP)
        RoundedPanel3.Controls.Add(Label8)
        RoundedPanel3.Controls.Add(clbSkills)
        RoundedPanel3.FillColor = Color.FromArgb(CByte(180), CByte(255), CByte(255), CByte(255))
        RoundedPanel3.Location = New Point(1008, 201)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(557, 661)
        RoundedPanel3.TabIndex = 27
        ' 
        ' pbFile
        ' 
        pbFile.Anchor = AnchorStyles.None
        pbFile.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pbFile.BackgroundImageLayout = ImageLayout.Zoom
        pbFile.Location = New Point(29, 60)
        pbFile.Name = "pbFile"
        pbFile.Size = New Size(817, 210)
        pbFile.TabIndex = 28
        pbFile.TabStop = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnCancel.Location = New Point(1127, 882)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(211, 56)
        btnCancel.TabIndex = 29
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        btnCancel.Visible = False
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.Transparent
        RoundedPanel5.Controls.Add(Label1)
        RoundedPanel5.Controls.Add(lblFile)
        RoundedPanel5.Controls.Add(pbFile)
        RoundedPanel5.Controls.Add(btnBrowse)
        RoundedPanel5.Controls.Add(btnRemoveFile)
        RoundedPanel5.FillColor = Color.FromArgb(CByte(180), CByte(255), CByte(255), CByte(255))
        RoundedPanel5.Location = New Point(70, 613)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(877, 339)
        RoundedPanel5.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12.2F, FontStyle.Bold)
        Label1.Location = New Point(29, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 20)
        Label1.TabIndex = 29
        Label1.Text = "Attach Documentation/Media" & vbCrLf
        ' 
        ' ucSubmit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(btnCancel)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel1)
        Controls.Add(btnSubmit)
        Controls.Add(btnClear)
        Controls.Add(dtpDate)
        Controls.Add(Label6)
        Controls.Add(txtDescription)
        Controls.Add(txtTitle)
        Controls.Add(lblID)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel5)
        DoubleBuffered = True
        Name = "ucSubmit"
        Size = New Size(1728, 1005)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        CType(pbFile, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblID As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents clbSkills As CheckedListBox
    Friend WithEvents chkPLP As CheckBox
    Friend WithEvents btnBrowse As RoundedButton
    Friend WithEvents btnRemoveFile As RoundedButton
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents btnSubmit As RoundedButton
    Friend WithEvents cboFaculty As ComboBox
    Friend WithEvents lblFile As Label
    Friend WithEvents lblSubmitActivity As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents pbFile As PictureBox
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label1 As Label

End Class
