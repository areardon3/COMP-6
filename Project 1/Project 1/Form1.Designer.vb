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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.radCastles = New System.Windows.Forms.RadioButton()
        Me.radRoses = New System.Windows.Forms.RadioButton()
        Me.radWillow = New System.Windows.Forms.RadioButton()
        Me.grp2 = New System.Windows.Forms.GroupBox()
        Me.chkCastlesTeapot = New System.Windows.Forms.CheckBox()
        Me.chkCastlesCreamer = New System.Windows.Forms.CheckBox()
        Me.chkCastlesSugarBowl = New System.Windows.Forms.CheckBox()
        Me.chkCastlesSoupBowls = New System.Windows.Forms.CheckBox()
        Me.chkCastlesServingBowl = New System.Windows.Forms.CheckBox()
        Me.chkCastlesPlatter = New System.Windows.Forms.CheckBox()
        Me.chkRosesTeapot = New System.Windows.Forms.CheckBox()
        Me.chkRosesCreamer = New System.Windows.Forms.CheckBox()
        Me.chkRosesSugarBowl = New System.Windows.Forms.CheckBox()
        Me.chkRosesSoupBowls = New System.Windows.Forms.CheckBox()
        Me.chkRosesServingBowl = New System.Windows.Forms.CheckBox()
        Me.chkRosesPlatter = New System.Windows.Forms.CheckBox()
        Me.chkWillowTeapot = New System.Windows.Forms.CheckBox()
        Me.chkWillowCreamer = New System.Windows.Forms.CheckBox()
        Me.chkWillowSugarBowl = New System.Windows.Forms.CheckBox()
        Me.chkWillowServingBowl = New System.Windows.Forms.CheckBox()
        Me.chkWillowSoupBowls = New System.Windows.Forms.CheckBox()
        Me.chkWillowPlatter = New System.Windows.Forms.CheckBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.pboxWillows = New System.Windows.Forms.PictureBox()
        Me.pboxCastles = New System.Windows.Forms.PictureBox()
        Me.pboxRoses = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.grp1.SuspendLayout()
        Me.grp2.SuspendLayout()
        CType(Me.pboxWillows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxCastles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxRoses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(251, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(253, 41)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "China Collections"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(70, 529)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(186, 529)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 529)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.lblWarning)
        Me.grp1.Controls.Add(Me.radCastles)
        Me.grp1.Controls.Add(Me.radRoses)
        Me.grp1.Controls.Add(Me.radWillow)
        Me.grp1.Location = New System.Drawing.Point(4, 53)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(336, 217)
        Me.grp1.TabIndex = 7
        Me.grp1.TabStop = False
        Me.grp1.Text = "Select China Pattern"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(16, 181)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(187, 20)
        Me.lblWarning.TabIndex = 3
        Me.lblWarning.Text = "Prices are per place setting"
        '
        'radCastles
        '
        Me.radCastles.AutoSize = True
        Me.radCastles.Location = New System.Drawing.Point(16, 96)
        Me.radCastles.Name = "radCastles"
        Me.radCastles.Size = New System.Drawing.Size(322, 24)
        Me.radCastles.TabIndex = 2
        Me.radCastles.TabStop = True
        Me.radCastles.Text = "Johnson Brothers Old British Castles ($19.99)"
        Me.radCastles.UseVisualStyleBackColor = True
        '
        'radRoses
        '
        Me.radRoses.AutoSize = True
        Me.radRoses.Location = New System.Drawing.Point(16, 67)
        Me.radRoses.Name = "radRoses"
        Me.radRoses.Size = New System.Drawing.Size(294, 24)
        Me.radRoses.TabIndex = 1
        Me.radRoses.TabStop = True
        Me.radRoses.Text = "Royal Albert Old Country Roses ($39.95)"
        Me.radRoses.UseVisualStyleBackColor = True
        '
        'radWillow
        '
        Me.radWillow.AutoSize = True
        Me.radWillow.Location = New System.Drawing.Point(16, 36)
        Me.radWillow.Name = "radWillow"
        Me.radWillow.Size = New System.Drawing.Size(259, 24)
        Me.radWillow.TabIndex = 0
        Me.radWillow.TabStop = True
        Me.radWillow.Text = "Royal Wessex Blue Willow ($15.00)"
        Me.radWillow.UseVisualStyleBackColor = True
        '
        'grp2
        '
        Me.grp2.Controls.Add(Me.chkCastlesTeapot)
        Me.grp2.Controls.Add(Me.chkCastlesCreamer)
        Me.grp2.Controls.Add(Me.chkCastlesSugarBowl)
        Me.grp2.Controls.Add(Me.chkCastlesSoupBowls)
        Me.grp2.Controls.Add(Me.chkCastlesServingBowl)
        Me.grp2.Controls.Add(Me.chkCastlesPlatter)
        Me.grp2.Controls.Add(Me.chkRosesTeapot)
        Me.grp2.Controls.Add(Me.chkRosesCreamer)
        Me.grp2.Controls.Add(Me.chkRosesSugarBowl)
        Me.grp2.Controls.Add(Me.chkRosesSoupBowls)
        Me.grp2.Controls.Add(Me.chkRosesServingBowl)
        Me.grp2.Controls.Add(Me.chkRosesPlatter)
        Me.grp2.Controls.Add(Me.chkWillowTeapot)
        Me.grp2.Controls.Add(Me.chkWillowCreamer)
        Me.grp2.Controls.Add(Me.chkWillowSugarBowl)
        Me.grp2.Controls.Add(Me.chkWillowServingBowl)
        Me.grp2.Controls.Add(Me.chkWillowSoupBowls)
        Me.grp2.Controls.Add(Me.chkWillowPlatter)
        Me.grp2.Location = New System.Drawing.Point(484, 53)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(277, 217)
        Me.grp2.TabIndex = 8
        Me.grp2.TabStop = False
        Me.grp2.Text = "Additional Pieces"
        '
        'chkCastlesTeapot
        '
        Me.chkCastlesTeapot.AutoSize = True
        Me.chkCastlesTeapot.Location = New System.Drawing.Point(12, 187)
        Me.chkCastlesTeapot.Name = "chkCastlesTeapot"
        Me.chkCastlesTeapot.Size = New System.Drawing.Size(142, 24)
        Me.chkCastlesTeapot.TabIndex = 17
        Me.chkCastlesTeapot.Text = "Teapot ($155.00)"
        Me.chkCastlesTeapot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkCastlesTeapot.UseVisualStyleBackColor = True
        Me.chkCastlesTeapot.Visible = False
        '
        'chkCastlesCreamer
        '
        Me.chkCastlesCreamer.AutoSize = True
        Me.chkCastlesCreamer.Location = New System.Drawing.Point(12, 160)
        Me.chkCastlesCreamer.Name = "chkCastlesCreamer"
        Me.chkCastlesCreamer.Size = New System.Drawing.Size(144, 24)
        Me.chkCastlesCreamer.TabIndex = 16
        Me.chkCastlesCreamer.Text = "Creamer ($30.00)"
        Me.chkCastlesCreamer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkCastlesCreamer.UseVisualStyleBackColor = True
        Me.chkCastlesCreamer.Visible = False
        '
        'chkCastlesSugarBowl
        '
        Me.chkCastlesSugarBowl.AutoSize = True
        Me.chkCastlesSugarBowl.Location = New System.Drawing.Point(12, 129)
        Me.chkCastlesSugarBowl.Name = "chkCastlesSugarBowl"
        Me.chkCastlesSugarBowl.Size = New System.Drawing.Size(163, 24)
        Me.chkCastlesSugarBowl.TabIndex = 15
        Me.chkCastlesSugarBowl.Text = "Sugar Bowl ($40.00)"
        Me.chkCastlesSugarBowl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkCastlesSugarBowl.UseVisualStyleBackColor = True
        Me.chkCastlesSugarBowl.Visible = False
        '
        'chkCastlesSoupBowls
        '
        Me.chkCastlesSoupBowls.AutoSize = True
        Me.chkCastlesSoupBowls.Location = New System.Drawing.Point(12, 99)
        Me.chkCastlesSoupBowls.Name = "chkCastlesSoupBowls"
        Me.chkCastlesSoupBowls.Size = New System.Drawing.Size(220, 24)
        Me.chkCastlesSoupBowls.TabIndex = 14
        Me.chkCastlesSoupBowls.Text = "Set of 8 Soup Bowls ($90.00)"
        Me.chkCastlesSoupBowls.UseVisualStyleBackColor = True
        Me.chkCastlesSoupBowls.Visible = False
        '
        'chkCastlesServingBowl
        '
        Me.chkCastlesServingBowl.AutoSize = True
        Me.chkCastlesServingBowl.Location = New System.Drawing.Point(12, 68)
        Me.chkCastlesServingBowl.Name = "chkCastlesServingBowl"
        Me.chkCastlesServingBowl.Size = New System.Drawing.Size(174, 24)
        Me.chkCastlesServingBowl.TabIndex = 13
        Me.chkCastlesServingBowl.Text = "Serving Bowl ($25.00)"
        Me.chkCastlesServingBowl.UseVisualStyleBackColor = True
        Me.chkCastlesServingBowl.Visible = False
        '
        'chkCastlesPlatter
        '
        Me.chkCastlesPlatter.AutoSize = True
        Me.chkCastlesPlatter.Location = New System.Drawing.Point(12, 37)
        Me.chkCastlesPlatter.Name = "chkCastlesPlatter"
        Me.chkCastlesPlatter.Size = New System.Drawing.Size(157, 24)
        Me.chkCastlesPlatter.TabIndex = 12
        Me.chkCastlesPlatter.Text = "11"" Platter ($35.00)"
        Me.chkCastlesPlatter.UseVisualStyleBackColor = True
        Me.chkCastlesPlatter.Visible = False
        '
        'chkRosesTeapot
        '
        Me.chkRosesTeapot.AutoSize = True
        Me.chkRosesTeapot.Location = New System.Drawing.Point(12, 187)
        Me.chkRosesTeapot.Name = "chkRosesTeapot"
        Me.chkRosesTeapot.Size = New System.Drawing.Size(142, 24)
        Me.chkRosesTeapot.TabIndex = 11
        Me.chkRosesTeapot.Text = "Teapot ($170.00)"
        Me.chkRosesTeapot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkRosesTeapot.UseVisualStyleBackColor = True
        Me.chkRosesTeapot.Visible = False
        '
        'chkRosesCreamer
        '
        Me.chkRosesCreamer.AutoSize = True
        Me.chkRosesCreamer.Location = New System.Drawing.Point(12, 159)
        Me.chkRosesCreamer.Name = "chkRosesCreamer"
        Me.chkRosesCreamer.Size = New System.Drawing.Size(144, 24)
        Me.chkRosesCreamer.TabIndex = 10
        Me.chkRosesCreamer.Text = "Creamer ($45.00)"
        Me.chkRosesCreamer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkRosesCreamer.UseVisualStyleBackColor = True
        Me.chkRosesCreamer.Visible = False
        '
        'chkRosesSugarBowl
        '
        Me.chkRosesSugarBowl.AutoSize = True
        Me.chkRosesSugarBowl.Location = New System.Drawing.Point(12, 129)
        Me.chkRosesSugarBowl.Name = "chkRosesSugarBowl"
        Me.chkRosesSugarBowl.Size = New System.Drawing.Size(163, 24)
        Me.chkRosesSugarBowl.TabIndex = 9
        Me.chkRosesSugarBowl.Text = "Sugar Bowl ($55.00)"
        Me.chkRosesSugarBowl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkRosesSugarBowl.UseVisualStyleBackColor = True
        Me.chkRosesSugarBowl.Visible = False
        '
        'chkRosesSoupBowls
        '
        Me.chkRosesSoupBowls.AutoSize = True
        Me.chkRosesSoupBowls.Location = New System.Drawing.Point(12, 96)
        Me.chkRosesSoupBowls.Name = "chkRosesSoupBowls"
        Me.chkRosesSoupBowls.Size = New System.Drawing.Size(228, 24)
        Me.chkRosesSoupBowls.TabIndex = 8
        Me.chkRosesSoupBowls.Text = "Set of 8 Soup Bowls ($105.00)"
        Me.chkRosesSoupBowls.UseVisualStyleBackColor = True
        Me.chkRosesSoupBowls.Visible = False
        '
        'chkRosesServingBowl
        '
        Me.chkRosesServingBowl.AutoSize = True
        Me.chkRosesServingBowl.Location = New System.Drawing.Point(12, 66)
        Me.chkRosesServingBowl.Name = "chkRosesServingBowl"
        Me.chkRosesServingBowl.Size = New System.Drawing.Size(174, 24)
        Me.chkRosesServingBowl.TabIndex = 7
        Me.chkRosesServingBowl.Text = "Serving Bowl ($40.00)"
        Me.chkRosesServingBowl.UseVisualStyleBackColor = True
        Me.chkRosesServingBowl.Visible = False
        '
        'chkRosesPlatter
        '
        Me.chkRosesPlatter.AutoSize = True
        Me.chkRosesPlatter.Location = New System.Drawing.Point(12, 37)
        Me.chkRosesPlatter.Name = "chkRosesPlatter"
        Me.chkRosesPlatter.Size = New System.Drawing.Size(157, 24)
        Me.chkRosesPlatter.TabIndex = 6
        Me.chkRosesPlatter.Text = "11"" Platter ($50.00)"
        Me.chkRosesPlatter.UseVisualStyleBackColor = True
        Me.chkRosesPlatter.Visible = False
        '
        'chkWillowTeapot
        '
        Me.chkWillowTeapot.AutoSize = True
        Me.chkWillowTeapot.Location = New System.Drawing.Point(12, 187)
        Me.chkWillowTeapot.Name = "chkWillowTeapot"
        Me.chkWillowTeapot.Size = New System.Drawing.Size(142, 24)
        Me.chkWillowTeapot.TabIndex = 5
        Me.chkWillowTeapot.Text = "Teapot ($150.00)"
        Me.chkWillowTeapot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkWillowTeapot.UseVisualStyleBackColor = True
        '
        'chkWillowCreamer
        '
        Me.chkWillowCreamer.AutoSize = True
        Me.chkWillowCreamer.Location = New System.Drawing.Point(12, 157)
        Me.chkWillowCreamer.Name = "chkWillowCreamer"
        Me.chkWillowCreamer.Size = New System.Drawing.Size(144, 24)
        Me.chkWillowCreamer.TabIndex = 4
        Me.chkWillowCreamer.Text = "Creamer ($25.00)"
        Me.chkWillowCreamer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkWillowCreamer.UseVisualStyleBackColor = True
        '
        'chkWillowSugarBowl
        '
        Me.chkWillowSugarBowl.AutoSize = True
        Me.chkWillowSugarBowl.Location = New System.Drawing.Point(12, 127)
        Me.chkWillowSugarBowl.Name = "chkWillowSugarBowl"
        Me.chkWillowSugarBowl.Size = New System.Drawing.Size(163, 24)
        Me.chkWillowSugarBowl.TabIndex = 3
        Me.chkWillowSugarBowl.Text = "Sugar Bowl ($35.00)"
        Me.chkWillowSugarBowl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkWillowSugarBowl.UseVisualStyleBackColor = True
        '
        'chkWillowServingBowl
        '
        Me.chkWillowServingBowl.AutoSize = True
        Me.chkWillowServingBowl.Location = New System.Drawing.Point(12, 67)
        Me.chkWillowServingBowl.Name = "chkWillowServingBowl"
        Me.chkWillowServingBowl.Size = New System.Drawing.Size(174, 24)
        Me.chkWillowServingBowl.TabIndex = 2
        Me.chkWillowServingBowl.Text = "Serving Bowl ($20.00)"
        Me.chkWillowServingBowl.UseVisualStyleBackColor = True
        '
        'chkWillowSoupBowls
        '
        Me.chkWillowSoupBowls.AutoSize = True
        Me.chkWillowSoupBowls.Location = New System.Drawing.Point(12, 97)
        Me.chkWillowSoupBowls.Name = "chkWillowSoupBowls"
        Me.chkWillowSoupBowls.Size = New System.Drawing.Size(220, 24)
        Me.chkWillowSoupBowls.TabIndex = 1
        Me.chkWillowSoupBowls.Text = "Set of 8 Soup Bowls ($85.00)"
        Me.chkWillowSoupBowls.UseVisualStyleBackColor = True
        '
        'chkWillowPlatter
        '
        Me.chkWillowPlatter.AutoSize = True
        Me.chkWillowPlatter.Location = New System.Drawing.Point(12, 36)
        Me.chkWillowPlatter.Name = "chkWillowPlatter"
        Me.chkWillowPlatter.Size = New System.Drawing.Size(157, 24)
        Me.chkWillowPlatter.TabIndex = 0
        Me.chkWillowPlatter.Text = "11"" Platter ($30.00)"
        Me.chkWillowPlatter.UseVisualStyleBackColor = True
        '
        'lstQuantity
        '
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.ItemHeight = 20
        Me.lstQuantity.Location = New System.Drawing.Point(346, 59)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(132, 184)
        Me.lstQuantity.TabIndex = 9
        '
        'pboxWillows
        '
        Me.pboxWillows.Image = CType(resources.GetObject("pboxWillows.Image"), System.Drawing.Image)
        Me.pboxWillows.Location = New System.Drawing.Point(503, 308)
        Me.pboxWillows.Name = "pboxWillows"
        Me.pboxWillows.Size = New System.Drawing.Size(213, 178)
        Me.pboxWillows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxWillows.TabIndex = 10
        Me.pboxWillows.TabStop = False
        '
        'pboxCastles
        '
        Me.pboxCastles.Image = CType(resources.GetObject("pboxCastles.Image"), System.Drawing.Image)
        Me.pboxCastles.Location = New System.Drawing.Point(503, 308)
        Me.pboxCastles.Name = "pboxCastles"
        Me.pboxCastles.Size = New System.Drawing.Size(213, 178)
        Me.pboxCastles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxCastles.TabIndex = 11
        Me.pboxCastles.TabStop = False
        Me.pboxCastles.Visible = False
        '
        'pboxRoses
        '
        Me.pboxRoses.Image = CType(resources.GetObject("pboxRoses.Image"), System.Drawing.Image)
        Me.pboxRoses.Location = New System.Drawing.Point(503, 308)
        Me.pboxRoses.Name = "pboxRoses"
        Me.pboxRoses.Size = New System.Drawing.Size(213, 178)
        Me.pboxRoses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxRoses.TabIndex = 12
        Me.pboxRoses.TabStop = False
        Me.pboxRoses.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(20, 285)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 13
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(20, 438)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 20)
        Me.lblError.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 596)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.pboxRoses)
        Me.Controls.Add(Me.pboxCastles)
        Me.Controls.Add(Me.pboxWillows)
        Me.Controls.Add(Me.lstQuantity)
        Me.Controls.Add(Me.grp2)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        CType(Me.pboxWillows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxCastles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxRoses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents grp2 As GroupBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents chkWillowServingBowl As CheckBox
    Friend WithEvents chkWillowSoupBowls As CheckBox
    Friend WithEvents chkWillowPlatter As CheckBox
    Friend WithEvents chkWillowCreamer As CheckBox
    Friend WithEvents chkWillowSugarBowl As CheckBox
    Friend WithEvents radWillow As RadioButton
    Friend WithEvents chkWillowTeapot As CheckBox
    Friend WithEvents radCastles As RadioButton
    Friend WithEvents radRoses As RadioButton
    Friend WithEvents pboxWillows As PictureBox
    Friend WithEvents pboxCastles As PictureBox
    Friend WithEvents pboxRoses As PictureBox
    Friend WithEvents lblWarning As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents chkRosesPlatter As CheckBox
    Friend WithEvents chkRosesServingBowl As CheckBox
    Friend WithEvents chkRosesSoupBowls As CheckBox
    Friend WithEvents chkRosesSugarBowl As CheckBox
    Friend WithEvents chkRosesCreamer As CheckBox
    Friend WithEvents chkRosesTeapot As CheckBox
    Friend WithEvents chkCastlesTeapot As CheckBox
    Friend WithEvents chkCastlesCreamer As CheckBox
    Friend WithEvents chkCastlesSugarBowl As CheckBox
    Friend WithEvents chkCastlesSoupBowls As CheckBox
    Friend WithEvents chkCastlesServingBowl As CheckBox
    Friend WithEvents chkCastlesPlatter As CheckBox
    Friend WithEvents lblError As Label
End Class
