Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.Rendering
Imports MySql.Data.MySqlClient

Module mdlExport
    Private ReadOnly Green As MigraDoc.DocumentObjectModel.Color =
        MigraDoc.DocumentObjectModel.Color.FromRgb(25, 105, 80)
    Private ReadOnly Gray As MigraDoc.DocumentObjectModel.Color =
        MigraDoc.DocumentObjectModel.Color.FromRgb(110, 110, 110)

    Private Function Cell(row As DataRow, col As String) As String
        If row.IsNull(col) Then Return ""
        Dim s As String = row(col).ToString().Trim()
        Return If(s = "Pending", "", s)
    End Function

    Private Sub AddHeading(sec As Section, text As String)
        Dim p As Paragraph = sec.AddParagraph(text)
        p.Format.Font.Size = 13
        p.Format.Font.Bold = True
        p.Format.Font.Color = Green
        p.Format.SpaceBefore = Unit.FromPoint(16)
        p.Format.SpaceAfter = Unit.FromPoint(6)
        p.Format.Borders.Bottom.Width = Unit.FromPoint(0.75)
        p.Format.Borders.Bottom.Color = Green
    End Sub

    Private Sub AddField(sec As Section, label As String, value As String)
        If value = "" Then Return
        Dim p As Paragraph = sec.AddParagraph()
        p.Format.SpaceAfter = Unit.FromPoint(2)
        p.AddFormattedText(label & ": ", TextFormat.Bold)
        p.AddText(value)
    End Sub

    Private Function VerifiedSkillsChartBase64() As String
        getUserStats()

        Using ch As New Chart()
            ch.Size = New System.Drawing.Size(1200, 600)
            ch.BackColor = System.Drawing.Color.White

            Dim area As New ChartArea("main")
            area.BackColor = System.Drawing.Color.White
            ch.ChartAreas.Add(area)
            ch.Legends.Add(New Legend("legend"))

            SwitchChart(ch, "Total Verified Skills", "All")

            Dim hasData As Boolean = ch.Series.Any(
                Function(s) s.Points.Any(Function(pt) pt.YValues(0) > 0))
            If Not hasData Then Return ""

            Using ms As New MemoryStream()
                ch.SaveImage(ms, ChartImageFormat.Png)
                Return Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
    End Function

    Public Sub CreatePortfolioPdf(studentId As String, filePath As String)
        Dim profile As New DataTable()
        Dim entries As New DataTable()
        Dim skillsByEntry As New Dictionary(Of Integer, List(Of String))

        ' ---- Read everything first ----
        Using con As New MySqlConnection(conString)
            con.Open()

            Using da As New MySqlDataAdapter(
                "SELECT u.username, u.first_name, u.middle_name, u.last_name, s.student_id, " &
                "s.program, s.year_level, s.student_bio, a.address_line_1, a.address_line_2, a.barangay, a.city, a.region " &
                "FROM student s INNER JOIN users u ON u.username = s.username " &
                "LEFT JOIN address a ON a.address_id = u.address_id " &
                "WHERE s.student_id = @id", con)
                da.SelectCommand.Parameters.AddWithValue("@id", studentId)
                da.Fill(profile)
            End Using

            Using da As New MySqlDataAdapter(
                "SELECT e.entry_id, e.activity_title, e.`date`, t.type_name, e.verified, e.description, " &
                "CONCAT(u.first_name, ' ', u.last_name) AS verifier " &
                "FROM portfolio_entries e " &
                "INNER JOIN activity_type t ON t.type_id = e.type_id " &
                "LEFT JOIN faculty f ON f.professor_id = e.professor_id " &
                "LEFT JOIN users u ON u.username = f.username " &
                "WHERE e.student_id = @id AND e.verified = 1 ORDER BY e.`date` DESC, e.entry_id DESC", con)
                da.SelectCommand.Parameters.AddWithValue("@id", studentId)
                da.Fill(entries)
            End Using

            Using cmd As New MySqlCommand(
                "SELECT ps.entry_id, s.skill_name FROM portfolio_skills ps " &
                "INNER JOIN skills s ON s.skill_id = ps.skill_id " &
                "INNER JOIN portfolio_entries e ON e.entry_id = ps.entry_id " &
                "WHERE e.student_id = @id ORDER BY s.skill_name", con)
                cmd.Parameters.AddWithValue("@id", studentId)
                Using r As MySqlDataReader = cmd.ExecuteReader()
                    While r.Read()
                        Dim id As Integer = r.GetInt32(0)
                        If Not skillsByEntry.ContainsKey(id) Then skillsByEntry(id) = New List(Of String)
                        skillsByEntry(id).Add(r.GetString(1))
                    End While
                End Using
            End Using
        End Using

        If profile.Rows.Count = 0 Then Throw New InvalidOperationException("Student not found.")
        Dim p0 As DataRow = profile.Rows(0)

        Dim nameParts As New List(Of String) From {
            Cell(p0, "first_name"), Cell(p0, "middle_name"), Cell(p0, "last_name")}
        Dim fullName As String = String.Join(" ", nameParts.Where(Function(s) s <> ""))

        ' ---- Build the document ----
        Dim doc As New Document()
        doc.Info.Title = "E-Portfolio - " & fullName
        doc.Styles("Normal").Font.Name = "Arial"
        doc.Styles("Normal").Font.Size = 10

        Dim sec As Section = doc.AddSection()
        sec.PageSetup.PageFormat = PageFormat.A4
        sec.PageSetup.LeftMargin = Unit.FromCentimeter(2)
        sec.PageSetup.RightMargin = Unit.FromCentimeter(2)
        sec.PageSetup.TopMargin = Unit.FromCentimeter(2)
        sec.PageSetup.BottomMargin = Unit.FromCentimeter(2)

        ' Header
        Dim title As Paragraph = sec.AddParagraph("E-Portfolio")
        title.Format.Font.Size = 22
        title.Format.Font.Bold = True
        title.Format.Font.Color = Green

        Dim subtitle As Paragraph = sec.AddParagraph(fullName & "  |  " & Cell(p0, "student_id"))
        subtitle.Format.Font.Size = 12

        Dim gen As Paragraph = sec.AddParagraph("As of " & Date.Now.ToString("MMMM d, yyyy"))
        gen.Format.Font.Size = 9
        gen.Format.Font.Color = Gray

        ' Profile
        AddHeading(sec, "Profile")
        AddField(sec, "Full name", fullName)
        AddField(sec, "Student ID", Cell(p0, "student_id"))
        AddField(sec, "Program", Cell(p0, "program"))

        Dim addr As New List(Of String) From {
            Cell(p0, "address_line_1"), Cell(p0, "address_line_2"),
            Cell(p0, "barangay"), Cell(p0, "city"), Cell(p0, "region")}
        AddField(sec, "Address", String.Join(", ", addr.Where(Function(s) s <> "")))

        AddField(sec, "Bio", Cell(p0, "student_bio"))

        AddHeading(sec, "Skill Growth")
        Dim chartData As String = VerifiedSkillsChartBase64()
        If chartData = "" Then
            sec.AddParagraph("No verified skills yet.")
        Else
            Dim pic = sec.AddImage("base64:" & chartData)
            pic.LockAspectRatio = True
            pic.Width = Unit.FromCentimeter(17)
        End If

        ' Entries
        sec.AddPageBreak()
        AddHeading(sec, "Portfolio entries (" & entries.Rows.Count & ")")
        If entries.Rows.Count = 0 Then sec.AddParagraph("No entries yet.")

        For Each row As DataRow In entries.Rows
            Dim id As Integer = Convert.ToInt32(row("entry_id"))

            Dim head As Paragraph = sec.AddParagraph(Cell(row, "activity_title"))
            head.Format.Font.Bold = True
            head.Format.Font.Size = 11
            head.Format.SpaceBefore = Unit.FromPoint(10)
            head.Format.KeepWithNext = True

            Dim meta As Paragraph = sec.AddParagraph(
                Convert.ToDateTime(row("date")).ToString("MMM d, yyyy") & "  |  " &
                Cell(row, "type_name"))
            meta.Format.Font.Size = 9
            meta.Format.Font.Color = Gray
            meta.Format.KeepWithNext = True

            sec.AddParagraph(Cell(row, "description")).Format.SpaceAfter = Unit.FromPoint(2)

            If skillsByEntry.ContainsKey(id) Then
                AddField(sec, "Skills", String.Join(", ", skillsByEntry(id)))
            End If
        Next

        ' ---- Write the file ----
        Dim renderer As New PdfDocumentRenderer() With {.Document = doc}
        renderer.RenderDocument()
        renderer.PdfDocument.Save(filePath)
    End Sub
End Module