<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkOlives = New System.Windows.Forms.CheckBox()
        Me.chkPineapple = New System.Windows.Forms.CheckBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(217, 46)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(322, 60)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Superior Pizza"
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(283, 133)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(147, 24)
        Me.chkPepperoni.TabIndex = 1
        Me.chkPepperoni.Text = "Pepperoni ($0.50)"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(283, 165)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(135, 24)
        Me.chkSausage.TabIndex = 2
        Me.chkSausage.Text = "Sausage ($0.50)"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkOlives
        '
        Me.chkOlives.AutoSize = True
        Me.chkOlives.Location = New System.Drawing.Point(283, 195)
        Me.chkOlives.Name = "chkOlives"
        Me.chkOlives.Size = New System.Drawing.Size(159, 24)
        Me.chkOlives.TabIndex = 3
        Me.chkOlives.Text = "Black Olives ($0.50)"
        Me.chkOlives.UseVisualStyleBackColor = True
        '
        'chkPineapple
        '
        Me.chkPineapple.AutoSize = True
        Me.chkPineapple.Location = New System.Drawing.Point(283, 225)
        Me.chkPineapple.Name = "chkPineapple"
        Me.chkPineapple.Size = New System.Drawing.Size(146, 24)
        Me.chkPineapple.TabIndex = 4
        Me.chkPineapple.Text = "Pineapple ($0.50)"
        Me.chkPineapple.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(89, 133)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(154, 24)
        Me.radSmall.TabIndex = 5
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small Pizza ($9.00)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(89, 165)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(180, 24)
        Me.radMedium.TabIndex = 6
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium Pizza ($11.00)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(89, 195)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(162, 24)
        Me.radLarge.TabIndex = 7
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large Pizza ($20.00)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(89, 291)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(283, 291)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 655)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radLarge)
        Me.Controls.Add(Me.radMedium)
        Me.Controls.Add(Me.radSmall)
        Me.Controls.Add(Me.chkPineapple)
        Me.Controls.Add(Me.chkOlives)
        Me.Controls.Add(Me.chkSausage)
        Me.Controls.Add(Me.chkPepperoni)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkOlives As CheckBox
    Friend WithEvents chkPineapple As CheckBox
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblTotal As Label
End Class
