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
        Me.components = New System.ComponentModel.Container()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDrivers = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDrivers = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tmrSubmit = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(207, 56)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(383, 54)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Jake's Limo Service"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(263, 149)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name: "
        '
        'lblDrivers
        '
        Me.lblDrivers.AutoSize = True
        Me.lblDrivers.Location = New System.Drawing.Point(204, 186)
        Me.lblDrivers.Name = "lblDrivers"
        Me.lblDrivers.Size = New System.Drawing.Size(115, 20)
        Me.lblDrivers.TabIndex = 2
        Me.lblDrivers.Text = "Drivers Needed:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(211, 227)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(108, 20)
        Me.lblHours.TabIndex = 3
        Me.lblHours.Text = "Hours Needed:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(325, 149)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(111, 27)
        Me.txtName.TabIndex = 4
        '
        'txtDrivers
        '
        Me.txtDrivers.Location = New System.Drawing.Point(325, 186)
        Me.txtDrivers.Name = "txtDrivers"
        Me.txtDrivers.Size = New System.Drawing.Size(111, 27)
        Me.txtDrivers.TabIndex = 5
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(325, 227)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(111, 27)
        Me.txtHours.TabIndex = 6
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(207, 336)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 20)
        Me.lblCost.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(325, 287)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 31)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tmrSubmit
        '
        Me.tmrSubmit.Enabled = True
        Me.tmrSubmit.Interval = 15000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtDrivers)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblDrivers)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDrivers As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDrivers As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents tmrSubmit As Timer
End Class
