Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahsemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipInput As Double

        If Double.TryParse(txtIPS.Text, ipInput) Then
            totalIP += ipInput
            jumlahsemester += 1
            Dim ipk As Double = totalIP / jumlahsemester

            txtIPK.Text = ipk.ToString("N2")
            UpdatePredikat(ipk)

            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Masukkan nilai IP yang valid")
        End If
    End Sub

    Private Sub UpdatePredikat(nilai As Double)
        If nilai >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        ElseIf nilai >= 2.76 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf nilai >= 2.0 Then
            lblPredikat.Text = "Cukup"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahsemester = 0
        txtIPS.Clear()
        txtIPK.Text = "0,00"
        lblPredikat.Text = "-"
    End Sub
End Class
