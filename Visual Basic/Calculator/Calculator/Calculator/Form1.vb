Public Class Form1
    Public Declare Auto Function HideCaret Lib "user32" (ByVal hWnd As IntPtr) As Boolean
    Dim num1, num2, ans As Double
    Dim op As String

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        num2 = Convert.ToDouble(txtDisplay.Text)

        If op = "+" Then
            ans = num1 + num2
            txtDisplay.Text = Convert.ToString(ans)
        ElseIf op = "-" Then
            ans = num1 - num2
            txtDisplay.Text = Convert.ToString(ans)
        ElseIf op = "/" Then
            ans = num1 / num2
            txtDisplay.Text = Convert.ToString(ans)
        ElseIf op = "*" Then
            ans = num1 * num2
            txtDisplay.Text = Convert.ToString(ans)
        End If
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        Dim fn, sn As String
        txtDisplay.Text = "0"

        fn = Convert.ToString(num1)
        sn = Convert.ToString(num2)

        fn = ""
        sn = ""
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click
        Dim pm As Double
        pm = Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = Convert.ToString(-1 * pm)
    End Sub

    Private Sub btnBS_Click(sender As Object, e As EventArgs) Handles btnBS.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If

        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If

    End Sub

    Private Sub txtDisplay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisplay.GotFocus, TextBox1.GotFocus

        txtDisplay.Select(txtDisplay.Text.Length, 0)
        HideCaret(txtDisplay.Handle)

    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub NumberClick(sender As Object, e As EventArgs) Handles btnDot.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Dim b As Button = sender

        If (txtDisplay.Text = "0") Then
            txtDisplay.Clear()
            txtDisplay.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not txtDisplay.Text.Contains(".")) Then
                txtDisplay.Text = txtDisplay.Text + b.Text
            End If
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If

    End Sub

    Private Sub ClickOperator(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMulti.Click, btnDivide.Click, bntMinus.Click
        Dim b As Button = sender

        num1 = Convert.ToDouble(txtDisplay.Text)
        op = b.Text
        txtDisplay.Text = ""
    End Sub


End Class
