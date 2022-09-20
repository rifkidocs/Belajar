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

    Private Sub btnCheckScore_Click(sender As Object, e As EventArgs) Handles btnCheckScore.Click
        Dim iScore As Integer

        If IsNumeric(txtScore.Text) = True Then
            iScore = txtScore.Text
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not valid score. Enter a number between 0 - 100")
        ElseIf iScore >= 50 Then
            MsgBox("Pass")
            MsgBox("Congrats")
        ElseIf iScore < 50 Then
            MsgBox("Fail")
            MsgBox("Sorry, please try again")
        End If

    End Sub
End Class