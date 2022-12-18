Public Class Form3
    Sub kosong()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x = "select * from transaksi"
        view(DataGridView1, x)

        combo("select * from petugas", ComboBox1, "id_petugas", "nama")
        combo("select * from nasabah", ComboBox2, "NIK", "nama")
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            TextBox2.Text = ComboBox1.SelectedValue
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            TextBox3.Text = ComboBox2.SelectedValue
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dml("update transaksi set id_petugas='" + ComboBox1.Text + "',nik='" + ComboBox2.Text + "',barang='" + TextBox4.Text + "',harga='" + TextBox5.Text + "',tanggal='" + DateTimePicker1.Text + "' where no_transaksi='" + TextBox1.Text + "'")
        MsgBox("DATA SUDAH DIUPDATE")
        view(DataGridView1, "select * from transaksi")
        kosong()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dml("insert into transaksi(no_transaksi,id_petugas,nama_petugas,NIK,nama_nasabah,barang,harga,tanggal) values('" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox2.Text + "','" + ComboBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DateTimePicker1.Text + "')")
        MsgBox("DATA SUDAH DITAMBAHKAN")
        view(DataGridView1, "select * from transaksi")
        kosong()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dml("delete from transaksi where no_transaksi=('" + TextBox1.Text + "')")
        MsgBox("DATA SUDAH DIHAPUS")
        view(DataGridView1, "select * from transaksi")
        kosong()
    End Sub

End Class