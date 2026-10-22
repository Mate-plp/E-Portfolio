Imports System.ComponentModel.Design.Serialization
Imports System.Numerics
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls

Module mdlChart

    Dim skillList As New Dictionary(Of (year As String, month As Int32, skillName As String), (tCount As Int32, vCount As Int32))()

    Dim totalEntries As New Dictionary(Of (year As String, month As String), (tCount As Int32, vCount As Int32))()

    Sub populateRange(ByVal cb As ComboBox)
        For Each i In totalEntries
            If Not (cb.Items.Contains(i.Key.year)) Then
                cb.Items.Add(i.Key.year)
            End If

        Next
    End Sub
    Sub getUserStats()

        Try
            skillList.Clear()
            totalEntries.Clear()
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
                            Dim skillName As String = reader("skill_name").ToString()
                            Dim totalCount As Integer = Convert.ToInt32(reader("total_count"))
                            Dim verifiedCount As Integer = Convert.ToInt32(reader("verified_count"))
                            Dim month As Int32 = Convert.ToInt32(reader("entry_month"))
                            Dim year As String = reader("entry_year").ToString()

                            Try
                                skillList.Add((year, month, skillName), (totalCount, verifiedCount))
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
                            Dim totalEntry As Integer = Convert.ToInt32(reader("total_entries"))
                            Dim verifiedEntry As Integer = Convert.ToInt32(reader("verified_entries"))
                            Dim year As String = reader("entries_year").ToString()
                            Dim month As String = reader("entries_month").ToString()
                            Try
                                totalEntries.Add((year, month), (totalEntry, verifiedEntry))
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
    Sub CreateSkillSeries(ByVal chart As Chart)
        For Each item In skillList
            Dim series As New Series(item.Key.skillName) With {
                .ChartType = SeriesChartType.StackedColumn,
                .IsXValueIndexed = True}
            series.Points.AddXY(item.Key.month, item.Value.tCount)
        Next
    End Sub

    Sub CreateTotalSeries(ByVal chart As Chart)

    End Sub
    Sub PopulateChart(ByVal chart As Chart, ByVal selectView As String, ByVal range As String)
        chart.Series.Clear()
        chart.Titles.Clear()

        chart.ChartAreas(0).AxisY.Interval = 1

        Dim targetYear As String = range
        Dim monthNames As String() = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}

        Dim activeSeries As New Series(selectView) With {
            .ChartType = SeriesChartType.StackedColumn,
            .IsXValueIndexed = True}


        Select Case selectView
            Case "Total Skills"
                chart.Titles.Add("Total Skills Developed")

                If targetYear = "All" Then
                    For Each item In skillList
                        Dim skillName As String = item.Key.skillName
                        Dim series As Series = chart.Series.FindByName(skillName)

                        Dim xValue As Object = If(targetYear = "All",
                              CObj(item.Key.year),
                              CObj(monthNames(item.Key.month)))

                        If series Is Nothing Then
                            series = New Series(skillName) With {
                        .ChartType = SeriesChartType.StackedColumn,
                        .IsXValueIndexed = True}
                            chart.Series.Add(series)
                        End If
                        series.Points.AddXY(xValue, item.Value.tCount)
                    Next
                Else

                    For Each item In skillList
                        Dim mName As String = monthNames(item.Key.month)
                        Dim skillName As String = item.Key.skillName
                        Dim series As Series = chart.Series.FindByName(skillName)
                        If series Is Nothing Then
                            series = New Series(skillName) With {
                        .ChartType = SeriesChartType.StackedColumn,
                        .IsXValueIndexed = True
        }
                            chart.Series.Add(series)
                        End If
                        series.Points.AddXY(mName, item.Value.tCount)
                    Next
                End If

            Case "Total Verified Skills"
                chart.Titles.Add("Verified Skills Developed")
                If targetYear = "All" Then
                    For Each item In skillList
                        Dim skillName As String = item.Key.skillName
                        Dim series As Series = chart.Series.FindByName(skillName)
                        If series Is Nothing Then
                            series = New Series(skillName) With {
                        .ChartType = SeriesChartType.StackedColumn,
                        .IsXValueIndexed = True}
                            chart.Series.Add(series)
                        End If
                        series.Points.AddXY(item.Key.year, item.Value.vCount)
                    Next
                Else

                    For Each item In skillList
                        Dim mName As String = monthNames(item.Key.month)
                        Dim skillName As String = item.Key.skillName
                        Dim series As Series = chart.Series.FindByName(skillName)
                        If series Is Nothing Then
                            series = New Series(skillName) With {
                        .ChartType = SeriesChartType.StackedColumn,
                        .IsXValueIndexed = True
        }
                            chart.Series.Add(series)
                        End If
                        series.Points.AddXY(mName, item.Value.vCount)
                    Next
                End If

            Case "Total Activities"
                chart.Titles.Add($"Total & Verified Activities ({targetYear})")
                activeSeries.Color = Color.Blue

                If targetYear = "All" Then

                    For m As Integer = 1 To 12
                        Dim monthKey As String = m.ToString()
                        Dim monthTotal As Integer = totalEntries _
                            .Where(Function(i) i.Key.month = monthKey) _
                            .Sum(Function(i) i.Value.tCount)

                        activeSeries.Points.AddXY(monthNames(m - 1), monthTotal)
                    Next
                Else

                    For m As Integer = 1 To 12
                        Dim monthKey As String = m.ToString()
                        Dim count As Integer = 0

                        If totalEntries.ContainsKey((targetYear, monthKey)) Then
                            count = totalEntries((targetYear, monthKey)).tCount
                        End If

                        activeSeries.Points.AddXY(monthNames(m - 1), count)
                    Next
                End If


        End Select

        chart.Series.Add(activeSeries)
    End Sub
End Module
