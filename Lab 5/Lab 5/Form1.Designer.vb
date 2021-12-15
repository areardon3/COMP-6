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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.lblTicketAnswer = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lstAge = New System.Windows.Forms.ListBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(52, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(52, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(125, 27)
        Me.txtName.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(83, 333)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(222, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(351, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Location = New System.Drawing.Point(52, 166)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(264, 20)
        Me.lblTicket.TabIndex = 5
        Me.lblTicket.Text = "Have you had a ticket in the past year?"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(52, 207)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(30, 27)
        Me.txtTicket.TabIndex = 2
        '
        'lblTicketAnswer
        '
        Me.lblTicketAnswer.AutoSize = True
        Me.lblTicketAnswer.Location = New System.Drawing.Point(88, 210)
        Me.lblTicketAnswer.Name = "lblTicketAnswer"
        Me.lblTicketAnswer.Size = New System.Drawing.Size(60, 20)
        Me.lblTicketAnswer.TabIndex = 7
        Me.lblTicketAnswer.Text = "(Y or N)"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(396, 61)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(39, 20)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age:"
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.ItemHeight = 20
        Me.lstAge.Location = New System.Drawing.Point(396, 84)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(150, 104)
        Me.lstAge.TabIndex = 3
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(83, 394)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(0, 20)
        Me.lblRate.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblTicketAnswer)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTicket As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents lblTicketAnswer As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lstAge As ListBox
    Friend WithEvents lblRate As Label
End Class
