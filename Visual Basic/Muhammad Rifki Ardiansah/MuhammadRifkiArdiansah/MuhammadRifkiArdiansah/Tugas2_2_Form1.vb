Public Class Tugas2_2_Form1
    Sub Konversi()
        a = txtAngka1.Text
        b = txtAngka2.Text
    End Sub
    Private Sub Tugas2_2_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Jumlah")
        ComboBox1.Items.Add("Kali")
        ComboBox1.Items.Add("Bagi")
        ComboBox1.Items.Add("Kurang")
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If ComboBox1.SelectedItem = "Jumlah" Then
            Konversi()
            jumlah(a, b, LabelHasil.Text)
        End If
        If ComboBox1.SelectedItem = "Kali" Then
            Konversi()
            kali(a, b, LabelHasil.Text)
        End If
        If ComboBox1.SelectedItem = "Bagi" Then
            Konversi()
            bagi(a, b, LabelHasil.Text)
        End If
        If ComboBox1.SelectedItem = "Kurang" Then
            Konversi()
            kurang(a, b, LabelHasil.Text)
        End If
    End Sub
End Class