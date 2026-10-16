<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDashboard))
        Panel2 = New Panel()
        Panel4 = New Panel()
        pnlActivityCard = New Panel()
        PictureBox6 = New PictureBox()
        lblActivitySubtitle = New Label()
        lblActivityValue = New Label()
        lblActivityTitle = New Label()
        pnlTasksCard = New Panel()
        PictureBox4 = New PictureBox()
        lblTasksSubtitle = New Label()
        lblTasksCount = New Label()
        lblTasksTitle = New Label()
        pnlGPACard = New Panel()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        lblGPASubtitle = New Label()
        lblGPAValue = New Label()
        lblGPATitle = New Label()
        pnlSubjectsCard = New Panel()
        PictureBox3 = New PictureBox()
        lblSubjectsSubtitle = New Label()
        lblSubjectsCount = New Label()
        lblSubjectsTitle = New Label()
        PictureBox2 = New PictureBox()
        Panel4.SuspendLayout()
        pnlActivityCard.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        pnlTasksCard.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlGPACard.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        pnlSubjectsCard.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 1062)
        Panel2.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(pnlActivityCard)
        Panel4.Controls.Add(pnlTasksCard)
        Panel4.Controls.Add(pnlGPACard)
        Panel4.Controls.Add(pnlSubjectsCard)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1492, 1062)
        Panel4.TabIndex = 6
        ' 
        ' pnlActivityCard
        ' 
        pnlActivityCard.BackColor = Color.ForestGreen
        pnlActivityCard.Controls.Add(PictureBox6)
        pnlActivityCard.Controls.Add(lblActivitySubtitle)
        pnlActivityCard.Controls.Add(lblActivityValue)
        pnlActivityCard.Controls.Add(lblActivityTitle)
        pnlActivityCard.Location = New Point(989, 238)
        pnlActivityCard.Name = "pnlActivityCard"
        pnlActivityCard.Size = New Size(260, 120)
        pnlActivityCard.TabIndex = 6
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(22, 30)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(86, 62)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' lblActivitySubtitle
        ' 
        lblActivitySubtitle.AutoSize = True
        lblActivitySubtitle.Location = New Point(131, 83)
        lblActivitySubtitle.Name = "lblActivitySubtitle"
        lblActivitySubtitle.Size = New Size(110, 20)
        lblActivitySubtitle.TabIndex = 2
        lblActivitySubtitle.Text = "Enjoy your day!"
        ' 
        ' lblActivityValue
        ' 
        lblActivityValue.AutoSize = True
        lblActivityValue.Font = New Font("Segoe UI", 9F)
        lblActivityValue.Location = New Point(131, 44)
        lblActivityValue.Name = "lblActivityValue"
        lblActivityValue.Size = New Size(100, 20)
        lblActivityValue.TabIndex = 1
        lblActivityValue.Text = "No upcoming"
        ' 
        ' lblActivityTitle
        ' 
        lblActivityTitle.AutoSize = True
        lblActivityTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivityTitle.Location = New Point(132, 11)
        lblActivityTitle.Name = "lblActivityTitle"
        lblActivityTitle.Size = New Size(101, 20)
        lblActivityTitle.TabIndex = 0
        lblActivityTitle.Text = "Next Activity"
        ' 
        ' pnlTasksCard
        ' 
        pnlTasksCard.BackColor = Color.LightGreen
        pnlTasksCard.Controls.Add(PictureBox4)
        pnlTasksCard.Controls.Add(lblTasksSubtitle)
        pnlTasksCard.Controls.Add(lblTasksCount)
        pnlTasksCard.Controls.Add(lblTasksTitle)
        pnlTasksCard.Location = New Point(345, 238)
        pnlTasksCard.Name = "pnlTasksCard"
        pnlTasksCard.Size = New Size(260, 120)
        pnlTasksCard.TabIndex = 5
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(12, 30)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(90, 62)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' lblTasksSubtitle
        ' 
        lblTasksSubtitle.AutoSize = True
        lblTasksSubtitle.Location = New Point(108, 90)
        lblTasksSubtitle.Name = "lblTasksSubtitle"
        lblTasksSubtitle.Size = New Size(149, 20)
        lblTasksSubtitle.TabIndex = 2
        lblTasksSubtitle.Text = "Check your deadlines"
        ' 
        ' lblTasksCount
        ' 
        lblTasksCount.AutoSize = True
        lblTasksCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTasksCount.Location = New Point(104, 42)
        lblTasksCount.Name = "lblTasksCount"
        lblTasksCount.Size = New Size(33, 38)
        lblTasksCount.TabIndex = 1
        lblTasksCount.Text = "3"
        ' 
        ' lblTasksTitle
        ' 
        lblTasksTitle.AutoSize = True
        lblTasksTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTasksTitle.Location = New Point(108, 11)
        lblTasksTitle.Name = "lblTasksTitle"
        lblTasksTitle.Size = New Size(115, 20)
        lblTasksTitle.TabIndex = 0
        lblTasksTitle.Text = "Verified Entries"
        ' 
        ' pnlGPACard
        ' 
        pnlGPACard.BackColor = Color.LawnGreen
        pnlGPACard.Controls.Add(PictureBox5)
        pnlGPACard.Controls.Add(Label2)
        pnlGPACard.Controls.Add(lblGPASubtitle)
        pnlGPACard.Controls.Add(lblGPAValue)
        pnlGPACard.Controls.Add(lblGPATitle)
        pnlGPACard.Location = New Point(667, 238)
        pnlGPACard.Name = "pnlGPACard"
        pnlGPACard.Size = New Size(260, 120)
        pnlGPACard.TabIndex = 4
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(17, 30)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(86, 62)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(110, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 3
        Label2.Text = "No upcoming"
        ' 
        ' lblGPASubtitle
        ' 
        lblGPASubtitle.AutoSize = True
        lblGPASubtitle.Location = New Point(110, 83)
        lblGPASubtitle.Name = "lblGPASubtitle"
        lblGPASubtitle.Size = New Size(12, 20)
        lblGPASubtitle.TabIndex = 2
        lblGPASubtitle.Text = ","
        ' 
        ' lblGPAValue
        ' 
        lblGPAValue.AutoSize = True
        lblGPAValue.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGPAValue.Location = New Point(110, 42)
        lblGPAValue.Name = "lblGPAValue"
        lblGPAValue.Size = New Size(39, 38)
        lblGPAValue.TabIndex = 1
        lblGPAValue.Text = "--"
        ' 
        ' lblGPATitle
        ' 
        lblGPATitle.AutoSize = True
        lblGPATitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGPATitle.Location = New Point(109, 11)
        lblGPATitle.Name = "lblGPATitle"
        lblGPATitle.Size = New Size(96, 20)
        lblGPATitle.TabIndex = 0
        lblGPATitle.Text = "Current GPA"
        ' 
        ' pnlSubjectsCard
        ' 
        pnlSubjectsCard.BackColor = Color.PaleGreen
        pnlSubjectsCard.Controls.Add(PictureBox3)
        pnlSubjectsCard.Controls.Add(lblSubjectsSubtitle)
        pnlSubjectsCard.Controls.Add(lblSubjectsCount)
        pnlSubjectsCard.Controls.Add(lblSubjectsTitle)
        pnlSubjectsCard.Location = New Point(23, 238)
        pnlSubjectsCard.Name = "pnlSubjectsCard"
        pnlSubjectsCard.Size = New Size(260, 120)
        pnlSubjectsCard.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(19, 30)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(86, 62)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' lblSubjectsSubtitle
        ' 
        lblSubjectsSubtitle.AutoSize = True
        lblSubjectsSubtitle.Location = New Point(111, 90)
        lblSubjectsSubtitle.Name = "lblSubjectsSubtitle"
        lblSubjectsSubtitle.Size = New Size(100, 20)
        lblSubjectsSubtitle.TabIndex = 2
        lblSubjectsSubtitle.Text = "This Semester"
        ' 
        ' lblSubjectsCount
        ' 
        lblSubjectsCount.AutoSize = True
        lblSubjectsCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubjectsCount.Location = New Point(111, 44)
        lblSubjectsCount.Name = "lblSubjectsCount"
        lblSubjectsCount.Size = New Size(33, 38)
        lblSubjectsCount.TabIndex = 1
        lblSubjectsCount.Text = "6"
        ' 
        ' lblSubjectsTitle
        ' 
        lblSubjectsTitle.AutoSize = True
        lblSubjectsTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubjectsTitle.Location = New Point(111, 11)
        lblSubjectsTitle.Name = "lblSubjectsTitle"
        lblSubjectsTitle.Size = New Size(106, 20)
        lblSubjectsTitle.TabIndex = 0
        lblSubjectsTitle.Text = "Total Subjects"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.LemonChiffon
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        PictureBox2.Location = New Point(23, 18)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1226, 198)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ucDashboard"
        Size = New Size(1492, 1062)
        Panel4.ResumeLayout(False)
        pnlActivityCard.ResumeLayout(False)
        pnlActivityCard.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        pnlTasksCard.ResumeLayout(False)
        pnlTasksCard.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlGPACard.ResumeLayout(False)
        pnlGPACard.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        pnlSubjectsCard.ResumeLayout(False)
        pnlSubjectsCard.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlActivityCard As Panel
    Friend WithEvents pnlTasksCard As Panel
    Friend WithEvents pnlGPACard As Panel
    Friend WithEvents pnlSubjectsCard As Panel
    Friend WithEvents lblSubjectsCount As Label
    Friend WithEvents lblSubjectsTitle As Label
    Friend WithEvents lblSubjectsSubtitle As Label
    Friend WithEvents lblTasksCount As Label
    Friend WithEvents lblTasksTitle As Label
    Friend WithEvents lblTasksSubtitle As Label
    Friend WithEvents lblGPASubtitle As Label
    Friend WithEvents lblGPAValue As Label
    Friend WithEvents lblGPATitle As Label
    Friend WithEvents lblActivityTitle As Label
    Friend WithEvents lblActivitySubtitle As Label
    Friend WithEvents lblActivityValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
