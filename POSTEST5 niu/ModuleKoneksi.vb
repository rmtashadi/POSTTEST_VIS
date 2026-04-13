Imports MySql.Data.MySqlClient

Module Koneksi
    Public conn As MySqlConnection

    Public Sub buka()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=koleksi_db")
        conn.Open()
    End Sub
End Module