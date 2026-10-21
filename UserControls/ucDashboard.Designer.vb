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
        CyberGroupBox3 = New ReaLTaiizor.Controls.CyberGroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Separator1 = New ReaLTaiizor.Controls.Separator()
        CyberGroupBox1 = New ReaLTaiizor.Controls.CyberGroupBox()
        Label4 = New Label()
        Label3 = New Label()
        Separator2 = New ReaLTaiizor.Controls.Separator()
        CyberGroupBox2 = New ReaLTaiizor.Controls.CyberGroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        FlowLayoutPanel1.SuspendLayout()
        CyberGroupBox3.SuspendLayout()
        CyberGroupBox1.SuspendLayout()
        CyberGroupBox2.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' CyberGroupBox3
        ' 
        CyberGroupBox3.Alpha = 20
        CyberGroupBox3.BackColor = Color.Transparent
        CyberGroupBox3.Background = True
        CyberGroupBox3.Background_WidthPen = 3F
        CyberGroupBox3.BackgroundPen = True
        CyberGroupBox3.ColorBackground = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ColorBackground_1 = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ColorBackground_2 = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ColorBackground_Pen = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ColorLighting = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ColorPen_1 = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.ColorPen_2 = Color.FromArgb(CByte(25), CByte(105), CByte(80))
        CyberGroupBox3.Controls.Add(Label2)
        CyberGroupBox3.Controls.Add(Label1)
        CyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberGroupBox3.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberGroupBox3.Lighting = False
        CyberGroupBox3.LinearGradient_Background = False
        CyberGroupBox3.LinearGradientPen = False
        CyberGroupBox3.Location = New Point(21, 17)
        CyberGroupBox3.Margin = New Padding(3, 2, 3, 2)
        CyberGroupBox3.Name = "CyberGroupBox3"
        CyberGroupBox3.PenWidth = 15
        CyberGroupBox3.RGB = False
        CyberGroupBox3.Rounding = True
        CyberGroupBox3.RoundingInt = 30
        CyberGroupBox3.Size = New Size(299, 206)
        CyberGroupBox3.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberGroupBox3.TabIndex = 5
        CyberGroupBox3.Tag = "Cyber"
        CyberGroupBox3.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberGroupBox3.Timer_RGB = 300
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
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 55F)
        Label2.Location = New Point(0, 92)
        Label2.Margin = New Padding(26, 0, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(299, 92)
        Label2.TabIndex = 1
        Label2.Text = "0"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Separator1
        ' 
        Separator1.LineColor = Color.Transparent
        Separator1.Location = New Point(326, 17)
        Separator1.Margin = New Padding(3, 2, 3, 2)
        Separator1.Name = "Separator1"
        Separator1.Size = New Size(70, 9)
        Separator1.TabIndex = 6
        Separator1.Text = "Separator1"
        ' 
        ' CyberGroupBox1
        ' 
        CyberGroupBox1.Alpha = 20
        CyberGroupBox1.BackColor = Color.Transparent
        CyberGroupBox1.Background = True
        CyberGroupBox1.Background_WidthPen = 3F
        CyberGroupBox1.BackgroundPen = True
        CyberGroupBox1.ColorBackground = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ColorBackground_1 = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ColorBackground_2 = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ColorBackground_Pen = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ColorLighting = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ColorPen_1 = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.ColorPen_2 = Color.FromArgb(CByte(34), CByte(170), CByte(79))
        CyberGroupBox1.Controls.Add(Label3)
        CyberGroupBox1.Controls.Add(Label4)
        CyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberGroupBox1.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberGroupBox1.Lighting = False
        CyberGroupBox1.LinearGradient_Background = False
        CyberGroupBox1.LinearGradientPen = False
        CyberGroupBox1.Location = New Point(402, 17)
        CyberGroupBox1.Margin = New Padding(3, 2, 3, 2)
        CyberGroupBox1.Name = "CyberGroupBox1"
        CyberGroupBox1.PenWidth = 15
        CyberGroupBox1.RGB = False
        CyberGroupBox1.Rounding = True
        CyberGroupBox1.RoundingInt = 30
        CyberGroupBox1.Size = New Size(299, 206)
        CyberGroupBox1.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberGroupBox1.TabIndex = 3
        CyberGroupBox1.Tag = "Cyber"
        CyberGroupBox1.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberGroupBox1.Timer_RGB = 300
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
        ' Label3
        ' 
        Label3.Dock = DockStyle.Top
        Label3.Font = New Font("Segoe UI", 55F)
        Label3.Location = New Point(0, 92)
        Label3.Margin = New Padding(26, 0, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(299, 92)
        Label3.TabIndex = 3
        Label3.Text = "0"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Separator2
        ' 
        Separator2.ForeColor = Color.Transparent
        Separator2.LineColor = Color.Transparent
        Separator2.Location = New Point(707, 17)
        Separator2.Margin = New Padding(3, 2, 3, 2)
        Separator2.Name = "Separator2"
        Separator2.Size = New Size(70, 9)
        Separator2.TabIndex = 7
        Separator2.Text = "Separator2"
        ' 
        ' CyberGroupBox2
        ' 
        CyberGroupBox2.Alpha = 20
        CyberGroupBox2.BackColor = Color.Transparent
        CyberGroupBox2.Background = True
        CyberGroupBox2.Background_WidthPen = 3F
        CyberGroupBox2.BackgroundPen = True
        CyberGroupBox2.ColorBackground = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ColorBackground_1 = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ColorBackground_2 = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ColorBackground_Pen = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ColorLighting = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ColorPen_1 = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.ColorPen_2 = Color.FromArgb(CByte(78), CByte(220), CByte(124))
        CyberGroupBox2.Controls.Add(Label5)
        CyberGroupBox2.Controls.Add(Label6)
        CyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom
        CyberGroupBox2.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        CyberGroupBox2.Lighting = False
        CyberGroupBox2.LinearGradient_Background = False
        CyberGroupBox2.LinearGradientPen = False
        CyberGroupBox2.Location = New Point(783, 17)
        CyberGroupBox2.Margin = New Padding(3, 2, 3, 2)
        CyberGroupBox2.Name = "CyberGroupBox2"
        CyberGroupBox2.PenWidth = 15
        CyberGroupBox2.RGB = False
        CyberGroupBox2.Rounding = True
        CyberGroupBox2.RoundingInt = 30
        CyberGroupBox2.Size = New Size(299, 206)
        CyberGroupBox2.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        CyberGroupBox2.TabIndex = 4
        CyberGroupBox2.Tag = "Cyber"
        CyberGroupBox2.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        CyberGroupBox2.Timer_RGB = 300
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
        ' Label5
        ' 
        Label5.Dock = DockStyle.Top
        Label5.Font = New Font("Segoe UI", 55F)
        Label5.Location = New Point(0, 92)
        Label5.Margin = New Padding(3)
        Label5.Name = "Label5"
        Label5.Size = New Size(299, 99)
        Label5.TabIndex = 5
        Label5.Text = "0"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(116, 363)
        Chart1.Margin = New Padding(3, 2, 3, 2)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Skills"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(767, 380)
        Chart1.TabIndex = 5
        Chart1.Text = "Chart1"
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        Controls.Add(Chart1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel2)
        Name = "ucDashboard"
        Size = New Size(1728, 1005)
        FlowLayoutPanel1.ResumeLayout(False)
        CyberGroupBox3.ResumeLayout(False)
        CyberGroupBox1.ResumeLayout(False)
        CyberGroupBox2.ResumeLayout(False)
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents CyberGroupBox1 As ReaLTaiizor.Controls.CyberGroupBox
    Friend WithEvents CyberGroupBox3 As ReaLTaiizor.Controls.CyberGroupBox
    Friend WithEvents CyberGroupBox2 As ReaLTaiizor.Controls.CyberGroupBox
    Friend WithEvents Separator1 As ReaLTaiizor.Controls.Separator
    Friend WithEvents Separator2 As ReaLTaiizor.Controls.Separator

End Class
