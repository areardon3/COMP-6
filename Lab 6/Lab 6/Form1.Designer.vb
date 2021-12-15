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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cmb0 = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblIntrovert1 = New System.Windows.Forms.Label()
        Me.lblIntrovert2 = New System.Windows.Forms.Label()
        Me.lblIntrovert3 = New System.Windows.Forms.Label()
        Me.lblIntrovert4 = New System.Windows.Forms.Label()
        Me.lblExtrovert1 = New System.Windows.Forms.Label()
        Me.lblExtrovert2 = New System.Windows.Forms.Label()
        Me.lblExtrovert3 = New System.Windows.Forms.Label()
        Me.lblExtrovert4 = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.cmb3 = New System.Windows.Forms.ComboBox()
        Me.cmb4 = New System.Windows.Forms.ComboBox()
        Me.cmb5 = New System.Windows.Forms.ComboBox()
        Me.cmb6 = New System.Windows.Forms.ComboBox()
        Me.cmb7 = New System.Windows.Forms.ComboBox()
        Me.cmb8 = New System.Windows.Forms.ComboBox()
        Me.btnECheckScore = New System.Windows.Forms.Button()
        Me.btnICheckScore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Location = New System.Drawing.Point(28, 26)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(313, 20)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Select what you think your personality type is: "
        '
        'cmb0
        '
        Me.cmb0.FormattingEnabled = True
        Me.cmb0.Items.AddRange(New Object() {"Introvert", "Extrovert"})
        Me.cmb0.Location = New System.Drawing.Point(28, 54)
        Me.cmb0.MaxDropDownItems = 2
        Me.cmb0.Name = "cmb0"
        Me.cmb0.Size = New System.Drawing.Size(151, 28)
        Me.cmb0.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(28, 98)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(182, 102)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 20)
        Me.lblScore.TabIndex = 3
        '
        'lblIntrovert1
        '
        Me.lblIntrovert1.AutoSize = True
        Me.lblIntrovert1.Location = New System.Drawing.Point(28, 183)
        Me.lblIntrovert1.Name = "lblIntrovert1"
        Me.lblIntrovert1.Size = New System.Drawing.Size(227, 20)
        Me.lblIntrovert1.TabIndex = 4
        Me.lblIntrovert1.Text = "Do parties tend to wear you out?"
        Me.lblIntrovert1.Visible = False
        '
        'lblIntrovert2
        '
        Me.lblIntrovert2.AutoSize = True
        Me.lblIntrovert2.Location = New System.Drawing.Point(28, 228)
        Me.lblIntrovert2.Name = "lblIntrovert2"
        Me.lblIntrovert2.Size = New System.Drawing.Size(263, 20)
        Me.lblIntrovert2.TabIndex = 5
        Me.lblIntrovert2.Text = "Do you tend to think before speaking?"
        Me.lblIntrovert2.Visible = False
        '
        'lblIntrovert3
        '
        Me.lblIntrovert3.AutoSize = True
        Me.lblIntrovert3.Location = New System.Drawing.Point(28, 270)
        Me.lblIntrovert3.Name = "lblIntrovert3"
        Me.lblIntrovert3.Size = New System.Drawing.Size(199, 20)
        Me.lblIntrovert3.TabIndex = 6
        Me.lblIntrovert3.Text = "Is quiet time very important?"
        Me.lblIntrovert3.Visible = False
        '
        'lblIntrovert4
        '
        Me.lblIntrovert4.AutoSize = True
        Me.lblIntrovert4.Location = New System.Drawing.Point(28, 310)
        Me.lblIntrovert4.Name = "lblIntrovert4"
        Me.lblIntrovert4.Size = New System.Drawing.Size(269, 20)
        Me.lblIntrovert4.TabIndex = 7
        Me.lblIntrovert4.Text = "Does it bother you to interrupt people?"
        Me.lblIntrovert4.Visible = False
        '
        'lblExtrovert1
        '
        Me.lblExtrovert1.AutoSize = True
        Me.lblExtrovert1.Location = New System.Drawing.Point(452, 183)
        Me.lblExtrovert1.Name = "lblExtrovert1"
        Me.lblExtrovert1.Size = New System.Drawing.Size(238, 20)
        Me.lblExtrovert1.TabIndex = 8
        Me.lblExtrovert1.Text = "After work, are you ready to party?"
        Me.lblExtrovert1.Visible = False
        '
        'lblExtrovert2
        '
        Me.lblExtrovert2.AutoSize = True
        Me.lblExtrovert2.Location = New System.Drawing.Point(452, 228)
        Me.lblExtrovert2.Name = "lblExtrovert2"
        Me.lblExtrovert2.Size = New System.Drawing.Size(284, 20)
        Me.lblExtrovert2.TabIndex = 9
        Me.lblExtrovert2.Text = "Are you eager to talk in social situations? "
        Me.lblExtrovert2.Visible = False
        '
        'lblExtrovert3
        '
        Me.lblExtrovert3.AutoSize = True
        Me.lblExtrovert3.Location = New System.Drawing.Point(452, 270)
        Me.lblExtrovert3.Name = "lblExtrovert3"
        Me.lblExtrovert3.Size = New System.Drawing.Size(206, 20)
        Me.lblExtrovert3.TabIndex = 10
        Me.lblExtrovert3.Text = "Do you like to be by yourself?"
        Me.lblExtrovert3.Visible = False
        '
        'lblExtrovert4
        '
        Me.lblExtrovert4.AutoSize = True
        Me.lblExtrovert4.Location = New System.Drawing.Point(452, 310)
        Me.lblExtrovert4.Name = "lblExtrovert4"
        Me.lblExtrovert4.Size = New System.Drawing.Size(194, 20)
        Me.lblExtrovert4.TabIndex = 11
        Me.lblExtrovert4.Text = "Do you have lots of friends?"
        Me.lblExtrovert4.Visible = False
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb1.Location = New System.Drawing.Point(310, 180)
        Me.cmb1.MaxDropDownItems = 2
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(70, 28)
        Me.cmb1.TabIndex = 12
        Me.cmb1.Visible = False
        '
        'cmb2
        '
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb2.Location = New System.Drawing.Point(310, 225)
        Me.cmb2.MaxDropDownItems = 2
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(70, 28)
        Me.cmb2.TabIndex = 13
        Me.cmb2.Visible = False
        '
        'cmb3
        '
        Me.cmb3.FormattingEnabled = True
        Me.cmb3.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb3.Location = New System.Drawing.Point(310, 267)
        Me.cmb3.MaxDropDownItems = 2
        Me.cmb3.Name = "cmb3"
        Me.cmb3.Size = New System.Drawing.Size(70, 28)
        Me.cmb3.TabIndex = 14
        Me.cmb3.Visible = False
        '
        'cmb4
        '
        Me.cmb4.FormattingEnabled = True
        Me.cmb4.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb4.Location = New System.Drawing.Point(310, 307)
        Me.cmb4.MaxDropDownItems = 2
        Me.cmb4.Name = "cmb4"
        Me.cmb4.Size = New System.Drawing.Size(70, 28)
        Me.cmb4.TabIndex = 15
        Me.cmb4.Visible = False
        '
        'cmb5
        '
        Me.cmb5.FormattingEnabled = True
        Me.cmb5.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb5.Location = New System.Drawing.Point(741, 180)
        Me.cmb5.MaxDropDownItems = 2
        Me.cmb5.Name = "cmb5"
        Me.cmb5.Size = New System.Drawing.Size(70, 28)
        Me.cmb5.TabIndex = 16
        Me.cmb5.Visible = False
        '
        'cmb6
        '
        Me.cmb6.FormattingEnabled = True
        Me.cmb6.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb6.Location = New System.Drawing.Point(742, 225)
        Me.cmb6.MaxDropDownItems = 2
        Me.cmb6.Name = "cmb6"
        Me.cmb6.Size = New System.Drawing.Size(70, 28)
        Me.cmb6.TabIndex = 17
        Me.cmb6.Visible = False
        '
        'cmb7
        '
        Me.cmb7.FormattingEnabled = True
        Me.cmb7.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb7.Location = New System.Drawing.Point(741, 267)
        Me.cmb7.MaxDropDownItems = 2
        Me.cmb7.Name = "cmb7"
        Me.cmb7.Size = New System.Drawing.Size(70, 28)
        Me.cmb7.TabIndex = 18
        Me.cmb7.Visible = False
        '
        'cmb8
        '
        Me.cmb8.FormattingEnabled = True
        Me.cmb8.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb8.Location = New System.Drawing.Point(741, 307)
        Me.cmb8.MaxDropDownItems = 2
        Me.cmb8.Name = "cmb8"
        Me.cmb8.Size = New System.Drawing.Size(70, 28)
        Me.cmb8.TabIndex = 19
        Me.cmb8.Visible = False
        '
        'btnECheckScore
        '
        Me.btnECheckScore.Location = New System.Drawing.Point(452, 358)
        Me.btnECheckScore.Name = "btnECheckScore"
        Me.btnECheckScore.Size = New System.Drawing.Size(122, 29)
        Me.btnECheckScore.TabIndex = 20
        Me.btnECheckScore.Text = "Check Score"
        Me.btnECheckScore.UseVisualStyleBackColor = True
        Me.btnECheckScore.Visible = False
        '
        'btnICheckScore
        '
        Me.btnICheckScore.Location = New System.Drawing.Point(28, 358)
        Me.btnICheckScore.Name = "btnICheckScore"
        Me.btnICheckScore.Size = New System.Drawing.Size(122, 29)
        Me.btnICheckScore.TabIndex = 21
        Me.btnICheckScore.Text = "Check Score"
        Me.btnICheckScore.UseVisualStyleBackColor = True
        Me.btnICheckScore.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(872, 450)
        Me.Controls.Add(Me.btnICheckScore)
        Me.Controls.Add(Me.btnECheckScore)
        Me.Controls.Add(Me.cmb8)
        Me.Controls.Add(Me.cmb7)
        Me.Controls.Add(Me.cmb6)
        Me.Controls.Add(Me.cmb5)
        Me.Controls.Add(Me.cmb4)
        Me.Controls.Add(Me.cmb3)
        Me.Controls.Add(Me.cmb2)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.lblExtrovert4)
        Me.Controls.Add(Me.lblExtrovert3)
        Me.Controls.Add(Me.lblExtrovert2)
        Me.Controls.Add(Me.lblExtrovert1)
        Me.Controls.Add(Me.lblIntrovert4)
        Me.Controls.Add(Me.lblIntrovert3)
        Me.Controls.Add(Me.lblIntrovert2)
        Me.Controls.Add(Me.lblIntrovert1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmb0)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents cmb0 As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblIntrovert1 As Label
    Friend WithEvents lblIntrovert2 As Label
    Friend WithEvents lblIntrovert3 As Label
    Friend WithEvents lblIntrovert4 As Label
    Friend WithEvents lblExtrovert1 As Label
    Friend WithEvents lblExtrovert2 As Label
    Friend WithEvents lblExtrovert3 As Label
    Friend WithEvents lblExtrovert4 As Label
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents cmb3 As ComboBox
    Friend WithEvents cmb4 As ComboBox
    Friend WithEvents cmb5 As ComboBox
    Friend WithEvents cmb6 As ComboBox
    Friend WithEvents cmb7 As ComboBox
    Friend WithEvents cmb8 As ComboBox
    Friend WithEvents btnECheckScore As Button
    Friend WithEvents btnICheckScore As Button
End Class
