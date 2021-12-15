Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        tmrSubmit.Enabled = False

        Dim dblDrivers As Double
        Dim dblHours As Double
        Dim dblTotal As Double

        Double.TryParse(txtDrivers.Text, dblDrivers)
        Double.TryParse(txtHours.Text, dblHours)

        dblTotal = dblHours * 50 * dblDrivers

        lblCost.Text = "Number of Drivers: " & txtDrivers.Text & " Hours Needed: " & txtHours.Text & " Total: " & dblTotal.ToString("C2")

    End Sub

    Private Sub tmrSubmit_Tick(sender As Object, e As EventArgs) Handles tmrSubmit.Tick

        MessageBox.Show("Remember to submit your order!")

    End Sub


End Class
