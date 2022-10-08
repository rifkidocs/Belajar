Module ModuleRifki
    Public a, b As Integer
    Public Sub jumlah(ByVal x As Integer, ByVal y As Integer, ByRef z As String)
        z = x + y
    End Sub
    Public Sub kali(ByVal x As Integer, ByVal y As Integer, ByRef z As String)
        z = x * y
    End Sub
    Public Sub bagi(ByVal x As Integer, ByVal y As Integer, ByRef z As String)
        z = x / y
    End Sub
    Public Sub kurang(ByVal x As Integer, ByVal y As Integer, ByRef z As String)
        z = x - y
    End Sub
End Module
