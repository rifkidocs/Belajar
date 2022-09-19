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
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.LabelOccupation = New System.Windows.Forms.Label()
        Me.BtnNextForm2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.AutoSize = True
        Me.BtnStart.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnStart.Location = New System.Drawing.Point(12, 12)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(151, 62)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Press Here"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.DarkCyan
        Me.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn2.Location = New System.Drawing.Point(12, 95)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(151, 62)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Variable Demonstration"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn3.Location = New System.Drawing.Point(12, 175)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(151, 62)
        Me.Btn3.TabIndex = 3
        Me.Btn3.Text = "Data Types"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'BtnInput
        '
        Me.BtnInput.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnInput.Location = New System.Drawing.Point(12, 260)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(151, 62)
        Me.BtnInput.TabIndex = 4
        Me.BtnInput.Text = "Input Data"
        Me.BtnInput.UseVisualStyleBackColor = False
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(277, 140)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LabelFirstName.TabIndex = 5
        Me.LabelFirstName.Text = "First Name"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(277, 184)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(58, 13)
        Me.LabelLastName.TabIndex = 6
        Me.LabelLastName.Text = "Last Name"
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Location = New System.Drawing.Point(277, 233)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(42, 13)
        Me.LabelGender.TabIndex = 7
        Me.LabelGender.Text = "Gender"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(355, 137)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(156, 20)
        Me.txtFirstName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(355, 181)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(156, 20)
        Me.txtLastName.TabIndex = 9
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(355, 230)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(156, 20)
        Me.txtGender.TabIndex = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(378, 282)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 40)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.Items.AddRange(New Object() {"Programmer", "Doctor", "Student", "Teacher", "Tailor", "Soldier", "Sailor", "Laborer"})
        Me.lstOccupation.Location = New System.Drawing.Point(560, 126)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(133, 147)
        Me.lstOccupation.TabIndex = 12
        '
        'LabelOccupation
        '
        Me.LabelOccupation.AutoSize = True
        Me.LabelOccupation.Location = New System.Drawing.Point(588, 110)
        Me.LabelOccupation.Name = "LabelOccupation"
        Me.LabelOccupation.Size = New System.Drawing.Size(62, 13)
        Me.LabelOccupation.TabIndex = 13
        Me.LabelOccupation.Text = "Occupation"
        '
        'BtnNextForm2
        '
        Me.BtnNextForm2.Location = New System.Drawing.Point(704, 525)
        Me.BtnNextForm2.Name = "BtnNextForm2"
        Me.BtnNextForm2.Size = New System.Drawing.Size(113, 43)
        Me.BtnNextForm2.TabIndex = 14
        Me.BtnNextForm2.Text = "Next"
        Me.BtnNextForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(861, 596)
        Me.Controls.Add(Me.BtnNextForm2)
        Me.Controls.Add(Me.LabelOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.BtnInput)
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
    Public WithEvents BtnInput As Button
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents LabelOccupation As Label
    Friend WithEvents BtnNextForm2 As Button
End Class
