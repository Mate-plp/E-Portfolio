Module RoundHelper
    Private Sub CollectTextBoxes(parent As Control, list As List(Of TextBox))
        For Each c As Control In parent.Controls
            If TypeOf c Is TextBox Then list.Add(DirectCast(c, TextBox))
            If c.HasChildren Then CollectTextBoxes(c, list)
        Next
    End Sub

    Public Sub RoundAll(parent As Control, Optional radius As Integer = 10)
        Dim boxes As New List(Of TextBox)
        CollectTextBoxes(parent, boxes)
        For Each tb As TextBox In boxes
            WrapTextBox(tb, radius)
        Next
    End Sub

    Public Sub WrapTextBox(tb As TextBox, Optional radius As Integer = 10, Optional pad As Integer = 6)
        If tb.Parent Is Nothing OrElse tb.Dock <> DockStyle.None Then Return
        If Equals(tb.Tag, "wrapped") Then Return
        tb.Tag = "wrapped"

        tb.BorderStyle = BorderStyle.None
        Dim p As Control = tb.Parent
        Dim idx As Integer = p.Controls.GetChildIndex(tb)

        Dim host As New RoundedPanel()
        host.CornerRadius = radius
        host.FillColor = tb.BackColor
        host.Anchor = tb.Anchor
        host.Bounds = New Rectangle(tb.Left - pad, tb.Top - pad, tb.Width + pad * 2, tb.Height + pad * 2)

        p.Controls.Add(host)
        p.Controls.SetChildIndex(host, Math.Min(idx + 1, p.Controls.Count - 1))

        AddHandler tb.BackColorChanged, Sub(s, e) host.FillColor = tb.BackColor
        AddHandler tb.VisibleChanged, Sub(s, e) host.Visible = tb.Visible
    End Sub
End Module