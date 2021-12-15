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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.lblBaseTri = New System.Windows.Forms.Label()
        Me.lblHeightTri = New System.Windows.Forms.Label()
        Me.txtBaseTri = New System.Windows.Forms.TextBox()
        Me.txtHeightTri = New System.Windows.Forms.TextBox()
        Me.lblSideSquare = New System.Windows.Forms.Label()
        Me.lblRadiusCircle = New System.Windows.Forms.Label()
        Me.txtSideSquare = New System.Windows.Forms.TextBox()
        Me.txtRadiusCircle = New System.Windows.Forms.TextBox()
        Me.btnCircleCalc = New System.Windows.Forms.Button()
        Me.btnSquareCalc = New System.Windows.Forms.Button()
        Me.btnTriangleCalc = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(257, 101)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(414, 38)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Calculate the Area of a Shape"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnCircle
        '
        Me.btnCircle.Location = New System.Drawing.Point(261, 182)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(111, 40)
        Me.btnCircle.TabIndex = 2
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.Location = New System.Drawing.Point(406, 182)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(111, 40)
        Me.btnSquare.TabIndex = 3
        Me.btnSquare.Text = "Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnTriangle
        '
        Me.btnTriangle.Location = New System.Drawing.Point(549, 182)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(111, 40)
        Me.btnTriangle.TabIndex = 4
        Me.btnTriangle.Text = "Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'lblBaseTri
        '
        Me.lblBaseTri.AutoSize = True
        Me.lblBaseTri.Location = New System.Drawing.Point(549, 240)
        Me.lblBaseTri.Name = "lblBaseTri"
        Me.lblBaseTri.Size = New System.Drawing.Size(43, 20)
        Me.lblBaseTri.TabIndex = 5
        Me.lblBaseTri.Text = "Base:"
        Me.lblBaseTri.Visible = False
        '
        'lblHeightTri
        '
        Me.lblHeightTri.AutoSize = True
        Me.lblHeightTri.Location = New System.Drawing.Point(535, 282)
        Me.lblHeightTri.Name = "lblHeightTri"
        Me.lblHeightTri.Size = New System.Drawing.Size(57, 20)
        Me.lblHeightTri.TabIndex = 6
        Me.lblHeightTri.Text = "Height:"
        Me.lblHeightTri.Visible = False
        '
        'txtBaseTri
        '
        Me.txtBaseTri.Location = New System.Drawing.Point(598, 237)
        Me.txtBaseTri.Name = "txtBaseTri"
        Me.txtBaseTri.Size = New System.Drawing.Size(50, 27)
        Me.txtBaseTri.TabIndex = 7
        Me.txtBaseTri.Visible = False
        '
        'txtHeightTri
        '
        Me.txtHeightTri.Location = New System.Drawing.Point(598, 279)
        Me.txtHeightTri.Name = "txtHeightTri"
        Me.txtHeightTri.Size = New System.Drawing.Size(50, 27)
        Me.txtHeightTri.TabIndex = 8
        Me.txtHeightTri.Visible = False
        '
        'lblSideSquare
        '
        Me.lblSideSquare.AutoSize = True
        Me.lblSideSquare.Location = New System.Drawing.Point(406, 240)
        Me.lblSideSquare.Name = "lblSideSquare"
        Me.lblSideSquare.Size = New System.Drawing.Size(41, 20)
        Me.lblSideSquare.TabIndex = 9
        Me.lblSideSquare.Text = "Side:"
        Me.lblSideSquare.Visible = False
        '
        'lblRadiusCircle
        '
        Me.lblRadiusCircle.AutoSize = True
        Me.lblRadiusCircle.Location = New System.Drawing.Point(261, 240)
        Me.lblRadiusCircle.Name = "lblRadiusCircle"
        Me.lblRadiusCircle.Size = New System.Drawing.Size(56, 20)
        Me.lblRadiusCircle.TabIndex = 10
        Me.lblRadiusCircle.Text = "Radius:"
        Me.lblRadiusCircle.Visible = False
        '
        'txtSideSquare
        '
        Me.txtSideSquare.Location = New System.Drawing.Point(453, 237)
        Me.txtSideSquare.Name = "txtSideSquare"
        Me.txtSideSquare.Size = New System.Drawing.Size(50, 27)
        Me.txtSideSquare.TabIndex = 11
        Me.txtSideSquare.Visible = False
        '
        'txtRadiusCircle
        '
        Me.txtRadiusCircle.Location = New System.Drawing.Point(322, 237)
        Me.txtRadiusCircle.Name = "txtRadiusCircle"
        Me.txtRadiusCircle.Size = New System.Drawing.Size(50, 27)
        Me.txtRadiusCircle.TabIndex = 12
        Me.txtRadiusCircle.Visible = False
        '
        'btnCircleCalc
        '
        Me.btnCircleCalc.Location = New System.Drawing.Point(261, 319)
        Me.btnCircleCalc.Name = "btnCircleCalc"
        Me.btnCircleCalc.Size = New System.Drawing.Size(111, 29)
        Me.btnCircleCalc.TabIndex = 13
        Me.btnCircleCalc.Text = "Calculate"
        Me.btnCircleCalc.UseVisualStyleBackColor = True
        Me.btnCircleCalc.Visible = False
        '
        'btnSquareCalc
        '
        Me.btnSquareCalc.AllowDrop = True
        Me.btnSquareCalc.Location = New System.Drawing.Point(406, 319)
        Me.btnSquareCalc.Name = "btnSquareCalc"
        Me.btnSquareCalc.Size = New System.Drawing.Size(111, 29)
        Me.btnSquareCalc.TabIndex = 14
        Me.btnSquareCalc.Text = "Calculate"
        Me.btnSquareCalc.UseVisualStyleBackColor = True
        Me.btnSquareCalc.Visible = False
        '
        'btnTriangleCalc
        '
        Me.btnTriangleCalc.Location = New System.Drawing.Point(549, 319)
        Me.btnTriangleCalc.Name = "btnTriangleCalc"
        Me.btnTriangleCalc.Size = New System.Drawing.Size(111, 29)
        Me.btnTriangleCalc.TabIndex = 15
        Me.btnTriangleCalc.Text = "Calculate"
        Me.btnTriangleCalc.UseVisualStyleBackColor = True
        Me.btnTriangleCalc.Visible = False
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(33, 372)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 20)
        Me.lblOutput.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnTriangleCalc)
        Me.Controls.Add(Me.btnSquareCalc)
        Me.Controls.Add(Me.btnCircleCalc)
        Me.Controls.Add(Me.txtRadiusCircle)
        Me.Controls.Add(Me.txtSideSquare)
        Me.Controls.Add(Me.lblRadiusCircle)
        Me.Controls.Add(Me.lblSideSquare)
        Me.Controls.Add(Me.txtHeightTri)
        Me.Controls.Add(Me.txtBaseTri)
        Me.Controls.Add(Me.lblHeightTri)
        Me.Controls.Add(Me.lblBaseTri)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnCircle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCircle As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnTriangle As Button
    Friend WithEvents lblBaseTri As Label
    Friend WithEvents lblHeightTri As Label
    Friend WithEvents txtBaseTri As TextBox
    Friend WithEvents txtHeightTri As TextBox
    Friend WithEvents lblSideSquare As Label
    Friend WithEvents lblRadiusCircle As Label
    Friend WithEvents txtSideSquare As TextBox
    Friend WithEvents txtRadiusCircle As TextBox
    Friend WithEvents btnCircleCalc As Button
    Friend WithEvents btnSquareCalc As Button
    Friend WithEvents btnTriangleCalc As Button
    Friend WithEvents lblOutput As Label
End Class
