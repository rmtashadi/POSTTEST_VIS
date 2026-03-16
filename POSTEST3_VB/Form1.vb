Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        ' 1. Validasi: Cek jika ada yang kosong
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or picFoto.Image Is Nothing Then
            MsgBox("Mohon isi semua data dan foto!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim jk As String = ""
        If rbLaki.Checked Then
            jk = "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            jk = "Perempuan"
        End If

        Dim daftarHobby As String = ""

        For Each komponen In gbHobby.Controls
            If TypeOf komponen Is CheckBox Then
                Dim chk = DirectCast(komponen, CheckBox)
                If chk.Checked Then
                    daftarHobby &= chk.Text & " "
                End If
            End If
        Next

        Form2.lblNama.Text = txtNama.Text
        Form2.lblUmur.Text = txtUmur.Text
        Form2.lblTL.Text = dtpTanggal.Value.ToShortDateString()
        Form2.lblNoTelp.Text = txtNoTelp.Text
        Form2.lblAlamat.Text = txtAlamat.Text
        Form2.lblJK.Text = jk
        Form2.lblHobby.Text = daftarHobby
        Form2.picFotoHasil.Image = picFoto.Image

        Form2.Show()
    End Sub
End Class