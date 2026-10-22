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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblID = New Label()
        txtTitle = New TextBox()
        Label4 = New Label()
        txtDescription = New TextBox()
        lblCharLimit = New Label()
        Label6 = New Label()
        dtpDate = New DateTimePicker()
        Label7 = New Label()
        cboType = New ComboBox()
        Label8 = New Label()
        CheckedListBox1 = New CheckedListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Right
        Label1.Location = New Point(1673, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 1
        Label1.Text = "SUBMIT1"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 2
        Label2.Text = "SUBMIT2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Location = New Point(0, 990)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 3
        Label3.Text = "SUBMIT3"
        ' 
        ' lblID
        ' 
        lblID.Anchor = AnchorStyles.None
        lblID.AutoSize = True
        lblID.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(0, 0)
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
        txtTitle.Location = New Point(105, 8)
        txtTitle.Margin = New Padding(3, 2, 3, 2)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(485, 29)
        txtTitle.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 74)
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
        txtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(26, 117)
        txtDescription.Margin = New Padding(3, 2, 3, 2)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(564, 219)
        txtDescription.TabIndex = 9
        ' 
        ' lblCharLimit
        ' 
        lblCharLimit.Anchor = AnchorStyles.None
        lblCharLimit.AutoSize = True
        lblCharLimit.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCharLimit.Location = New Point(394, 86)
        lblCharLimit.Margin = New Padding(18, 15, 18, 15)
        lblCharLimit.Name = "lblCharLimit"
        lblCharLimit.Padding = New Padding(26, 15, 18, 0)
        lblCharLimit.Size = New Size(188, 32)
        lblCharLimit.TabIndex = 10
        lblCharLimit.Text = "0/250 characters"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(595, 0)
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
        dtpDate.Location = New Point(690, 8)
        dtpDate.Margin = New Padding(3, 2, 3, 2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(296, 29)
        dtpDate.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(595, 82)
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
        cboType.Location = New Point(794, 95)
        cboType.Margin = New Padding(3, 2, 3, 2)
        cboType.Name = "cboType"
        cboType.Size = New Size(153, 23)
        cboType.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(595, 146)
        Label8.Margin = New Padding(18, 15, 18, 15)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(26, 15, 18, 0)
        Label8.Size = New Size(217, 35)
        Label8.TabIndex = 15
        Label8.Text = "Skills Developed:"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.Anchor = AnchorStyles.None
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(628, 199)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(319, 202)
        CheckedListBox1.TabIndex = 16
        ' 
        ' ucSubmit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(CheckedListBox1)
        Controls.Add(Label8)
        Controls.Add(cboType)
        Controls.Add(Label7)
        Controls.Add(dtpDate)
        Controls.Add(Label6)
        Controls.Add(lblCharLimit)
        Controls.Add(txtDescription)
        Controls.Add(Label4)
        Controls.Add(txtTitle)
        Controls.Add(lblID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ucSubmit"
        Size = New Size(1728, 1005)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblCharLimit As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox

End Class
