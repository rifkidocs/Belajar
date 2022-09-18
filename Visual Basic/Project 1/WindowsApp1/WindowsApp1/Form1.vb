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

    Private Sub InputData_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        Dim name As String
        name = InputBox("Plese Enter Your Name : ")
        MsgBox("Hello " & name)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        MsgBox("Hello " & stFirstName & " " & stLastName & " you are a " & stGender)

    End Sub
End Class
