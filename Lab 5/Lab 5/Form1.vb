Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtTicket.Text = ""
        lstAge.SelectedItem = "16"

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strAge As String
        Dim intAge As Integer
        Dim strTicket As String


        strAge = lstAge.SelectedItem.ToString()
        strTicket = txtTicket.Text

        Integer.TryParse(strAge, intAge)


        If strTicket = "Y" Then
            lblRate.Text = ("Your rate is $85.")

        ElseIf strTicket = "N" And intAge >= 30 Then
            lblRate.Text = ("Great job! You qualify for $30 per month insurance.")


        ElseIf strTicket = "N" And intAge < 30 Then
            lblRate.Text = ("Great job! Keep It up and you will soon have the best rate. Right now, you qualify for $45 a month.")

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intAge As Integer = 16 To 99 Step 1
            lstAge.Items.Add(intAge.ToString())
        Next intAge
        lstAge.SelectedItem = "16"

    End Sub

    Private Sub txtTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTicket.KeyPress

        If e.KeyChar <> "Y" And e.KeyChar <> "N" And e.KeyChar <> "n" And e.KeyChar <> "y" And e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        Else
            e.Handled = False

        End If

    End Sub
End Class
