Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundedPanel
    Inherits Panel

    Private _radius As Integer = 20
    Private _fill As Color = Color.White

    <Category("Appearance")>
    <DefaultValue(20)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CornerRadius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            _radius = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <DefaultValue(GetType(Color), "White")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property FillColor As Color
        Get
            Return _fill
        End Get
        Set(value As Color)
            _fill = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim r As Integer = Math.Min(_radius, Math.Min(Width, Height) \ 2)
        Using br As New SolidBrush(_fill)
            If r < 1 Then
                e.Graphics.FillRectangle(br, 0, 0, Width, Height)
                Return
            End If

            Dim d As Integer = r * 2
            Using path As New GraphicsPath()
                path.AddArc(0, 0, d, d, 180, 90)
                path.AddArc(Width - d - 1, 0, d, d, 270, 90)
                path.AddArc(Width - d - 1, Height - d - 1, d, d, 0, 90)
                path.AddArc(0, Height - d - 1, d, d, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(br, path)
            End Using
        End Using
    End Sub
End Class