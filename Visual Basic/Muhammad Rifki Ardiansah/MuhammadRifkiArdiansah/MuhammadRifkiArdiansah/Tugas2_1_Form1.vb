Public Class Tugas2_1_Form1
    Sub Konversi()
        a = txtAngka1.Text
        b = txtAngka2.Text
    End Sub

    Private Sub btnJumlah_Click(sender As Object, e As EventArgs) Handles btnJumlah.Click
        Konversi()
        jumlah(a, b, LabelHasil.Text)
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Konversi()
        kali(a, b, LabelHasil.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Konversi()
        bagi(a, b, LabelHasil.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Konversi()
        kurang(a, b, LabelHasil.Text)
    End Sub
End Class