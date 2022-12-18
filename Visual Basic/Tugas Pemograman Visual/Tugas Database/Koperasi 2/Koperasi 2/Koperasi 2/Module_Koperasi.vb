Imports System.Data.Odbc
Module Module_Koperasi
    Public koneksi As OdbcConnection
    Public db As New OdbcDataAdapter
    Public tb As DataSet
    Public Sub hubung()
        koneksi = New OdbcConnection("dsn=koperasi")
        koneksi.Open()
    End Sub

    Public Sub view(ByVal a As DataGridView, ByVal b As String)
        hubung()
        db = New OdbcDataAdapter(b, koneksi)
        tb = New DataSet
        db.Fill(tb)
        a.DataSource = tb
        a.DataMember = tb.Tables(0).ToString()
        koneksi.Close()
    End Sub

    Public Sub dml(ByVal a As String)
        hubung()
        db = New OdbcDataAdapter(a, koneksi)
        tb = New DataSet
        db.Fill(tb)
    End Sub

    Public Sub combo(ByVal a As String, ByVal b As ComboBox, ByVal c As String, ByVal d As String)

        hubung()
        db = New OdbcDataAdapter(a, koneksi)
        tb = New DataSet
        db.Fill(tb)
        b.DataSource = tb.Tables(0)
        b.DisplayMember = c
        b.ValueMember = d
        b.SelectedValue = d
    End Sub


End Module
