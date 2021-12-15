Option Explicit On
Option Infer Off
Option Strict On
Public Class Form1


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        Dim randomInt As New Random
        Dim intClearRandom As Integer

        intClearRandom = randomInt.Next(1, 10)

        If intClearRandom = 1 Then
            lblError.Text = "The form failed to reset. Please try again."

        Else
            lstQuantity.SelectedItem = "1"
            radWillow.Checked = True

            chkWillowCreamer.Checked = False
            chkWillowPlatter.Checked = False
            chkWillowServingBowl.Checked = False
            chkWillowSoupBowls.Checked = False
            chkWillowSugarBowl.Checked = False
            chkWillowTeapot.Checked = False

            chkCastlesCreamer.Checked = False
            chkCastlesPlatter.Checked = False
            chkCastlesServingBowl.Checked = False
            chkCastlesSoupBowls.Checked = False
            chkCastlesSugarBowl.Checked = False
            chkCastlesTeapot.Checked = False

            chkRosesCreamer.Checked = False
            chkRosesPlatter.Checked = False
            chkRosesServingBowl.Checked = False
            chkRosesSoupBowls.Checked = False
            chkRosesSugarBowl.Checked = False
            chkRosesTeapot.Checked = False

            lblTotal.Text = ""
            lblError.Text = ""

        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        Dim dblExtraCost As Double
        Dim dblBaseCost As Double
        Dim intQuantity As Integer
        Dim dblTotalCost As Double
        Dim strQuantity As String
        Dim strExtraOrder As String
        Dim strBaseOrder As String


        strQuantity = lstQuantity.SelectedItem.ToString()

        Integer.TryParse(strQuantity, intQuantity)

        If radWillow.Checked = True Then
            dblBaseCost = 15
            strBaseOrder = "Royal Wessex Blue Willows"

        ElseIf radRoses.Checked = True Then
            dblBaseCost = 39.95
            strBaseOrder = "Royal Albert Old Country Roses"

        Else radCastles.Checked = True
            dblBaseCost = 19.99
            strBaseOrder = "Johnson Brothers Old British Castles"

        End If

        strExtraOrder = ""




        If chkWillowCreamer.Checked = True Then
            dblExtraCost += 25
            strExtraOrder += "Creamer" & ControlChars.NewLine
        End If

        If chkWillowPlatter.Checked = True Then
            dblExtraCost += 30
            strExtraOrder += "Platter" & ControlChars.NewLine
        End If

        If chkWillowServingBowl.Checked = True Then
            dblExtraCost += 20
            strExtraOrder += "Serving Bowl" & ControlChars.NewLine
        End If

        If chkWillowSoupBowls.Checked = True Then
            dblExtraCost += 85
            strExtraOrder += "Soup Bowls" & ControlChars.NewLine
        End If

        If chkWillowSugarBowl.Checked = True Then
            dblExtraCost += 35
            strExtraOrder += "Sugar Bowl" & ControlChars.NewLine
        End If

        If chkWillowTeapot.Checked = True Then
            dblExtraCost += 150
            strExtraOrder += "Teapot" & ControlChars.NewLine
        End If



        If chkRosesCreamer.Checked = True Then
            dblExtraCost += 45
            strExtraOrder += "Creamer" & ControlChars.NewLine
        End If

        If chkRosesPlatter.Checked = True Then
            dblExtraCost += 50
            strExtraOrder += "Platter" & ControlChars.NewLine
        End If

        If chkRosesServingBowl.Checked = True Then
            dblExtraCost += 40
            strExtraOrder += "Serving Bowls" & ControlChars.NewLine
        End If

        If chkRosesSoupBowls.Checked = True Then
            dblExtraCost += 105
            strExtraOrder += "Soup Bowls" & ControlChars.NewLine
        End If

        If chkRosesSugarBowl.Checked = True Then
            dblExtraCost += 55
            strExtraOrder += "Sugar Bowl" & ControlChars.NewLine
        End If

        If chkRosesTeapot.Checked = True Then
            dblExtraCost += 170
            strExtraOrder += "Teapot" & ControlChars.NewLine
        End If



        If chkCastlesCreamer.Checked = True Then
            dblExtraCost += 30
            strExtraOrder += "Creamer" & ControlChars.NewLine
        End If

        If chkCastlesPlatter.Checked = True Then
            dblExtraCost += 35
            strExtraOrder += "Platter" & ControlChars.NewLine
        End If

        If chkCastlesServingBowl.Checked = True Then
            dblExtraCost += 25
            strExtraOrder += "Serving Bowls" & ControlChars.NewLine
        End If

        If chkCastlesSoupBowls.Checked = True Then
            dblExtraCost += 90
            strExtraOrder += "Soup Bowls" & ControlChars.NewLine
        End If

        If chkCastlesSugarBowl.Checked = True Then
            dblExtraCost += 40
            strExtraOrder += "Sugar Bowl" & ControlChars.NewLine
        End If

        If chkCastlesTeapot.Checked = True Then
            dblExtraCost += 155
            strExtraOrder += "Teapot" & ControlChars.NewLine
        End If


        dblTotalCost = (intQuantity * dblBaseCost) + dblExtraCost

        lblTotal.Text = "Thank you for your order!" & ControlChars.NewLine & "You Ordered:" & ControlChars.NewLine & strBaseOrder & ControlChars.NewLine &
            strExtraOrder & "For a grand total of " & dblTotalCost.ToString("C2")



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intQuantity As Integer = 1 To 20 Step 1
            lstQuantity.Items.Add(intQuantity.ToString())

        Next intQuantity
        lstQuantity.SelectedItem = "1"

        radWillow.Checked = True

    End Sub

    Private Sub radWillow_CheckedChanged(sender As Object, e As EventArgs) Handles radWillow.CheckedChanged

        pboxWillows.Visible = True
        pboxRoses.Visible = False
        pboxCastles.Visible = False

        chkWillowPlatter.Visible = True
        chkWillowServingBowl.Visible = True
        chkWillowSoupBowls.Visible = True
        chkWillowSugarBowl.Visible = True
        chkWillowCreamer.Visible = True
        chkWillowTeapot.Visible = True

        chkRosesPlatter.Visible = False
        chkRosesServingBowl.Visible = False
        chkRosesSoupBowls.Visible = False
        chkRosesSugarBowl.Visible = False
        chkRosesCreamer.Visible = False
        chkRosesTeapot.Visible = False

        chkCastlesPlatter.Visible = False
        chkCastlesServingBowl.Visible = False
        chkCastlesSoupBowls.Visible = False
        chkCastlesSugarBowl.Visible = False
        chkCastlesCreamer.Visible = False
        chkCastlesTeapot.Visible = False

        chkCastlesCreamer.Checked = False
        chkCastlesPlatter.Checked = False
        chkCastlesServingBowl.Checked = False
        chkCastlesSoupBowls.Checked = False
        chkCastlesSugarBowl.Checked = False
        chkCastlesTeapot.Checked = False

        chkRosesCreamer.Checked = False
        chkRosesPlatter.Checked = False
        chkRosesServingBowl.Checked = False
        chkRosesSoupBowls.Checked = False
        chkRosesSugarBowl.Checked = False
        chkRosesTeapot.Checked = False

    End Sub

    Private Sub radRoses_CheckedChanged(sender As Object, e As EventArgs) Handles radRoses.CheckedChanged

        pboxRoses.Visible = True
        pboxWillows.Visible = False
        pboxCastles.Visible = False

        chkRosesPlatter.Visible = True
        chkRosesServingBowl.Visible = True
        chkRosesSoupBowls.Visible = True
        chkRosesSugarBowl.Visible = True
        chkRosesCreamer.Visible = True
        chkRosesTeapot.Visible = True

        chkWillowPlatter.Visible = False
        chkWillowServingBowl.Visible = False
        chkWillowSoupBowls.Visible = False
        chkWillowSugarBowl.Visible = False
        chkWillowCreamer.Visible = False
        chkWillowTeapot.Visible = False

        chkCastlesPlatter.Visible = False
        chkCastlesServingBowl.Visible = False
        chkCastlesSoupBowls.Visible = False
        chkCastlesSugarBowl.Visible = False
        chkCastlesCreamer.Visible = False
        chkCastlesTeapot.Visible = False

        chkWillowCreamer.Checked = False
        chkWillowPlatter.Checked = False
        chkWillowServingBowl.Checked = False
        chkWillowSoupBowls.Checked = False
        chkWillowSugarBowl.Checked = False
        chkWillowTeapot.Checked = False

        chkCastlesCreamer.Checked = False
        chkCastlesPlatter.Checked = False
        chkCastlesServingBowl.Checked = False
        chkCastlesSoupBowls.Checked = False
        chkCastlesSugarBowl.Checked = False
        chkCastlesTeapot.Checked = False

    End Sub

    Private Sub radCastles_CheckedChanged(sender As Object, e As EventArgs) Handles radCastles.CheckedChanged

        pboxCastles.Visible = True
        pboxRoses.Visible = False
        pboxWillows.Visible = False

        chkCastlesPlatter.Visible = True
        chkCastlesServingBowl.Visible = True
        chkCastlesSoupBowls.Visible = True
        chkCastlesSugarBowl.Visible = True
        chkCastlesCreamer.Visible = True
        chkCastlesTeapot.Visible = True

        chkWillowPlatter.Visible = False
        chkWillowServingBowl.Visible = False
        chkWillowSoupBowls.Visible = False
        chkWillowSugarBowl.Visible = False
        chkWillowCreamer.Visible = False
        chkWillowTeapot.Visible = False

        chkRosesPlatter.Visible = False
        chkRosesServingBowl.Visible = False
        chkRosesSoupBowls.Visible = False
        chkRosesSugarBowl.Visible = False
        chkRosesCreamer.Visible = False
        chkRosesTeapot.Visible = False

        chkWillowCreamer.Checked = False
        chkWillowPlatter.Checked = False
        chkWillowServingBowl.Checked = False
        chkWillowSoupBowls.Checked = False
        chkWillowSugarBowl.Checked = False
        chkWillowTeapot.Checked = False

        chkRosesCreamer.Checked = False
        chkRosesPlatter.Checked = False
        chkRosesServingBowl.Checked = False
        chkRosesSoupBowls.Checked = False
        chkRosesSugarBowl.Checked = False
        chkRosesTeapot.Checked = False

    End Sub


End Class
