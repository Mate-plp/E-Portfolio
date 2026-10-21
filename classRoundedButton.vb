Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    Private _radius As Integer = 12
    Private _hover As Boolean
    Private _down As Boolean

    <Category("Appearance")>
    <DefaultValue(12)>
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

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
    End Sub

    Protected Overrides ReadOnly Property ShowFocusCues As Boolean
        Get
            Return False
        End Get
    End Property

    Private Shared Function Shade(c As Color, amount As Integer) As Color
        Return Color.FromArgb(c.A,
            Math.Max(0, Math.Min(255, c.R + amount)),
            Math.Max(0, Math.Min(255, c.G + amount)),
            Math.Max(0, Math.Min(255, c.B + amount)))
    End Function

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim g As Graphics = pevent.Graphics
        ButtonRenderer.DrawParentBackground(g, ClientRectangle, Me)
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.PixelOffsetMode = PixelOffsetMode.HighQuality

        Dim fill As Color = BackColor
        Dim textColor As Color = ForeColor
        If Not Enabled Then
            fill = Shade(BackColor, 60)
            textColor = SystemColors.GrayText
        ElseIf _down Then
            fill = Shade(BackColor, -35)
        ElseIf _hover Then
            fill = Shade(BackColor, -18)
        End If

        Dim r As Integer = Math.Min(_radius, Math.Min(Width, Height) \ 2)
        Dim d As Integer = r * 2
        Dim w As Integer = Width - 1
        Dim h As Integer = Height - 1

        Using path As New GraphicsPath()
            If r < 1 Then
                path.AddRectangle(New Rectangle(0, 0, w, h))
            Else
                path.AddArc(0, 0, d, d, 180, 90)
                path.AddArc(w - d, 0, d, d, 270, 90)
                path.AddArc(w - d, h - d, d, d, 0, 90)
                path.AddArc(0, h - d, d, d, 90, 90)
                path.CloseFigure()
            End If
            Using br As New SolidBrush(fill)
                g.FillPath(br, path)
            End Using
        End Using

        TextRenderer.DrawText(g, Text, Font, ClientRectangle, textColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or
            TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix)
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        _hover = True : Invalidate() : MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _hover = False : _down = False : Invalidate() : MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        _down = True : Invalidate() : MyBase.OnMouseDown(mevent)
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        _down = False : Invalidate() : MyBase.OnMouseUp(mevent)
    End Sub
End Class