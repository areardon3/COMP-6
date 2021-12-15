Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim dblBaseCost As Double
        Dim dblExtraCost As Double
        Dim dblTotalCost As Double

        Dim strBaseOrder As String
        Dim strExtraOrder As String

        If radSmall.Checked = True Then
            dblBaseCost = 9
            strBaseOrder = "Small Pizza" & ControlChars.NewLine

        ElseIf radMedium.Checked = True Then
            dblBaseCost = 11
            strBaseOrder = "Medium Pizza" & ControlChars.NewLine

        Else
            dblBaseCost = 20
            strBaseOrder = "Large Pizza" & ControlChars.NewLine

        End If

        If chkPepperoni.Checked = True Then
            dblExtraCost += 0.5
            strExtraOrder += "Pepperoni" & ControlChars.NewLine

        End If

        If chkSausage.Checked = True Then
            dblExtraCost += 0.5
            strExtraOrder += "Sausage" & ControlChars.NewLine

        End If

        If chkOlives.Checked = True Then
            dblExtraCost += 0.5
            strExtraOrder += "Black Olives" & ControlChars.NewLine

        End If

        If chkPineapple.Checked = True Then
            dblExtraCost += 0.5
            strExtraOrder += "Pineapple" & ControlChars.NewLine

        End If


        dblTotalCost = dblBaseCost + dblExtraCost

        lblTotal.Text = "Thank you for eating with us! You Ordered:" & ControlChars.NewLine & strBaseOrder &
        strExtraOrder & "For a total of " & dblTotalCost.ToString("C2")

    End Sub
End Class
