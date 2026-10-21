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
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 1340)
        Panel2.TabIndex = 3
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(20)
        FlowLayoutPanel1.Size = New Size(1975, 362)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LimeGreen
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(23, 23)
        Panel1.Margin = New Padding(3, 3, 100, 3)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(25)
        Panel1.Size = New Size(361, 274)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 55F)
        Label2.Location = New Point(109, 123)
        Label2.Margin = New Padding(30, 0, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 123)
        Label2.TabIndex = 1
        Label2.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label1.Location = New Point(34, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 57)
        Label1.TabIndex = 0
        Label1.Text = "TOTAL ENTRIES"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LimeGreen
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(487, 23)
        Panel3.Margin = New Padding(3, 3, 100, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(25)
        Panel3.Size = New Size(355, 274)
        Panel3.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 55F)
        Label3.Location = New Point(131, 126)
        Label3.Margin = New Padding(30, 0, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 123)
        Label3.TabIndex = 3
        Label3.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label4.Location = New Point(82, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 57)
        Label4.TabIndex = 2
        Label4.Text = "VERIFIED"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LimeGreen
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(945, 23)
        Panel4.Margin = New Padding(3, 3, 100, 3)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(25)
        Panel4.Size = New Size(355, 274)
        Panel4.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 55F)
        Label5.Location = New Point(136, 123)
        Label5.Margin = New Padding(30, 0, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 123)
        Label5.TabIndex = 5
        Label5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label6.Location = New Point(57, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(259, 114)
        Label6.TabIndex = 4
        Label6.Text = "SKILLS" & vbCrLf & "DEVELOPED"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(132, 484)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Skills"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(877, 506)
        Chart1.TabIndex = 5
        Chart1.Text = "Chart1"
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(Chart1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ucDashboard"
        Size = New Size(1975, 1340)
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart

End Class
