<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTampil = New System.Windows.Forms.Button()
        Me.txtSembunyikan = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTampil
        '
        Me.txtTampil.Location = New System.Drawing.Point(40, 51)
        Me.txtTampil.Name = "txtTampil"
        Me.txtTampil.Size = New System.Drawing.Size(85, 33)
        Me.txtTampil.TabIndex = 0
        Me.txtTampil.Text = "Tampil"
        Me.txtTampil.UseVisualStyleBackColor = True
        '
        'txtSembunyikan
        '
        Me.txtSembunyikan.Location = New System.Drawing.Point(40, 125)
        Me.txtSembunyikan.Name = "txtSembunyikan"
        Me.txtSembunyikan.Size = New System.Drawing.Size(85, 34)
        Me.txtSembunyikan.TabIndex = 1
        Me.txtSembunyikan.Text = "Sembunyikan"
        Me.txtSembunyikan.UseVisualStyleBackColor = True
        '
        'Picture1
        '
        Me.Picture1.Image = Global.Tugas_Pemograman_Visual_1.My.Resources.Resources.Heripoter
        Me.Picture1.Location = New System.Drawing.Point(145, 26)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(248, 150)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 2
        Me.Picture1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIM"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(213, 283)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(171, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(213, 322)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(171, 20)
        Me.txtNim.TabIndex = 6
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(411, 301)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(71, 24)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Kirim"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.txtSembunyikan)
        Me.Controls.Add(Me.txtTampil)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTampil As Button
    Friend WithEvents txtSembunyikan As Button
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnSend As Button
End Class
