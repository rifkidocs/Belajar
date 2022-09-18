Public Class Form1
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        MsgBox("Hello World")
        MsgBox("How Are You ?")
        MsgBox("I Hope You Are Well")

        MessageBox.Show("This is another message")
    End Sub


    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim stFirstname As String
        Dim stLastname As String
        stFirstname = "Rifki"
        stLastname = "Ardiansah"

        MsgBox("Hello and Welcome " & stFirstname & " " & stLastname & " I hope you are well")

        stFirstname = "Sri"
        stLastname = "Mulyana"

        MsgBox("Hello and Welcome " & stFirstname & " " & stLastname & " I hope you are well")
    End Sub
End Class
