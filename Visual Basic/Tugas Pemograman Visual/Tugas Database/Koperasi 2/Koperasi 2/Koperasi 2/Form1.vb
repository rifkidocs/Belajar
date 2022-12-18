
Public Class Form1
    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x = "select * from nasabah"
        view(DataGridView1, x)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dml("update nasabah set NIK='" + TextBox1.Text + "',nama='" + TextBox2.Text + "',alamat='" + TextBox3.Text + "',tanggal_lahir='" + DateTimePicker1.Text + "' where NIK='" + TextBox1.Text + "'")
        MsgBox("DATA SUDAH DIUPDATE")
        kosong()
        view(DataGridView1, "select * from nasabah")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dml("insert into nasabah(NIK, nama, alamat, tanggal_lahir) values('" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Text + "')")
        MsgBox("DATA SUDAH DITAMBAHKAN")
        kosong()
        view(DataGridView1, "select * from nasabah")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dml("delete from nasabah where NIK='" + TextBox1.Text + "'")
        MsgBox("DATA SUDAH DIHAPUS")
        kosong()
        view(DataGridView1, "select * from nasabah")
    End Sub

End Class
