Public Class Form2
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim dblNumber1 As Double
        Dim dblNumber2 As Double
        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 - dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 / dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 * dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 ^ dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 \ dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 Mod dblNumber2
        MsgBox(dblResult)

    End Sub
End Class