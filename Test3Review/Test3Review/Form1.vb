Public Class Form1

    Dim myArray(29) As Integer

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click





    End Sub

    Public Function getDifference(ByVal Num1 As Integer, ByVal Num2 As Integer) As Integer

        If Num1 > Num2 Then

            getDifference = Num1 - Num2
            Return getDifference
        Else

            MessageBox.Show("The number will be negative.")
            Exit Function

        End If

    End Function

    Public Sub setNumbers(ByRef Num1 As Integer, ByRef Num2 As Integer)

        Num1 = 0
        Num2 = 0

    End Sub

    Private Sub btnRun2_Click(sender As Object, e As EventArgs) Handles btnRun2.Click

        Dim newData As String = InputBox("Please enter data")


    End Sub
End Class
