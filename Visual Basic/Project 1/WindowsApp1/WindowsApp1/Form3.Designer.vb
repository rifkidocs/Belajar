<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.LabelCountry = New System.Windows.Forms.Label()
        Me.btnGreetings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(366, 163)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(136, 20)
        Me.txtCountry.TabIndex = 0
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Location = New System.Drawing.Point(297, 166)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(43, 13)
        Me.LabelCountry.TabIndex = 1
        Me.LabelCountry.Text = "Country"
        '
        'btnGreetings
        '
        Me.btnGreetings.Location = New System.Drawing.Point(385, 213)
        Me.btnGreetings.Name = "btnGreetings"
        Me.btnGreetings.Size = New System.Drawing.Size(96, 43)
        Me.btnGreetings.TabIndex = 2
        Me.btnGreetings.Text = "Greetings"
        Me.btnGreetings.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGreetings)
        Me.Controls.Add(Me.LabelCountry)
        Me.Controls.Add(Me.txtCountry)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCountry As TextBox
    Friend WithEvents LabelCountry As Label
    Friend WithEvents btnGreetings As Button
End Class
