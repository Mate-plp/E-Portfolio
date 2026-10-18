<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSubmit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label1.Location = New Point(1156, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 1
        Label1.Text = "SUBMIT1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 2
        Label2.Text = "SUBMIT2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Location = New Point(0, 788)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 3
        Label3.Text = "SUBMIT3"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(0, 0)
        lblID.Margin = New Padding(20)
        lblID.Name = "lblID"
        lblID.Padding = New Padding(30, 20, 20, 0)
        lblID.Size = New Size(122, 45)
        lblID.TabIndex = 6
        lblID.Text = "Title:"
        ' 
        ' tbTitle
        ' 
        tbTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbTitle.Location = New Point(120, 11)
        tbTitle.Name = "tbTitle"
        tbTitle.Size = New Size(554, 34)
        tbTitle.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 99)
        Label4.Margin = New Padding(20)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(30, 20, 20, 0)
        Label4.Size = New Size(203, 45)
        Label4.TabIndex = 8
        Label4.Text = "Description:"
        ' 
        ' tbDescription
        ' 
        tbDescription.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbDescription.Location = New Point(30, 156)
        tbDescription.Multiline = True
        tbDescription.Name = "tbDescription"
        tbDescription.Size = New Size(644, 291)
        tbDescription.TabIndex = 9
        ' 
        ' lblCharLimit
        ' 
        lblCharLimit.AutoSize = True
        lblCharLimit.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCharLimit.Location = New Point(450, 115)
        lblCharLimit.Margin = New Padding(20)
        lblCharLimit.Name = "lblCharLimit"
        lblCharLimit.Padding = New Padding(30, 20, 20, 0)
        lblCharLimit.Size = New Size(224, 40)
        lblCharLimit.TabIndex = 10
        lblCharLimit.Text = "0/250 characters"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(680, 0)
        Label6.Margin = New Padding(20)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(30, 20, 20, 0)
        Label6.Size = New Size(125, 45)
        Label6.TabIndex = 11
        Label6.Text = "Date:"
        ' 
        ' dtDate
        ' 
        dtDate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtDate.Location = New Point(789, 11)
        dtDate.Name = "dtDate"
        dtDate.Size = New Size(338, 34)
        dtDate.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(680, 110)
        Label7.Margin = New Padding(20)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(30, 20, 20, 0)
        Label7.Size = New Size(224, 45)
        Label7.TabIndex = 13
        Label7.Text = "Activity Type:"
        ' 
        ' cbActivity
        ' 
        cbActivity.FormattingEnabled = True
        cbActivity.Location = New Point(907, 127)
        cbActivity.Name = "cbActivity"
        cbActivity.Size = New Size(174, 28)
        cbActivity.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 12.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(680, 195)
        Label8.Margin = New Padding(20)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(30, 20, 20, 0)
        Label8.Size = New Size(263, 45)
        Label8.TabIndex = 15
        Label8.Text = "Skills Developed:"
        ' 
        ' cbSkills
        ' 
        cbSkills.FormattingEnabled = True
        cbSkills.Location = New Point(930, 212)
        cbSkills.Name = "cbSkills"
        cbSkills.Size = New Size(151, 28)
        cbSkills.TabIndex = 16
        ' 
        ' dgSkills
        ' 
        dgSkills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSkills.Location = New Point(714, 263)
        dgSkills.Name = "dgSkills"
        dgSkills.RowHeadersWidth = 51
        dgSkills.Size = New Size(367, 188)
        dgSkills.TabIndex = 17
        ' 
        ' ucSubmit
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "ucSubmit"
        Size = New Size(1225, 808)
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
