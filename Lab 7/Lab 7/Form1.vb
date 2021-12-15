Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strFirstName As String
        Dim strLastName As String
        Dim strName As String
        Dim intNameIndex As Integer

        Dim strID As String
        strID = txtID.Text

        Dim strCode As String
        strCode = txtCode.Text

        Dim dblTotalCost As Double
        Dim dblOneGal As Double
        Dim dblFiveGal As Double
        Dim dblFifteenGal As Double

        dblOneGal = 1.99
        dblFiveGal = 7.99
        dblFifteenGal = 11.25

        Dim intOneGalPurchased As Integer
        Dim intFiveGalPurchased As Integer
        Dim intFifteenGalPurchased As Integer

        Dim strOneGal As String
        Dim strFiveGal As String
        Dim strFifteenGal As String

        strOneGal = txt1Gal.Text
        strFiveGal = txt5Gal.Text
        strFifteenGal = txt15Gal.Text

        Integer.TryParse(strOneGal, intOneGalPurchased)
        Integer.TryParse(strFiveGal, intFiveGalPurchased)
        Integer.TryParse(strFifteenGal, intFifteenGalPurchased)

        dblTotalCost = (dblOneGal * intOneGalPurchased) + (dblFiveGal * intFiveGalPurchased) + (dblFifteenGal * intFifteenGalPurchased)


        strName = txtName.Text
        intNameIndex = strName.IndexOf(" ")

        strFirstName = strName.Substring(0, intNameIndex)
        strLastName = strName.Substring(intNameIndex + 1)


        If strID Like "###[A-Z][A-Z][A-Z]" = False Then

            MessageBox.Show("Incorrect format for Customer ID. Please try again using the 3 number and 3 capital letter format.")

        End If

        Dim strApplyCoupon As String

        If strCode.Contains("FLOWER") = True Then

            dblTotalCost = dblTotalCost * 0.75
            strApplyCoupon = "You qualify for a 25% discount!"

        End If

        clearControls()

        lblOutput.Text = strLastName & ", " & strFirstName & ControlChars.NewLine & strID & ControlChars.NewLine &"You Ordered:" & ControlChars.NewLine & strOneGal & " One Gallon Flower Pots" &
            ControlChars.NewLine & strFiveGal & " Five Gallon Flower Pots" & ControlChars.NewLine & strFifteenGal & " Fifteen Gallon Flower Pots" & ControlChars.NewLine &
            strApplyCoupon & ControlChars.NewLine & "For a total of: " & dblTotalCost.ToString("C2")

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        resetForm()

    End Sub

    Public Sub resetForm()

        txtName.Text = ""
        txtID.Text = ""
        txt1Gal.Text = ""
        txt5Gal.Text = ""
        txt15Gal.Text = ""
        txtCode.Text = ""

    End Sub
    Public Sub clearControls()

        lblName.Visible = False
        lblID.Visible = False
        lbl1Gal.Visible = False
        lbl5Gal.Visible = False
        lbl15Gal.Visible = False
        lblCode.Visible = False

        txtName.Visible = False
        txtID.Visible = False
        txt1Gal.Visible = False
        txt5Gal.Visible = False
        txt15Gal.Visible = False
        txtCode.Visible = False

        btnSubmit.Visible = False
        btnReset.Visible = False

    End Sub

End Class
