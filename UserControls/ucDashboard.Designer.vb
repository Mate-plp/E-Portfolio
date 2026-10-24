<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Panel2 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        CyberGroupBox3 = New RoundedPanel()
        lblTotal = New Label()
        Label1 = New Label()
        Separator1 = New Panel()
        CyberGroupBox1 = New RoundedPanel()
        lblVerified = New Label()
        Label4 = New Label()
        Separator2 = New Panel()
        CyberGroupBox2 = New RoundedPanel()
        lblSkills = New Label()
        Label6 = New Label()
        cbChartBox = New ComboBox()
        chtProgress = New DataVisualization.Charting.Chart()
        cbYear = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CyberGroupBox3.SuspendLayout()
        CyberGroupBox1.SuspendLayout()
        CyberGroupBox2.SuspendLayout()
        CType(chtProgress, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 1005)
        Panel2.TabIndex = 3
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(CyberGroupBox3)
        FlowLayoutPanel1.Controls.Add(Separator1)
        FlowLayoutPanel1.Controls.Add(CyberGroupBox1)
        FlowLayoutPanel1.Controls.Add(Separator2)
        FlowLayoutPanel1.Controls.Add(CyberGroupBox2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(18, 15, 18, 15)
        FlowLayoutPanel1.Size = New Size(1728, 272)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(21, 17)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(165, 10)
        Panel1.TabIndex = 8
        Panel1.Text = "Panel1"
        ' 
        ' CyberGroupBox3
        ' 
        CyberGroupBox3.BackColor = Color.Transparent
        CyberGroupBox3.Controls.Add(lblTotal)
        CyberGroupBox3.Controls.Add(Label1)
        CyberGroupBox3.CornerRadius = 30
        CyberGroupBox3.FillColor = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberGroupBox3.Location = New Point(192, 17)
        CyberGroupBox3.Margin = New Padding(3, 2, 3, 2)
        CyberGroupBox3.Name = "CyberGroupBox3"
        CyberGroupBox3.Size = New Size(299, 206)
        CyberGroupBox3.TabIndex = 5
        ' 
        ' lblTotal
        ' 
        lblTotal.Dock = DockStyle.Top
        lblTotal.Font = New Font("Segoe UI", 55F)
        lblTotal.Location = New Point(0, 92)
        lblTotal.Margin = New Padding(26, 0, 3, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(299, 92)
        lblTotal.TabIndex = 1
        lblTotal.Text = "0"
        lblTotal.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 92)
        Label1.TabIndex = 0
        Label1.Text = "TOTAL ENTRIES"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Separator1
        ' 
        Separator1.Location = New Point(497, 17)
        Separator1.Margin = New Padding(3, 2, 3, 2)
        Separator1.Name = "Separator1"
        Separator1.Size = New Size(165, 10)
        Separator1.TabIndex = 6
        Separator1.Text = "Separator1"
        ' 
        ' CyberGroupBox1
        ' 
        CyberGroupBox1.BackColor = Color.Transparent
        CyberGroupBox1.Controls.Add(lblVerified)
        CyberGroupBox1.Controls.Add(Label4)
        CyberGroupBox1.CornerRadius = 30
        CyberGroupBox1.FillColor = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberGroupBox1.Location = New Point(668, 17)
        CyberGroupBox1.Margin = New Padding(3, 2, 3, 2)
        CyberGroupBox1.Name = "CyberGroupBox1"
        CyberGroupBox1.Size = New Size(299, 206)
        CyberGroupBox1.TabIndex = 3
        ' 
        ' lblVerified
        ' 
        lblVerified.Dock = DockStyle.Top
        lblVerified.Font = New Font("Segoe UI", 55F)
        lblVerified.Location = New Point(0, 92)
        lblVerified.Margin = New Padding(26, 0, 3, 0)
        lblVerified.Name = "lblVerified"
        lblVerified.Size = New Size(299, 92)
        lblVerified.TabIndex = 3
        lblVerified.Text = "0"
        lblVerified.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Top
        Label4.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(299, 92)
        Label4.TabIndex = 2
        Label4.Text = "VERIFIED"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Separator2
        ' 
        Separator2.ForeColor = Color.Transparent
        Separator2.Location = New Point(973, 17)
        Separator2.Margin = New Padding(3, 2, 3, 2)
        Separator2.Name = "Separator2"
        Separator2.Size = New Size(165, 10)
        Separator2.TabIndex = 7
        Separator2.Text = "Separator2"
        ' 
        ' CyberGroupBox2
        ' 
        CyberGroupBox2.BackColor = Color.Transparent
        CyberGroupBox2.Controls.Add(lblSkills)
        CyberGroupBox2.Controls.Add(Label6)
        CyberGroupBox2.CornerRadius = 30
        CyberGroupBox2.FillColor = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberGroupBox2.Location = New Point(1144, 17)
        CyberGroupBox2.Margin = New Padding(3, 2, 3, 2)
        CyberGroupBox2.Name = "CyberGroupBox2"
        CyberGroupBox2.Size = New Size(299, 206)
        CyberGroupBox2.TabIndex = 4
        ' 
        ' lblSkills
        ' 
        lblSkills.Dock = DockStyle.Top
        lblSkills.Font = New Font("Segoe UI", 55F)
        lblSkills.Location = New Point(0, 92)
        lblSkills.Margin = New Padding(3)
        lblSkills.Name = "lblSkills"
        lblSkills.Size = New Size(299, 99)
        lblSkills.TabIndex = 5
        lblSkills.Text = "0"
        lblSkills.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Top
        Label6.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(299, 92)
        Label6.TabIndex = 4
        Label6.Text = "SKILLS" & vbCrLf & "DEVELOPED"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cbChartBox
        ' 
        cbChartBox.AutoCompleteCustomSource.AddRange(New String() {"Total Skills", "Total Verified Skills", "Total Activities", "Total Verified Activities"})
        cbChartBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbChartBox.AutoCompleteSource = AutoCompleteSource.ListItems
        cbChartBox.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbChartBox.FormattingEnabled = True
        cbChartBox.Items.AddRange(New Object() {"Total Skills", "Total Verified Skills", "Total Activities"})
        cbChartBox.Location = New Point(1144, 451)
        cbChartBox.Name = "cbChartBox"
        cbChartBox.Size = New Size(354, 38)
        cbChartBox.TabIndex = 6
        cbChartBox.Text = "Total Skills"
        ' 
        ' chtProgress
        ' 
        ChartArea1.Name = "ChartArea1"
        chtProgress.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chtProgress.Legends.Add(Legend1)
        chtProgress.Location = New Point(93, 324)
        chtProgress.Name = "chtProgress"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chtProgress.Series.Add(Series1)
        chtProgress.Size = New Size(941, 595)
        chtProgress.TabIndex = 7
        chtProgress.Text = "Chart1"
        ' 
        ' cbYear
        ' 
        cbYear.AutoCompleteCustomSource.AddRange(New String() {"Total Skills", "Total Verified Skills", "Total Activities", "Total Verified Activities"})
        cbYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbYear.AutoCompleteSource = AutoCompleteSource.ListItems
        cbYear.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"All"})
        cbYear.Location = New Point(1144, 344)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(354, 38)
        cbYear.TabIndex = 8
        cbYear.Text = "All"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label2.Location = New Point(1144, 296)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 45)
        Label2.TabIndex = 9
        Label2.Text = "Year:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label3.Location = New Point(1144, 403)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 45)
        Label3.TabIndex = 10
        Label3.Text = "Category:"
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cbYear)
        Controls.Add(chtProgress)
        Controls.Add(cbChartBox)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        Name = "ucDashboard"
        Size = New Size(1728, 1005)
        FlowLayoutPanel1.ResumeLayout(False)
        CyberGroupBox3.ResumeLayout(False)
        CyberGroupBox1.ResumeLayout(False)
        CyberGroupBox2.ResumeLayout(False)
        CType(chtProgress, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVerified As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSkills As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CyberGroupBox1 As RoundedPanel
    Friend WithEvents CyberGroupBox3 As RoundedPanel
    Friend WithEvents CyberGroupBox2 As RoundedPanel
    Friend WithEvents Separator1 As System.Windows.Forms.Panel
    Friend WithEvents Separator2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbChartBox As ComboBox
    Friend WithEvents chtProgress As DataVisualization.Charting.Chart
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
