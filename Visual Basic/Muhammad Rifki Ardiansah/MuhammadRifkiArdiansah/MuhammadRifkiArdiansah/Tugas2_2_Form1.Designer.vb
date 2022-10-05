<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas2_2_Form1
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
        Me.txtAngka2 = New System.Windows.Forms.TextBox()
        Me.txtAngka1 = New System.Windows.Forms.TextBox()
        Me.LabelHasil = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAngka2
        '
        Me.txtAngka2.Location = New System.Drawing.Point(168, 151)
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.Size = New System.Drawing.Size(181, 20)
        Me.txtAngka2.TabIndex = 5
        '
        'txtAngka1
        '
        Me.txtAngka1.Location = New System.Drawing.Point(168, 113)
        Me.txtAngka1.Name = "txtAngka1"
        Me.txtAngka1.Size = New System.Drawing.Size(181, 20)
        Me.txtAngka1.TabIndex = 4
        '
        'LabelHasil
        '
        Me.LabelHasil.AutoSize = True
        Me.LabelHasil.Location = New System.Drawing.Point(245, 189)
        Me.LabelHasil.Name = "LabelHasil"
        Me.LabelHasil.Size = New System.Drawing.Size(30, 13)
        Me.LabelHasil.TabIndex = 3
        Me.LabelHasil.Text = "Hasil"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(375, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.LightCyan
        Me.btnHitung.Location = New System.Drawing.Point(222, 220)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 31)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'Tugas2_2_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 333)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtAngka2)
        Me.Controls.Add(Me.txtAngka1)
        Me.Controls.Add(Me.LabelHasil)
        Me.Name = "Tugas2_2_Form1"
        Me.Text = "Tugas2_2_Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents LabelHasil As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnHitung As Button
End Class
