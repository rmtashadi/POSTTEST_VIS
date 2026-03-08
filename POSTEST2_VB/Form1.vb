Public Class Form1

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        TambahData(txtJudulTambah.Text, cboGenre.Text)

        lstBuku.Items.Add(txtJudulTambah.Text & " (" & cboGenre.Text & ")")

        txtJudulTambah.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim teksCari As String

        teksCari = txtJudulHapus.Text & " (" & cboGenre.Text & ")"

        Dim index As Integer
        index = CariBuku(teksCari)

        If index <> -1 Then

            lstBuku.Items.RemoveAt(index)

        Else

            MessageBox.Show("Buku tidak ditemukan")

        End If

        txtJudulHapus.Clear()

    End Sub

End Class