<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tugas2_1_Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelHasil = New System.Windows.Forms.Label()
        Me.txtAngka1 = New System.Windows.Forms.TextBox()
        Me.txtAngka2 = New System.Windows.Forms.TextBox()
        Me.btnJumlah = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelHasil
        '
        Me.LabelHasil.AutoSize = True
        Me.LabelHasil.Location = New System.Drawing.Point(314, 149)
        Me.LabelHasil.Name = "LabelHasil"
        Me.LabelHasil.Size = New System.Drawing.Size(30, 13)
        Me.LabelHasil.TabIndex = 0
        Me.LabelHasil.Text = "Hasil"
        '
        'txtAngka1
        '
        Me.txtAngka1.Location = New System.Drawing.Point(238, 78)
        Me.txtAngka1.Name = "txtAngka1"
        Me.txtAngka1.Size = New System.Drawing.Size(181, 20)
        Me.txtAngka1.TabIndex = 1
        '
        'txtAngka2
        '
        Me.txtAngka2.Location = New System.Drawing.Point(238, 116)
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.Size = New System.Drawing.Size(181, 20)
        Me.txtAngka2.TabIndex = 2
        '
        'btnJumlah
        '
        Me.btnJumlah.BackColor = System.Drawing.Color.YellowGreen
        Me.btnJumlah.Location = New System.Drawing.Point(132, 189)
        Me.btnJumlah.Name = "btnJumlah"
        Me.btnJumlah.Size = New System.Drawing.Size(69, 38)
        Me.btnJumlah.TabIndex = 3
        Me.btnJumlah.Text = "Jumlah"
        Me.btnJumlah.UseVisualStyleBackColor = False
        '
        'btnKali
        '
        Me.btnKali.BackColor = System.Drawing.Color.SlateBlue
        Me.btnKali.Location = New System.Drawing.Point(238, 189)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(69, 38)
        Me.btnKali.TabIndex = 4
        Me.btnKali.Text = "Kali"
        Me.btnKali.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Honeydew
        Me.Button3.Location = New System.Drawing.Point(442, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 38)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Kurang"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSalmon
        Me.Button4.Location = New System.Drawing.Point(336, 189)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 38)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Bagi"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Tugas2_1_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 323)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnKali)
        Me.Controls.Add(Me.btnJumlah)
        Me.Controls.Add(Me.txtAngka2)
        Me.Controls.Add(Me.txtAngka1)
        Me.Controls.Add(Me.LabelHasil)
        Me.Name = "Tugas2_1_Form1"
        Me.Text = "Tugas2_1_Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHasil As Label
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents btnJumlah As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
