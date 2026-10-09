Imports MySql.Data.MySqlClient
Module Database
    Dim con As New MySqlConnection("server=localhost; user=root; database=e_portfolio")
    Dim da As New MySqlDataAdapter
    Dim cmd As New MySqlCommand
End Module
