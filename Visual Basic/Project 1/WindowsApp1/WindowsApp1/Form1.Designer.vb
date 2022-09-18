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
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.AutoSize = True
        Me.BtnStart.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnStart.Location = New System.Drawing.Point(142, 111)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(151, 62)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Press Here"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn2.Location = New System.Drawing.Point(142, 194)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(151, 62)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Variable Demonstration"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn3.Location = New System.Drawing.Point(142, 274)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(151, 62)
        Me.Btn3.TabIndex = 3
        Me.Btn3.Text = "Data Types"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 450)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.BtnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStart As Button
    Public WithEvents Btn2 As Button
    Public WithEvents Btn3 As Button
End Class
