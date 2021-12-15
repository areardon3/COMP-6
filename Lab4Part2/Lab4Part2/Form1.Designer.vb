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
        Me.grpBurger = New System.Windows.Forms.GroupBox()
        Me.radSecret = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpDrink = New System.Windows.Forms.GroupBox()
        Me.radShake = New System.Windows.Forms.RadioButton()
        Me.radSoda = New System.Windows.Forms.RadioButton()
        Me.chkTakeOut = New System.Windows.Forms.CheckBox()
        Me.chkDonation = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpBurger.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrink.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(58, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(224, 54)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Big Burger"
        '
        'grpBurger
        '
        Me.grpBurger.Controls.Add(Me.radSecret)
        Me.grpBurger.Controls.Add(Me.radCheese)
        Me.grpBurger.Controls.Add(Me.radRegular)
        Me.grpBurger.Location = New System.Drawing.Point(58, 76)
        Me.grpBurger.Name = "grpBurger"
        Me.grpBurger.Size = New System.Drawing.Size(212, 201)
        Me.grpBurger.TabIndex = 1
        Me.grpBurger.TabStop = False
        Me.grpBurger.Text = "Burger"
        '
        'radSecret
        '
        Me.radSecret.AutoSize = True
        Me.radSecret.Location = New System.Drawing.Point(7, 136)
        Me.radSecret.Name = "radSecret"
        Me.radSecret.Size = New System.Drawing.Size(168, 24)
        Me.radSecret.TabIndex = 2
        Me.radSecret.Text = "Secret Burger ($8.00)"
        Me.radSecret.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Location = New System.Drawing.Point(7, 88)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(174, 24)
        Me.radCheese.TabIndex = 1
        Me.radCheese.Text = "Cheese Burger ($4.00)"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Checked = True
        Me.radRegular.Location = New System.Drawing.Point(7, 38)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(130, 24)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular ($3.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.Controls.Add(Me.radLarge)
        Me.grpFries.Controls.Add(Me.radSmall)
        Me.grpFries.Location = New System.Drawing.Point(299, 76)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(212, 201)
        Me.grpFries.TabIndex = 2
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "Fries"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(7, 88)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(116, 24)
        Me.radLarge.TabIndex = 1
        Me.radLarge.Text = "Large ($2.50)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(6, 38)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(116, 24)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small ($1.50)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpDrink
        '
        Me.grpDrink.Controls.Add(Me.radShake)
        Me.grpDrink.Controls.Add(Me.radSoda)
        Me.grpDrink.Location = New System.Drawing.Point(537, 76)
        Me.grpDrink.Name = "grpDrink"
        Me.grpDrink.Size = New System.Drawing.Size(212, 201)
        Me.grpDrink.TabIndex = 3
        Me.grpDrink.TabStop = False
        Me.grpDrink.Text = "Drink"
        '
        'radShake
        '
        Me.radShake.AutoSize = True
        Me.radShake.Location = New System.Drawing.Point(6, 88)
        Me.radShake.Name = "radShake"
        Me.radShake.Size = New System.Drawing.Size(118, 24)
        Me.radShake.TabIndex = 3
        Me.radShake.Text = "Shake ($2.00)"
        Me.radShake.UseVisualStyleBackColor = True
        '
        'radSoda
        '
        Me.radSoda.AutoSize = True
        Me.radSoda.Checked = True
        Me.radSoda.Location = New System.Drawing.Point(6, 38)
        Me.radSoda.Name = "radSoda"
        Me.radSoda.Size = New System.Drawing.Size(113, 24)
        Me.radSoda.TabIndex = 2
        Me.radSoda.TabStop = True
        Me.radSoda.Text = "Soda ($1.00)"
        Me.radSoda.UseVisualStyleBackColor = True
        '
        'chkTakeOut
        '
        Me.chkTakeOut.AutoSize = True
        Me.chkTakeOut.Location = New System.Drawing.Point(65, 283)
        Me.chkTakeOut.Name = "chkTakeOut"
        Me.chkTakeOut.Size = New System.Drawing.Size(95, 24)
        Me.chkTakeOut.TabIndex = 4
        Me.chkTakeOut.Text = "Take Out?"
        Me.chkTakeOut.UseVisualStyleBackColor = True
        '
        'chkDonation
        '
        Me.chkDonation.AutoSize = True
        Me.chkDonation.Location = New System.Drawing.Point(65, 325)
        Me.chkDonation.Name = "chkDonation"
        Me.chkDonation.Size = New System.Drawing.Size(320, 24)
        Me.chkDonation.TabIndex = 5
        Me.chkDonation.Text = "Make a $1.00 donation to starving children?"
        Me.chkDonation.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(62, 365)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 6
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(537, 306)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(151, 29)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseMnemonic = False
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.chkDonation)
        Me.Controls.Add(Me.chkTakeOut)
        Me.Controls.Add(Me.grpDrink)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.grpBurger)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpBurger.ResumeLayout(False)
        Me.grpBurger.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrink.ResumeLayout(False)
        Me.grpDrink.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents grpBurger As GroupBox
    Friend WithEvents radSecret As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents grpFries As GroupBox
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpDrink As GroupBox
    Friend WithEvents radSoda As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radShake As RadioButton
    Friend WithEvents chkTakeOut As CheckBox
    Friend WithEvents chkDonation As CheckBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnSubmit As Button
End Class
