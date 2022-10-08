Public Class Tugas1_f1
    Private Sub Tugas1_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Image1.Visible = False
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Image1.Visible = True
    End Sub

    Private Sub btnSembunyikan_Click(sender As Object, e As EventArgs) Handles btnSembunyikan.Click
        Image1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tugas1_Form2.Show()
        Tugas1_Form2.LabelNama.Text = Me.LabelNama.Text & " " & Me.txtNama.Text
        Tugas1_Form2.LabelNIM.Text = Me.LabelNIM.Text & " " & Me.txtNIM.Text
        Me.Hide()
    End Sub
End Class