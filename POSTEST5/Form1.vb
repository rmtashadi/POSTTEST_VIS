Imports MySql.Data.MySqlClient

Public Class Form1
    Dim dbConn As MySqlConnection
    Dim dbCmd As MySqlCommand
    Dim dbAdapter As MySqlDataAdapter
    Dim dbTable As DataTable
    Dim connectionString As String = "Server=localhost;Database=koleksi_db;Uid=root;Pwd=;"

    Sub BukaKoneksi()
        Try
            dbConn = New MySqlConnection(connectionString)
            If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub

    Sub KondisiAwal()
        Try
            Call BukaKoneksi()
            dbAdapter = New MySqlDataAdapter("SELECT * FROM barang", dbConn)
            dbTable = New DataTable
            dbAdapter.Fill(dbTable)

            ' Membersihkan kolom agar tidak double
            dgvBarang.Columns.Clear()
            dgvBarang.DataSource = dbTable

            ' Reset inputan
            txtID.Clear()
            txtNamaBarang.Clear()
            txtKondisi.Clear()
            txtTahunBeli.Clear()
            txtKategori.Clear()
            txtKeterangan.Clear()

            txtID.ReadOnly = True
            txtNamaBarang.Focus()
        Catch ex As Exception
            MsgBox("Gagal Load Data: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    ' --- TOMBOL HAPUS DATA TERPILIH ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text = "" Then MsgBox("Pilih data dulu!") : Exit Sub

        If MsgBox("Yakin hapus data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()
                ' Menghapus data satu per satu tidak akan me-reset ID otomatis
                dbCmd = New MySqlCommand("DELETE FROM barang WHERE id=@id", dbConn)
                dbCmd.Parameters.AddWithValue("@id", txtID.Text)
                dbCmd.ExecuteNonQuery()

                MsgBox("Data Terhapus")
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- TOMBOL RESET ID (HAPUS SEMUA & ULANG DARI 1) ---

    Private Sub btnResetID_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim konfirmasi = MsgBox("Apakah ingin menghapus SEMUA data dan mengulang ID dari 1?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo)

        If konfirmasi = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()
                ' TRUNCATE akan menghapus semua isi tabel DAN me-reset Auto Increment ke 1
                dbCmd = New MySqlCommand("TRUNCATE TABLE barang", dbConn)
                dbCmd.ExecuteNonQuery()

                MsgBox("Tabel telah dikosongkan dan ID diulang dari 1!", MsgBoxStyle.Information)
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Gagal Reset ID: " & ex.Message)
            End Try
        Else
            ' Jika pilih No, hanya bersihkan TextBox saja
            Call KondisiAwal()
        End If
    End Sub

    ' --- TOMBOL SIMPAN ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaBarang.Text = "" Then MsgBox("Isi nama barang!") : Exit Sub
        Try
            Call BukaKoneksi()
            Dim query As String = "INSERT INTO barang (nama_barang, kategori, kondisi, tahun_beli, keterangan) VALUES (@nama, @kat, @kon, @thn, @ket)"
            dbCmd = New MySqlCommand(query, dbConn)
            dbCmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text)
            dbCmd.Parameters.AddWithValue("@kat", txtKategori.Text)
            dbCmd.Parameters.AddWithValue("@kon", txtKondisi.Text)
            dbCmd.Parameters.AddWithValue("@thn", txtTahunBeli.Text)
            dbCmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
            dbCmd.ExecuteNonQuery()
            Call KondisiAwal()
        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        End Try
    End Sub

    ' --- KLIK TABEL ---
    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvBarang.Rows(e.RowIndex)
                txtID.Text = row.Cells(0).Value.ToString
                txtNamaBarang.Text = row.Cells(1).Value.ToString
                txtKategori.Text = row.Cells(2).Value.ToString
                txtKondisi.Text = row.Cells(3).Value.ToString
                txtTahunBeli.Text = row.Cells(4).Value.ToString
                txtKeterangan.Text = row.Cells(5).Value.ToString
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' --- TOMBOL UBAH & DETAIL ---
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtID.Text = "" Then Exit Sub
        Try
            Call BukaKoneksi()
            dbCmd = New MySqlCommand("UPDATE barang SET nama_barang=@nama, kategori=@kat, kondisi=@kon, tahun_beli=@thn, keterangan=@ket WHERE id=@id", dbConn)
            dbCmd.Parameters.AddWithValue("@id", txtID.Text)
            dbCmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text)
            dbCmd.Parameters.AddWithValue("@kat", txtKategori.Text)
            dbCmd.Parameters.AddWithValue("@kon", txtKondisi.Text)
            dbCmd.Parameters.AddWithValue("@thn", txtTahunBeli.Text)
            dbCmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
            dbCmd.ExecuteNonQuery()
            Call KondisiAwal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' --- EFEK SAAT TEXTBOX DIPENCET/FOKUS ---
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles _
        txtNamaBarang.Enter, txtKategori.Enter, txtKondisi.Enter,
        txtTahunBeli.Enter, txtKeterangan.Enter

        Dim tb As TextBox = DirectCast(sender, TextBox)
        tb.BackColor = Color.LightCyan
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles _
        txtNamaBarang.Leave, txtKategori.Leave, txtKondisi.Leave,
        txtTahunBeli.Leave, txtKeterangan.Leave


        Dim tb As TextBox = DirectCast(sender, TextBox)
        tb.BackColor = Color.White
    End Sub

    ' --- TOMBOL DETAIL ---
    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click

        If txtID.Text = "" Then
            MsgBox("Pilih data di tabel dulu, baru pencet Detail!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Try
            ' Membuat rangkuman data yang rapi
            Dim detailBarang As String = ""
            detailBarang &= "=== DETAIL KOLEKSI BARANG ===" & vbCrLf
            detailBarang &= "ID Barang    : " & txtID.Text & vbCrLf
            detailBarang &= "Nama Barang  : " & txtNamaBarang.Text & vbCrLf
            detailBarang &= "Kategori     : " & txtKategori.Text & vbCrLf
            detailBarang &= "Kondisi      : " & txtKondisi.Text & vbCrLf
            detailBarang &= "Tahun Beli   : " & txtTahunBeli.Text & vbCrLf
            detailBarang &= "Keterangan   : " & txtKeterangan.Text & vbCrLf
            detailBarang &= "==========================="

            ' Menampilkan dalam kotak pesan (MessageBox)
            MsgBox(detailBarang, MsgBoxStyle.Information, "Informasi Barang Lengkap")
        Catch ex As Exception
            MsgBox("Gagal menampilkan detail: " & ex.Message)
        End Try
    End Sub
End Class