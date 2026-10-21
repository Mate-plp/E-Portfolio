Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class ucProfile
    Private Sub ucProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadProfile()
        LockAll()
        RoundAll(Me, 10)
    End Sub

    Private Function Txt(r As MySqlDataReader, column As String) As String
        Dim i As Integer = r.GetOrdinal(column)
        Return If(r.IsDBNull(i), "", r.GetValue(i).ToString())
    End Function

    Private Sub LoadProfile()
        If String.IsNullOrEmpty(CurrentStudentId) Then Return

        Dim sql As String =
        "SELECT u.username, u.first_name, u.middle_name, u.last_name, " &
        "       s.student_id, s.program, s.year_level, " &
        "       a.address_line_1, a.address_line_2, a.barangay, a.city, a.region, a.zip_code " &
        "FROM student s " &
        "INNER JOIN users u ON u.username = s.username " &
        "LEFT JOIN address a ON a.address_id = u.address_id " &
        "WHERE s.student_id = @id " &
        "LIMIT 1"

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", CurrentStudentId)

                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If Not r.Read() Then Return

                        ' User info
                        tbUsername.Text = Txt(r, "username")
                        tbFN.Text = Txt(r, "first_name")
                        tbMN.Text = Txt(r, "middle_name")
                        tbLN.Text = Txt(r, "last_name")

                        ' Student info
                        tbID.Text = Txt(r, "student_id")
                        tbProgram.Text = Txt(r, "program")
                        tbYear.Text = Txt(r, "year_level")

                        ' Address
                        tbLine1.Text = Txt(r, "address_line_1")
                        tbLine2.Text = Txt(r, "address_line_2")
                        tbBar.Text = Txt(r, "barangay")
                        tbCity.Text = Txt(r, "city")
                        tbRegion.Text = Txt(r, "region")
                        tbZip.Text = Txt(r, "zip_code")
                    End Using
                End Using
            End Using

            ' Password boxes are empty on purpose
            tbOldPass.Clear()
            tbNewPass.Clear()

        Catch ex As Exception
            MessageBox.Show("Could not load profile: " & ex.Message)
        End Try
    End Sub

    Private Sub editInfo(txt As TextBox)
        txt.ReadOnly = Not txt.ReadOnly
        txt.Enabled = Not txt.Enabled

        If txt.Enabled Then
            txt.Focus()
            txt.SelectionStart = txt.TextLength
        End If
    End Sub

    Private Sub btnUsername_Click(sender As Object, e As EventArgs) Handles btnUsername.Click
        editInfo(tbUsername)
    End Sub

    Private Sub btnFN_Click(sender As Object, e As EventArgs) Handles btnFN.Click
        editInfo(tbFN)
    End Sub
    Private Sub btnMN_Click(sender As Object, e As EventArgs) Handles btnMN.Click
        editInfo(tbMN)
    End Sub

    Private Sub btnLN_Click(sender As Object, e As EventArgs) Handles btnLN.Click
        editInfo(tbLN)
    End Sub

    Private Sub btnOldPass_Click(sender As Object, e As EventArgs) Handles btnOldPass.Click
        editInfo(tbOldPass)
    End Sub

    Private Sub btnNewPass_Click(sender As Object, e As EventArgs) Handles btnNewPass.Click
        editInfo(tbNewPass)
    End Sub

    Private Sub btnCfmPass_Click(sender As Object, e As EventArgs) Handles btnCfmPass.Click
        editInfo(tbCfmPass)
    End Sub

    Private Sub btnProgram_Click(sender As Object, e As EventArgs) Handles btnProgram.Click
        editInfo(tbProgram)
    End Sub

    Private Sub btnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        editInfo(tbYear)
    End Sub

    Private Sub btnLine1_Click(sender As Object, e As EventArgs) Handles btnLine1.Click
        editInfo(tbLine1)
    End Sub

    Private Sub btnLine2_Click(sender As Object, e As EventArgs) Handles btnLine2.Click
        editInfo(tbLine2)
    End Sub

    Private Sub btnCity_Click(sender As Object, e As EventArgs) Handles btnCity.Click
        editInfo(tbCity)
    End Sub

    Private Sub btnZip_Click(sender As Object, e As EventArgs) Handles btnZip.Click
        editInfo(tbZip)
    End Sub

    Private Sub btnBar_Click(sender As Object, e As EventArgs) Handles btnBar.Click
        editInfo(tbBar)
    End Sub

    Private Sub btnRegion_Click(sender As Object, e As EventArgs) Handles btnRegion.Click
        editInfo(tbRegion)
    End Sub
    Private Sub LockAll()
        For Each tb As TextBox In {tbUsername, tbFN, tbMN, tbLN, tbID, tbProgram, tbYear,
                               tbLine1, tbLine2, tbBar, tbCity, tbRegion, tbZip,
                               tbOldPass, tbNewPass, tbCfmPass}
            tb.Enabled = False
            tb.BackColor = Color.WhiteSmoke
        Next
        tbOldPass.Clear()
        tbNewPass.Clear()
        tbCfmPass.Clear()
    End Sub

    Private Sub Notify(msg As String)
        ShowToast(Me.FindForm(), msg)
    End Sub

    Private Function NullIfEmpty(s As String) As Object
        Return If(s = "", CObj(DBNull.Value), s)
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' ---- Read the boxes ----
        Dim username As String = tbUsername.Text.Trim()
        Dim firstName As String = tbFN.Text.Trim()
        Dim middleName As String = tbMN.Text.Trim()
        Dim lastName As String = tbLN.Text.Trim()
        Dim program As String = tbProgram.Text.Trim()
        Dim yearText As String = tbYear.Text.Trim()
        Dim line1 As String = tbLine1.Text.Trim()
        Dim line2 As String = tbLine2.Text.Trim()
        Dim barangay As String = tbBar.Text.Trim()
        Dim city As String = tbCity.Text.Trim()
        Dim region As String = tbRegion.Text.Trim()
        Dim zip As String = tbZip.Text.Trim()
        Dim oldPass As String = tbOldPass.Text
        Dim newPass As String = tbNewPass.Text

        ' ---- Validate ----
        If username = "" OrElse firstName = "" OrElse lastName = "" Then
            Notify("Username, first name, and last name are required.")
            Return
        End If

        If username.Length > 25 OrElse middleName.Length > 25 OrElse
       firstName.Length > 50 OrElse lastName.Length > 50 OrElse program.Length > 10 Then
            Notify("One of the fields is too long.")
            Return
        End If

        Dim yearValue As Object = DBNull.Value
        If yearText <> "" Then
            Dim y As Integer
            If Not Integer.TryParse(yearText, y) OrElse y < 1 OrElse y > 6 Then
                Notify("Year level must be a number from 1 to 6.")
                Return
            End If
            yearValue = y
        End If

        Dim changePass As Boolean = (oldPass <> "" OrElse newPass <> "")
        If changePass Then
            If oldPass = "" OrElse newPass = "" Then
                Notify("Enter both your old and new password.")
                Return
            End If
            If newPass.Length < 8 OrElse newPass.Length > 50 Then
                Notify("New password must be 8 to 50 characters.")
                Return
            End If
            If newPass <> tbCfmPass.Text Then
                Notify("New passwords do not match.")
                Return
            End If
        End If

        ' Address
        Dim hasAddress As Boolean = (line1 <> "" OrElse line2 <> "" OrElse barangay <> "" OrElse
                                 city <> "" OrElse region <> "" OrElse zip <> "")
        If hasAddress Then
            If line1 = "" OrElse barangay = "" OrElse city = "" OrElse region = "" OrElse zip = "" Then
                Notify("Address line 1, barangay, city, region, and ZIP code are required.")
                Return
            End If
            If zip.Length <> 4 OrElse Not zip.All(Function(c) Char.IsDigit(c)) Then
                Notify("ZIP code must be exactly 4 digits.")
                Return
            End If
            If line1.Length > 150 OrElse line2.Length > 150 OrElse barangay.Length > 50 OrElse
           city.Length > 50 OrElse region.Length > 50 Then
                Notify("An address field is too long.")
                Return
            End If
        End If

        ' ---- Save ----
        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Using tx As MySqlTransaction = con.BeginTransaction()
                    ' Current values for this student
                    Dim oldUsername As String = ""
                    Dim currentPass As String = ""
                    Dim addressId As Object = DBNull.Value

                    Using cmd As New MySqlCommand(
                    "SELECT u.username, u.password, u.address_id " &
                    "FROM student s INNER JOIN users u ON u.username = s.username " &
                    "WHERE s.student_id = @id", con, tx)
                        cmd.Parameters.AddWithValue("@id", CurrentStudentId)
                        Using r As MySqlDataReader = cmd.ExecuteReader()
                            If Not r.Read() Then
                                Notify("Could not find your account.")
                                Return
                            End If
                            oldUsername = r.GetString("username")
                            currentPass = r.GetString("password")
                            If Not r.IsDBNull(r.GetOrdinal("address_id")) Then
                                addressId = r.GetInt32("address_id")
                            End If
                        End Using
                    End Using

                    ' Password check
                    If changePass AndAlso oldPass <> currentPass Then
                        Notify("Old password is incorrect.")
                        Return
                    End If

                    ' Username taken by someone else?
                    If Not String.Equals(username, oldUsername, StringComparison.OrdinalIgnoreCase) Then
                        Using cmd As New MySqlCommand(
                        "SELECT COUNT(*) FROM users WHERE username = @new", con, tx)
                            cmd.Parameters.AddWithValue("@new", username)
                            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                                Notify("That username is already taken.")
                                Return
                            End If
                        End Using
                    End If

                    ' users
                    Dim userSql As String =
                    "UPDATE users SET username = @new, first_name = @fn, middle_name = @mn, last_name = @ln" &
                    If(changePass, ", password = @p", "") &
                    " WHERE username = @old"

                    Using cmd As New MySqlCommand(userSql, con, tx)
                        cmd.Parameters.AddWithValue("@new", username)
                        cmd.Parameters.AddWithValue("@fn", firstName)
                        cmd.Parameters.AddWithValue("@mn", NullIfEmpty(middleName))
                        cmd.Parameters.AddWithValue("@ln", lastName)
                        If changePass Then cmd.Parameters.AddWithValue("@p", newPass)
                        cmd.Parameters.AddWithValue("@old", oldUsername)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' student
                    Using cmd As New MySqlCommand(
                    "UPDATE student SET program = @prog, year_level = @yr WHERE student_id = @id", con, tx)
                        cmd.Parameters.AddWithValue("@prog", NullIfEmpty(program))
                        cmd.Parameters.AddWithValue("@yr", yearValue)
                        cmd.Parameters.AddWithValue("@id", CurrentStudentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' address
                    If hasAddress Then
                        If addressId Is DBNull.Value Then
                            Dim newId As Long
                            Using cmd As New MySqlCommand(
                            "INSERT INTO address (address_line_1, address_line_2, barangay, city, region, zip_code) " &
                            "VALUES (@l1, @l2, @bar, @city, @reg, @zip)", con, tx)
                                cmd.Parameters.AddWithValue("@l1", line1)
                                cmd.Parameters.AddWithValue("@l2", NullIfEmpty(line2))
                                cmd.Parameters.AddWithValue("@bar", barangay)
                                cmd.Parameters.AddWithValue("@city", city)
                                cmd.Parameters.AddWithValue("@reg", region)
                                cmd.Parameters.AddWithValue("@zip", zip)
                                cmd.ExecuteNonQuery()
                                newId = cmd.LastInsertedId
                            End Using

                            Using cmd As New MySqlCommand(
                            "UPDATE users SET address_id = @aid WHERE username = @u", con, tx)
                                cmd.Parameters.AddWithValue("@aid", newId)
                                cmd.Parameters.AddWithValue("@u", username)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            Using cmd As New MySqlCommand(
                            "UPDATE address SET address_line_1 = @l1, address_line_2 = @l2, barangay = @bar, " &
                            "city = @city, region = @reg, zip_code = @zip WHERE address_id = @aid", con, tx)
                                cmd.Parameters.AddWithValue("@l1", line1)
                                cmd.Parameters.AddWithValue("@l2", NullIfEmpty(line2))
                                cmd.Parameters.AddWithValue("@bar", barangay)
                                cmd.Parameters.AddWithValue("@city", city)
                                cmd.Parameters.AddWithValue("@reg", region)
                                cmd.Parameters.AddWithValue("@zip", zip)
                                cmd.Parameters.AddWithValue("@aid", addressId)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    End If

                    tx.Commit()
                End Using
            End Using

            ' ---- After a successful save ----
            CurrentStudentName = firstName & " " & lastName

            LockAll()

            Notify("Profile saved.")

        Catch ex As Exception
            Notify("Could not save: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        LoadProfile()
        LockAll()
    End Sub
End Class
