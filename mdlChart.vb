Imports System.ComponentModel.Design.Serialization
Imports System.Numerics
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls

Module mdlChart

    Dim skillList As New Dictionary(Of (skillName As String, year As String), (tCount As Int32, vCount As Int32))()

    Dim totalEntries As New Dictionary(Of (year As String, month As String), (tCount As Int32, vCount As Int32))()

    Sub populateRange(ByVal cb As ComboBox)
        For Each i In totalEntries
            cb.Items.Add(i.Key.year)
        Next
    End Sub
    Sub getUserStats()

        Try
            skillList.Clear()
            totalEntries.Clear()
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim skillQuery = "Select skill_name, total_count, verified_count, entry_year " &
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
                            Dim year As String = reader("entry_year").ToString()

                            skillList((skillName, year)) = (totalCount, verifiedCount)
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

                            totalEntries.Add((year, month), (totalEntry, verifiedEntry))
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
                activeSeries.Color = Color.Red

                If targetYear = "All" Then
                    Dim totals As New Dictionary(Of String, Int32)()
                    For Each item In skillList
                        Dim skill As String = item.Key.skillName
                        Dim count As Int32 = item.Value.tCount

                        If (totals.ContainsKey(skill)) Then
                            totals(skill) += count
                        Else
                            totals.Add(skill, count)
                        End If
                    Next

                    For Each item In totals
                        activeSeries.Points.AddXY(item.Key, item.Value)
                    Next
                Else
                    For Each item In skillList
                        If item.Key.year = targetYear Then
                            activeSeries.Points.AddXY(item.Key.skillName, item.Value.tCount)
                        End If

                    Next
                End If

            Case "Total Verified Skills"
                chart.Titles.Add("Verified Skills Developed")
                activeSeries.Color = Color.Orange

                If targetYear = "All" Then
                    Dim totals As New Dictionary(Of String, Int32)()
                    For Each item In skillList
                        Dim skill As String = item.Key.skillName
                        Dim count As Int32 = item.Value.vCount

                        If (totals.ContainsKey(skill)) Then
                            totals(skill) += count
                        Else
                            totals.Add(skill, count)
                        End If
                    Next

                    For Each item In totals
                        activeSeries.Points.AddXY(item.Key, item.Value)
                    Next
                Else
                    For Each item In skillList
                        If item.Key.year = targetYear Then
                            activeSeries.Points.AddXY(item.Key.skillName, item.Value.vCount)
                        End If

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
