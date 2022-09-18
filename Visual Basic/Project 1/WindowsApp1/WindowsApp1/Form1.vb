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

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim DtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 4
        stColour = "Red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 599.99
        DtDateRegistered = #01/09/2020#

        MsgBox("The car is " & stMake & vbNewLine & stModel &
               vbNewLine & iDoors & vbNewLine & stColour &
               vbNewLine & bTaxed & vbNewLine & iEngineSize &
               vbNewLine & decPrice & vbNewLine & DtDateRegistered)

    End Sub
End Class
