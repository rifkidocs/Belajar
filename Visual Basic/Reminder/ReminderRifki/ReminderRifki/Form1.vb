Public Class Form1
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Filter = ("MP3(*.MP3)|*.Mp3|MP4(*.MP4)|*.MP4")
        OpenFileDialog1.Title = "Buka Media"
        OpenFileDialog1.FileName = "Nama File"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Format(Now, "hh:mm:ss") = DateTimePicker1.Text Then
            AxWindowsMediaPlayer1.URL = TextBox1.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Enabled = False
        Me.ShowInTaskbar = False
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        ContextMenuStrip1.Enabled = False
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        ContextMenuStrip1.Enabled = True
    End Sub

End Class
