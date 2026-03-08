Module ModuleBuku

    Public buku(50) As String
    Public jumlah As Integer = 0

    'Procedure tambah buku
    Public Sub TambahData(judul As String, genre As String)

        buku(jumlah) = judul & " (" & genre & ")"
        jumlah = jumlah + 1

    End Sub

    'Function cari buku
    Public Function CariBuku(teks As String) As Integer

        For i As Integer = 0 To jumlah - 1

            If buku(i) = teks Then
                Return i
            End If

        Next

        Return -1

    End Function

End Module