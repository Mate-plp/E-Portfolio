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
        If String.IsNullOrEmpty(CurrentProfessorId) Then Return

        Dim sql As String =
        "SELECT u.username, u.first_name, u.middle_name, u.last_name, " &
        "       f.professor_id, f.position " &
        "FROM faculty f " &
        "INNER JOIN users u ON u.username = f.username " &
        "WHERE f.professor_id = @id " &
        "LIMIT 1"

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", CurrentProfessorId)

                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If Not r.Read() Then Return

                        ' User info
                        tbUsername.Text = Txt(r, "username")
                        tbFN.Text = Txt(r, "first_name")
                        tbMN.Text = Txt(r, "middle_name")
                        tbLN.Text = Txt(r, "last_name")

                        ' Faculty info
                        tbID.Text = Txt(r, "professor_id")
                        tbPosition.Text = Txt(r, "position")
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

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        editInfo(tbPosition)
    End Sub

    Private Sub LockAll()
        For Each tb As TextBox In {tbUsername, tbFN, tbMN, tbLN, tbID, tbPosition,
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
        Dim position As String = tbPosition.Text.Trim()
        Dim oldPass As String = tbOldPass.Text
        Dim newPass As String = tbNewPass.Text

        ' ---- Validate ----
        If username = "" OrElse firstName = "" OrElse lastName = "" Then
            Notify("Username, first name, and last name are required.")
            Return
        End If

        If username.Length > 25 Then
            Notify("Username is too long.")
            Return
        End If

        If middleName.Length > 25 Then
            Notify("Middle Name is too long.")
            Return
        End If

        If firstName.Length > 50 Then
            Notify("First Name is too long.")
            Return
        End If

        If lastName.Length > 50 Then
            Notify("Last Name is too long.")
            Return
        End If

        If position.Length > 20 Then
            Notify("Position can be at most 20 characters.")
            Return
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

        ' ---- Save ----
        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Using tx As MySqlTransaction = con.BeginTransaction()
                    ' Current values for this faculty member
                    Dim oldUsername As String = ""
                    Dim currentPass As String = ""

                    Using cmd As New MySqlCommand(
                    "SELECT u.username, u.password " &
                    "FROM faculty f INNER JOIN users u ON u.username = f.username " &
                    "WHERE f.professor_id = @id", con, tx)
                        cmd.Parameters.AddWithValue("@id", CurrentProfessorId)
                        Using r As MySqlDataReader = cmd.ExecuteReader()
                            If Not r.Read() Then
                                Notify("Could not find your account.")
                                Return
                            End If
                            oldUsername = r.GetString("username")
                            currentPass = r.GetString("password")
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

                    ' faculty (position cannot be NULL, so a blank box saves as "Pending")
                    Using cmd As New MySqlCommand(
                    "UPDATE faculty SET position = @pos WHERE professor_id = @id", con, tx)
                        cmd.Parameters.AddWithValue("@pos", If(position = "", "Pending", position))
                        cmd.Parameters.AddWithValue("@id", CurrentProfessorId)
                        cmd.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            ' ---- After a successful save ----
            CurrentProfessorName = firstName & " " & lastName
            If position = "" Then tbPosition.Text = "Pending"

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
