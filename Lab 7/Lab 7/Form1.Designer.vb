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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txt15Gal = New System.Windows.Forms.TextBox()
        Me.txt5Gal = New System.Windows.Forms.TextBox()
        Me.txt1Gal = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lbl1Gal = New System.Windows.Forms.Label()
        Me.lbl5Gal = New System.Windows.Forms.Label()
        Me.lbl15Gal = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(307, 146)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(125, 27)
        Me.txtID.TabIndex = 2
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(307, 341)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(125, 27)
        Me.txtCode.TabIndex = 6
        '
        'txt15Gal
        '
        Me.txt15Gal.Location = New System.Drawing.Point(307, 291)
        Me.txt15Gal.Name = "txt15Gal"
        Me.txt15Gal.Size = New System.Drawing.Size(125, 27)
        Me.txt15Gal.TabIndex = 5
        '
        'txt5Gal
        '
        Me.txt5Gal.Location = New System.Drawing.Point(307, 243)
        Me.txt5Gal.Name = "txt5Gal"
        Me.txt5Gal.Size = New System.Drawing.Size(125, 27)
        Me.txt5Gal.TabIndex = 4
        '
        'txt1Gal
        '
        Me.txt1Gal.Location = New System.Drawing.Point(307, 194)
        Me.txt1Gal.Name = "txt1Gal"
        Me.txt1Gal.Size = New System.Drawing.Size(125, 27)
        Me.txt1Gal.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(307, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(125, 27)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(201, 99)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(159, 146)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(94, 20)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "Customer ID:"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl1Gal
        '
        Me.lbl1Gal.AutoSize = True
        Me.lbl1Gal.Location = New System.Drawing.Point(79, 194)
        Me.lbl1Gal.Name = "lbl1Gal"
        Me.lbl1Gal.Size = New System.Drawing.Size(174, 20)
        Me.lbl1Gal.TabIndex = 9
        Me.lbl1Gal.Text = "Number of 1 Gallon Pots:"
        Me.lbl1Gal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl5Gal
        '
        Me.lbl5Gal.AutoSize = True
        Me.lbl5Gal.Location = New System.Drawing.Point(79, 243)
        Me.lbl5Gal.Name = "lbl5Gal"
        Me.lbl5Gal.Size = New System.Drawing.Size(174, 20)
        Me.lbl5Gal.TabIndex = 10
        Me.lbl5Gal.Text = "Number of 5 Gallon Pots:"
        Me.lbl5Gal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl15Gal
        '
        Me.lbl15Gal.AutoSize = True
        Me.lbl15Gal.Location = New System.Drawing.Point(79, 291)
        Me.lbl15Gal.Name = "lbl15Gal"
        Me.lbl15Gal.Size = New System.Drawing.Size(182, 20)
        Me.lbl15Gal.TabIndex = 11
        Me.lbl15Gal.Text = "Number of 15 Gallon Pots:"
        Me.lbl15Gal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(150, 341)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(103, 20)
        Me.lblCode.TabIndex = 12
        Me.lblCode.Text = "Coupon Code:"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(338, 391)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(158, 391)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 29)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(242, 163)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 20)
        Me.lblOutput.TabIndex = 15
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(214, 14)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(277, 59)
        Me.lblHeader.TabIndex = 16
        Me.lblHeader.Text = "Plants n Pots"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lbl15Gal)
        Me.Controls.Add(Me.lbl5Gal)
        Me.Controls.Add(Me.lbl1Gal)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txt1Gal)
        Me.Controls.Add(Me.txt5Gal)
        Me.Controls.Add(Me.txt15Gal)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txt15Gal As TextBox
    Friend WithEvents txt5Gal As TextBox
    Friend WithEvents txt1Gal As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lbl1Gal As Label
    Friend WithEvents lbl5Gal As Label
    Friend WithEvents lbl15Gal As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblHeader As Label
End Class
