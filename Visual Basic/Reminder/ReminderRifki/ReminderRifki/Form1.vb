Public Class Form1

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        openf(ComboBox1.Text, PictureBox1, AxWindowsMediaPlayer1, RichTextBox1, TextBox1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "hh:mm:ss")
        If Format(Now, "hh:mm:ss") = DateTimePicker1.Text Then
            Alarm(AxWindowsMediaPlayer1, TextBox1)
            Me.ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemCbox1(ComboBox1)
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub


    Private Sub btnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
