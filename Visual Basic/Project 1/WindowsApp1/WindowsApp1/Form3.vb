Public Class Form3
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
    End Sub

    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click
        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry.ToUpper = "AUSTRALIA" Then
            MsgBox("G Day Mate")
        ElseIf stCountry.ToUpper = "INDONESIA" Then
            MsgBox("Halo apa kabar ?")
        Else
            MsgBox("Hello There")
        End If

        MsgBox("You entered " & stCountry)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnGreetings
    End Sub
End Class