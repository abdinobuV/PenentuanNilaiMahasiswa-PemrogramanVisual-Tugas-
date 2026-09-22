Public Class Form1
    Inherits Form
    Private Sub Button_Proses_Click(sender As Object, e As EventArgs) Handles Button_Proses.Click
        ' Validasi input nilai
        Dim nilaiAkhir As Decimal
        If Not Decimal.TryParse(TextBox_Nilai.Text, nilaiAkhir) OrElse nilaiAkhir < 0 OrElse nilaiAkhir > 100 Then
            MessageBox.Show("Nilai akhir harus berupa angka antara 0 dan 100.", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi status mahasiswa (ComboBox belum dipilih)
        If ComboBox_Status.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Status Mahasiswa.", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tentukan Predikat (Menggunakan If...ElseIf...Else)
        ' Rentang: 85-100 (A), 75-84.99 (B), 65-74.99 (C), 0-64.99 (E)
        Dim predikat As String = ""
        If nilaiAkhir >= 85 Then
            predikat = "A"
        ElseIf nilaiAkhir >= 75 Then
            predikat = "B"
        ElseIf nilaiAkhir >= 65 Then
            predikat = "C"
        Else
            predikat = "E"
        End If
        Label_Predikat.Text = predikat

        ' Tentukan Keterangan berdasarkan Status (Menggunakan Select Case)
        Dim statusKeterangan As String = ""
        Dim statusPilihan As String = ComboBox_Status.SelectedItem.ToString()

        Select Case statusPilihan
            Case "Aktif"
                ' Mahasiswa sedang aktif mengikuti kegiatan perkuliahan
                statusKeterangan = "Mahasiswa aktif mengikuti perkuliahan."
            Case "Cuti"
                ' Mahasiswa sedang dalam masa cuti akademik
                statusKeterangan = "Mahasiswa sedang dalam masa cuti akademik."
            Case "Non-Aktif"
                ' Mahasiswa tidak aktif tanpa keterangan atau dicutikan
                statusKeterangan = "Mahasiswa berstatus non-aktif pada semester ini."
            Case "Lulus"
                ' Mahasiswa telah menyelesaikan semua kewajiban akademik
                statusKeterangan = "Mahasiswa telah dinyatakan lulus."
            Case Else
                ' Fallback jika ada status yang tidak dikenali
                statusKeterangan = "Status mahasiswa tidak diketahui."
        End Select
        Label_Keterangan.Text = statusKeterangan
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        ' Kosongkan semua TextBox
        TextBox_NIM.Clear()
        TextBox_Nama.Clear()
        TextBox_Nilai.Clear()

        ' Kembalikan ComboBox ke keadaan belum memilih
        ComboBox_Status.SelectedIndex = -1

        ' Kosongkan label hasil
        Label_Predikat.Text = "-"
        Label_Keterangan.Text = "-"

        ' Fokuskan kembali ke NIM
        TextBox_NIM.Focus()
    End Sub

    Private Sub Label_Nilai_Click(sender As Object, e As EventArgs) Handles Label_Nilai.Click

    End Sub
End Class
