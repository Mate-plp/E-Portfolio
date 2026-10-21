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
        tbTitle = New TextBox()
        Label4 = New Label()
        tbDescription = New TextBox()
        lblCharLimit = New Label()
        Label6 = New Label()
        dtDate = New DateTimePicker()
        Label7 = New Label()
        cbActivity = New ComboBox()
        Label8 = New Label()
        cbSkills = New ComboBox()
        dgSkills = New DataGridView()
        CType(dgSkills, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
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
        ' tbTitle
        ' 
        tbTitle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbTitle.Location = New Point(105, 8)
        tbTitle.Margin = New Padding(3, 2, 3, 2)
        tbTitle.Name = "tbTitle"
        tbTitle.Size = New Size(485, 29)
        tbTitle.TabIndex = 7
        ' 
        ' Label4
        ' 
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
        ' tbDescription
        ' 
        tbDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbDescription.Location = New Point(26, 117)
        tbDescription.Margin = New Padding(3, 2, 3, 2)
        tbDescription.Multiline = True
        tbDescription.Name = "tbDescription"
        tbDescription.Size = New Size(564, 219)
        tbDescription.TabIndex = 9
        ' 
        ' lblCharLimit
        ' 
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
        ' dtDate
        ' 
        dtDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtDate.Location = New Point(690, 8)
        dtDate.Margin = New Padding(3, 2, 3, 2)
        dtDate.Name = "dtDate"
        dtDate.Size = New Size(296, 29)
        dtDate.TabIndex = 12
        ' 
        ' Label7
        ' 
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
        ' cbActivity
        ' 
        cbActivity.FormattingEnabled = True
        cbActivity.Location = New Point(794, 95)
        cbActivity.Margin = New Padding(3, 2, 3, 2)
        cbActivity.Name = "cbActivity"
        cbActivity.Size = New Size(153, 23)
        cbActivity.TabIndex = 14
        ' 
        ' Label8
        ' 
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
        ' cbSkills
        ' 
        cbSkills.FormattingEnabled = True
        cbSkills.Location = New Point(814, 159)
        cbSkills.Margin = New Padding(3, 2, 3, 2)
        cbSkills.Name = "cbSkills"
        cbSkills.Size = New Size(133, 23)
        cbSkills.TabIndex = 16
        ' 
        ' dgSkills
        ' 
        dgSkills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSkills.Location = New Point(625, 197)
        dgSkills.Margin = New Padding(3, 2, 3, 2)
        dgSkills.Name = "dgSkills"
        dgSkills.RowHeadersWidth = 51
        dgSkills.Size = New Size(321, 141)
        dgSkills.TabIndex = 17
        ' 
        ' ucSubmit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(dgSkills)
        Controls.Add(cbSkills)
        Controls.Add(Label8)
        Controls.Add(cbActivity)
        Controls.Add(Label7)
        Controls.Add(dtDate)
        Controls.Add(Label6)
        Controls.Add(lblCharLimit)
        Controls.Add(tbDescription)
        Controls.Add(Label4)
        Controls.Add(tbTitle)
        Controls.Add(lblID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ucSubmit"
        Size = New Size(1728, 1005)
        CType(dgSkills, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents lblCharLimit As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cbActivity As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbSkills As ComboBox
    Friend WithEvents dgSkills As DataGridView

End Class
