Imports System.Data.Odbc
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim koneksi As OdbcConnection
        Dim db As New OdbcDataAdapter
        Dim dt As New DataSet

        koneksi = New OdbcConnection("DSn=koperasi odbc")
        db = New OdbcDataAdapter("select * from data_koperasi order by No_Transaksi", koneksi)
        db.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.DataMember = dt.Tables(0).ToString()
        koneksi.Close()
    End Sub
End Class
