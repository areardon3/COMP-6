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
        Me.btnMult = New System.Windows.Forms.Button()
        Me.lblAddOutput = New System.Windows.Forms.Label()
        Me.btnName = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(79, 74)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(151, 29)
        Me.btnMult.TabIndex = 0
        Me.btnMult.Text = "Multiply Numbers"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'lblAddOutput
        '
        Me.lblAddOutput.AutoSize = True
        Me.lblAddOutput.Location = New System.Drawing.Point(256, 78)
        Me.lblAddOutput.Name = "lblAddOutput"
        Me.lblAddOutput.Size = New System.Drawing.Size(0, 20)
        Me.lblAddOutput.TabIndex = 1
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(79, 137)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(151, 29)
        Me.btnName.TabIndex = 2
        Me.btnName.Text = "Reformat Names"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(256, 138)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(125, 27)
        Me.txtName.TabIndex = 3
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 20
        Me.lstNames.Items.AddRange(New Object() {"John Doe", "Jane Apple", "Bart Scott", "Pam Johnson"})
        Me.lstNames.Location = New System.Drawing.Point(256, 202)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(125, 184)
        Me.lstNames.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(79, 202)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(151, 29)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search for Worker"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.lblAddOutput)
        Me.Controls.Add(Me.btnMult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMult As Button
    Friend WithEvents lblAddOutput As Label
    Friend WithEvents btnName As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lstNames As ListBox
    Friend WithEvents btnSearch As Button
End Class
