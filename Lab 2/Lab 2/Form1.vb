Public Class Form1
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub lblPhone_Click(sender As Object, e As EventArgs) Handles lblPhone.Click

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub tmrFinish_Tick(sender As Object, e As EventArgs) Handles tmrFinish.Tick
        MessageBox.Show("Hurry, submit your information!")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        tmrFinish.Enabled = False
        MessageBox.Show("Name: " & txtName.Text & ControlChars.NewLine & "Phone Number: " & txtPhone.Text)
        txtPhone.Text = ("")
        txtName.Text = ("")


    End Sub

End Class
