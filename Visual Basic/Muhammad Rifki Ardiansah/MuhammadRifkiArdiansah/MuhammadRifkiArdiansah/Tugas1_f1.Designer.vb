<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas1_f1
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
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.btnSembunyikan = New System.Windows.Forms.Button()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelNIM = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTampil
        '
        Me.btnTampil.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnTampil.Location = New System.Drawing.Point(43, 74)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(93, 34)
        Me.btnTampil.TabIndex = 0
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = False
        '
        'btnSembunyikan
        '
        Me.btnSembunyikan.BackColor = System.Drawing.Color.Thistle
        Me.btnSembunyikan.Location = New System.Drawing.Point(43, 135)
        Me.btnSembunyikan.Name = "btnSembunyikan"
        Me.btnSembunyikan.Size = New System.Drawing.Size(93, 34)
        Me.btnSembunyikan.TabIndex = 1
        Me.btnSembunyikan.Text = "Sembunyikan"
        Me.btnSembunyikan.UseVisualStyleBackColor = False
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(40, 264)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(41, 13)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Nama :"
        '
        'LabelNIM
        '
        Me.LabelNIM.AutoSize = True
        Me.LabelNIM.Location = New System.Drawing.Point(48, 304)
        Me.LabelNIM.Name = "LabelNIM"
        Me.LabelNIM.Size = New System.Drawing.Size(33, 13)
        Me.LabelNIM.TabIndex = 4
        Me.LabelNIM.Text = "NIM :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(87, 261)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(149, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(87, 301)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(149, 20)
        Me.txtNIM.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.Location = New System.Drawing.Point(283, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Kirim"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Image1
        '
        Me.Image1.Image = Global.MuhammadRifkiArdiansah.My.Resources.Resources.Rifki
        Me.Image1.Location = New System.Drawing.Point(142, 22)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(288, 187)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image1.TabIndex = 2
        Me.Image1.TabStop = False
        '
        'Tugas1_f1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 373)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.LabelNIM)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.btnSembunyikan)
        Me.Controls.Add(Me.btnTampil)
        Me.Name = "Tugas1_f1"
        Me.Text = "Tugas 1 Form 1"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents btnSembunyikan As Button
    Friend WithEvents Image1 As PictureBox
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelNIM As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents Button1 As Button
End Class
