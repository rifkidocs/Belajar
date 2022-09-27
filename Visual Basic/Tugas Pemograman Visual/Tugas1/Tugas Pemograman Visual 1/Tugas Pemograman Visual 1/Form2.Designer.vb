<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.labelNama = New System.Windows.Forms.Label()
        Me.LabelNIM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelNama
        '
        Me.labelNama.AutoSize = True
        Me.labelNama.Location = New System.Drawing.Point(223, 154)
        Me.labelNama.Name = "labelNama"
        Me.labelNama.Size = New System.Drawing.Size(39, 13)
        Me.labelNama.TabIndex = 0
        Me.labelNama.Text = "Label1"
        '
        'LabelNIM
        '
        Me.LabelNIM.AutoSize = True
        Me.LabelNIM.Location = New System.Drawing.Point(223, 215)
        Me.LabelNIM.Name = "LabelNIM"
        Me.LabelNIM.Size = New System.Drawing.Size(39, 13)
        Me.LabelNIM.TabIndex = 1
        Me.LabelNIM.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelNIM)
        Me.Controls.Add(Me.labelNama)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelNama As Label
    Friend WithEvents LabelNIM As Label
End Class
