Option Strict On
Option Infer Off
Option Explicit On
Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtYears.Text = ""
        txtSales.Text = ""
        lblOutput.Text = ""

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim dblYearsWorking As Double
        Dim dblSales As Double

        Dim strYearsWorking As String
        Dim strSales As String
        Dim strName As String

        strYearsWorking = txtYears.Text
        strSales = txtSales.Text
        strName = txtName.Text

        Double.TryParse(strYearsWorking, dblYearsWorking)
        Double.TryParse(strSales, dblSales)

        If dblSales >= 100000 AndAlso dblYearsWorking >= 5 Then

            lblOutput.Text = (strName & ", you got a $1000 bonus!")

        Else

            lblOutput.Text = (strName & ", you did not get a $1000 bonus.")
        End If

        If dblYearsWorking <= 0 Then

            lblOutput.Text = ("Please enter a year number > 0")

        End If


    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 57 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 48 Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub
End Class
