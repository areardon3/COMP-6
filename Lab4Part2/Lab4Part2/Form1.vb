Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strTotalOrder As String
        Dim dblTotalCost As Double

        Dim dblBurgerCost As Double
        Dim dblFriesCost As Double
        Dim dblDrinkCost As Double

        Dim strBurgerOrder As String
        Dim strFriesOrder As String
        Dim strDrinkOrder As String

        Dim dblDonation As Double
        Dim strDonation As String

        Dim strTakeOut As String


        If radRegular.Checked = True Then
            dblBurgerCost = 3.5
            strBurgerOrder = "Regular Burger with "

        ElseIf radCheese.Checked = True Then
            dblBurgerCost = 4
            strBurgerOrder = "Cheese Burger with "

        ElseIf radSecret.Checked = True Then
            dblBurgerCost = 8
            strBurgerOrder = "Secret Burger with "

        End If


        If radLarge.Checked = True Then
            dblFriesCost = 2.5
            strFriesOrder = "Large Fries with "

        ElseIf radSmall.Checked = True Then
            dblFriesCost = 1.5
            strFriesOrder = "Small Fries and a "

        End If

        If radSoda.Checked = True Then
            dblDrinkCost = 1
            strDrinkOrder = "Soda "

        ElseIf radShake.Checked = True Then
            dblDrinkCost = 2
            strDrinkOrder = "Shake"

        End If

        If chkDonation.Checked = True Then
            dblDonation = 1
            strDonation = "Thank you for your donation!" & ControlChars.NewLine

        End If

        If chkTakeOut.Checked = True Then
            strTakeOut = "Your order is Take Out " & ControlChars.NewLine

        End If

        strTotalOrder = strBurgerOrder & strFriesOrder & strDrinkOrder
        dblTotalCost = dblBurgerCost + dblFriesCost + dblDrinkCost + dblDonation

        lblTotal.Text = strTakeOut & "You Ordered: " & strTotalOrder & ControlChars.NewLine & strDonation & "For a total of: " & dblTotalCost.ToString("C2")

    End Sub

End Class
