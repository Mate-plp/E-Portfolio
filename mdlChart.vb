Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class SkillData
    Public Property Year As String
    Public Property Month As Integer
    Public Property SkillName As String
    Public Property TotalCount As Integer
    Public Property VerifiedCount As Integer
End Class
Public Class EntryData
    Public Property Year As String
    Public Property Month As Integer
    Public Property TotalEntry As Integer
    Public Property VerifiedEntry As Integer
End Class
Module mdlChart
    Dim skillList As New List(Of SkillData)()
    Dim entryList As New List(Of EntryData)()
    Sub PopulateCombos(ByVal yearCB As ComboBox)
        If entryList Is Nothing OrElse entryList.Count = 0 Then
            yearCB.DataSource = New List(Of String) From {"All"}
            Return
        End If

        Dim years = entryList.Select(Function(e) e.Year).Distinct().OrderBy(Function(y) y).ToList()

        years.Insert(0, "All")

        yearCB.DataSource = years
    End Sub

    Sub SwitchChart(ByVal chart As Chart, ByVal table As String, ByVal year As String)
        Select Case table
            Case "Total Skills"
                SkillChart(chart, year, False)
            Case "Total Verified Skills"
                SkillChart(chart, year, True)
            Case "Total Activities"
                EntryChart(chart, year)
        End Select
    End Sub
    Public Sub DebugShowLoadedData()
        Dim sb As New System.Text.StringBuilder()

        ' 1. Format Entry Data
        sb.AppendLine($"=== ENTRY DATA ({entryList.Count} Records) ===")
        If entryList.Count = 0 Then
            sb.AppendLine("No entry records found.")
        Else
            For i As Integer = 0 To entryList.Count - 1
                Dim e = entryList(i)
                sb.AppendLine($"[{i + 1}] Year: '{e.Year}' | Month: {e.Month} | TotalEntry: {e.TotalEntry} | VerifiedEntry: {e.VerifiedEntry}")
            Next
        End If

        sb.AppendLine()

        ' 2. Format Skill Data
        sb.AppendLine($"=== SKILL DATA ({skillList.Count} Records) ===")
        If skillList.Count = 0 Then
            sb.AppendLine("No skill records found.")
        Else
            For i As Integer = 0 To skillList.Count - 1
                Dim s = skillList(i)
                sb.AppendLine($"[{i + 1}] Year: '{s.Year}' | Month: {s.Month} | Skill: '{s.SkillName}' | TotalCount: {s.TotalCount} | VerifiedCount: {s.VerifiedCount}")
            Next
        End If

        ' 3. Show in MessageBox
        MessageBox.Show(sb.ToString(), "In-Memory Data Inspector", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub getUserStats()
        Try
            skillList.Clear()
            entryList.Clear()
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim skillQuery = "Select skill_name, total_count, verified_count, entry_month,entry_year " &
                    "From vSkillsTotal Where student_id = @s"

                Dim entryQuery = "Select total_entries, verified_entries, entries_month,entries_year " &
                    "From vYearlyEntries WHERE student_id = @s"

                Using cmd As New MySqlCommand(skillQuery, con)
                    cmd.Parameters.AddWithValue("@s", CurrentStudentId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim skill As New SkillData With {
                            .SkillName = reader("skill_name").ToString(),
                            .TotalCount = Convert.ToInt32(reader("total_count")),
                            .VerifiedCount = Convert.ToInt32(reader("verified_count")),
                            .Month = Convert.ToInt32(reader("entry_month")),
                            .Year = reader("entry_year").ToString()
                            }

                            Try
                                skillList.Add(skill)
                            Catch ex As Exception
                                MsgBox("mdlChart Error: " + ex.ToString())
                            End Try
                        End While
                    End Using
                End Using

                Using cmd As New MySqlCommand(entryQuery, con)
                    cmd.Parameters.AddWithValue("@s", CurrentStudentId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim entry As New EntryData With {
                                .TotalEntry = Convert.ToInt32(reader("total_entries")),
                                .VerifiedEntry = Convert.ToInt32(reader("verified_entries")),
                                .Month = Convert.ToInt32(reader("entries_month")),
                                .Year = reader("entries_year").ToString()}

                            Try
                                entryList.Add(entry)
                            Catch ex As Exception
                                MsgBox("mdlChart Error: " + ex.ToString())
                            End Try
                        End While
                    End Using
                End Using
            End Using


        Catch ex As MySqlException
            MsgBox("Connection Failed: " + ex.ToString())
        Catch ex As Exception
            MsgBox("Something went Very Wrong: " + ex.ToString())
        End Try
    End Sub
    Public Sub SkillChart(ByVal chart As Chart,
                      ByVal year As String,
                      ByVal verified As Boolean)

        chart.Series.Clear()

        If year = "All" Then
            Dim yearlyData = skillList.
            GroupBy(Function(s) New With {Key s.Year, Key s.SkillName}).
            Select(Function(g) New With {
                .Year = g.Key.Year,
                .SkillName = g.Key.SkillName,
                .Total = g.Sum(Function(x) x.TotalCount),
                .Verified = g.Sum(Function(x) x.VerifiedCount)
            }).ToList()

            Dim uniqueSkills = yearlyData.Select(Function(s) s.SkillName).Distinct().ToList()

            For Each skill In uniqueSkills
                Dim dynamicSeries As New Series(skill)
                dynamicSeries.ChartType = SeriesChartType.Column

                Dim thisSkillData = yearlyData.Where(Function(s) s.SkillName = skill).ToList()

                Dim xValues = thisSkillData.Select(Function(s) s.Year).ToArray()
                Dim yValues As Integer()

                If verified = True Then
                    yValues = thisSkillData.Select(Function(s) s.Verified).ToArray()
                Else
                    yValues = thisSkillData.Select(Function(s) s.Total).ToArray()
                End If

                dynamicSeries.Points.DataBindXY(xValues, yValues)
                dynamicSeries.IsValueShownAsLabel = True
                dynamicSeries.IsXValueIndexed = True
                chart.Series.Add(dynamicSeries)
            Next

        Else
            Dim yearSkillData = skillList.Where(Function(s) s.Year = year).ToList()

            Dim uniqueSkills = yearSkillData.Select(Function(s) s.SkillName).Distinct().ToList()

            For Each skill In uniqueSkills
                Dim dynamicSeries As New Series(skill)
                dynamicSeries.ChartType = SeriesChartType.Column

                Dim thisSkillData = yearSkillData.Where(Function(s) s.SkillName = skill).ToList()

                Dim xValues = thisSkillData.Select(Function(s) MonthName(s.Month, True)).ToArray()
                Dim yValues As Integer()

                If verified = True Then
                    yValues = thisSkillData.Select(Function(s) s.VerifiedCount).ToArray()
                Else
                    yValues = thisSkillData.Select(Function(s) s.TotalCount).ToArray()
                End If

                dynamicSeries.Points.DataBindXY(xValues, yValues)
                dynamicSeries.IsValueShownAsLabel = True
                dynamicSeries.IsXValueIndexed = True
                chart.Series.Add(dynamicSeries)
            Next
        End If

        chart.ChartAreas(0).AxisX.Interval = 1
    End Sub

    Sub EntryChart(ByVal chart As Chart, ByVal year As String)
        chart.Series.Clear()

        Dim xValues As String()
        Dim yTotal As Integer()
        Dim yVerified As Integer()

        If year = "All" Then
            Dim yearlyTotals = entryList.
            GroupBy(Function(e) e.Year).
            Select(Function(s) New With {
                .Year = s.Key,
                .Total = s.Sum(Function(e) e.TotalEntry),
                .Verified = s.Sum(Function(e) e.VerifiedEntry)
            }).ToList()

            xValues = yearlyTotals.Select(Function(y) y.Year).ToArray()
            yTotal = yearlyTotals.Select(Function(y) y.Total).ToArray()
            yVerified = yearlyTotals.Select(Function(y) y.Verified).ToArray()
        Else
            Dim monthlyData = entryList.Where(Function(e) e.Year = year).ToList()

            xValues = monthlyData.Select(Function(m) MonthName(m.Month, True)).ToArray()
            yTotal = monthlyData.Select(Function(m) m.TotalEntry).ToArray()
            yVerified = monthlyData.Select(Function(m) m.VerifiedEntry).ToArray()
        End If

        chart.Series.Clear()

        Dim seriesTotal As New Series("Total Entries")
        seriesTotal.ChartType = SeriesChartType.Column
        seriesTotal.Points.DataBindXY(xValues, yTotal)

        Dim seriesVerified As New Series("Verified Entries")
        seriesVerified.ChartType = SeriesChartType.Column
        seriesVerified.Points.DataBindXY(xValues, yVerified)

        seriesVerified.IsValueShownAsLabel = True
        seriesTotal.IsValueShownAsLabel = True

        seriesVerified.IsXValueIndexed = True
        seriesTotal.IsXValueIndexed = True

        chart.Series.Add(seriesTotal)
        chart.Series.Add(seriesVerified)

        chart.ChartAreas(0).AxisX.Interval = 1
    End Sub

    Sub PopulateTotals(ByVal lblT As Label, ByVal lblV As Label, ByVal lblS As Label)
        Dim total As Integer = entryList.Sum(Function(e) e.TotalEntry)
        Dim verified As Integer = entryList.Sum(Function(e) e.VerifiedEntry)
        Dim skills As Integer = skillList.Select(Function(s) s.SkillName).Distinct().Count()

        lblT.Text = total.ToString()
        lblV.Text = verified.ToString()
        lblS.Text = skills.ToString()
    End Sub
End Module
