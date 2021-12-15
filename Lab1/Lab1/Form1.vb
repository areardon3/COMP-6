Public Class Form1



    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click

    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        lblTotal.Text = Val(txtRed.Text) + Val(txtGreen.Text) + Val(txtBlue.Text)


    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged


    End Sub

    Private Sub txtGreen_TextChanged(sender As Object, e As EventArgs) Handles txtGreen.TextChanged

    End Sub

    Private Sub txtBlue_TextChanged(sender As Object, e As EventArgs) Handles txtBlue.TextChanged

    End Sub

    Private Sub lblBlue_Click(sender As Object, e As EventArgs) Handles lblBlue.Click

    End Sub

    Private Sub lblGreen_Click(sender As Object, e As EventArgs) Handles lblGreen.Click

    End Sub

    Private Sub lblRed_Click(sender As Object, e As EventArgs) Handles lblRed.Click

    End Sub


End Class
