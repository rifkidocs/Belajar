<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn1.Location = New System.Drawing.Point(122, 55)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(124, 31)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Tugas 1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Coral
        Me.Button2.Location = New System.Drawing.Point(322, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Tugas 2.1"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FloralWhite
        Me.Button3.Location = New System.Drawing.Point(530, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Tugas 2.2"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "FormUtama"
        Me.Text = "Muhammad Rifki Ardiansah"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
