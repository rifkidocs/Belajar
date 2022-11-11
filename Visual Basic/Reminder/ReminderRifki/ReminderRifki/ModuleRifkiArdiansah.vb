Module ModuleRifkiArdiansah

    Public Sub ItemCbox1(ByRef combo As ComboBox)
        combo.Items.Add("Text")
        combo.Items.Add("Image")
        combo.Items.Add("Video")
        combo.Items.Add("Audio")
    End Sub

    Public Sub openf(cb As String, gbr As PictureBox, ByRef ax As AxWMPLib.AxWindowsMediaPlayer, rch As RichTextBox, loc As TextBox)
        Dim openfile As New OpenFileDialog
        If cb = "Video" Then
            openfile.Filter = "MP4(*.MP4)|*.MP4"
            If openfile.ShowDialog = DialogResult.OK Then
                loc.Text = openfile.FileName
            End If
        End If
        If cb = "Image" Then
            openfile.Filter = "PNG(*.PNG)|*.PNG|JPG(*.JPG)|*.JPG"
            If openfile.ShowDialog = DialogResult.OK Then
                loc.Text = openfile.FileName
                gbr.ImageLocation = loc.Text
                gbr.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        If cb = "Text" Then
            openfile.Filter = "TXT(*.TXT)|*.TXT"
            If openfile.ShowDialog = DialogResult.OK Then
                loc.Text = openfile.FileName
                rch.Text = My.Computer.FileSystem.ReadAllText(loc.Text)
            End If
        End If
        If cb = "Audio" Then
            openfile.Filter = "MP3(*.MP3)|*.MP3"
            If openfile.ShowDialog = DialogResult.OK Then
                loc.Text = openfile.FileName
            End If
        End If
    End Sub

    Public Sub Alarm(ByRef ax As AxWMPLib.AxWindowsMediaPlayer, loc As TextBox)
        ax.URL = loc.Text
    End Sub

End Module
