Public Class Form1
    Private Sub txtTampil_Click(sender As Object, e As EventArgs) Handles txtTampil.Click
        Picture1.Visible = True

    End Sub

    Private Sub txtSembunyikan_Click(sender As Object, e As EventArgs) Handles txtSembunyikan.Click
        Picture1.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Picture1.Visible = False
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Form2.labelNama.Text = Me.Label1.Text & " " & Me.txtNama.Text
        Form2.LabelNIM.Text = Me.Label2.Text & " " & Me.txtNim.Text
        Form2.Show()
        Me.Hide()
    End Sub


End Class
