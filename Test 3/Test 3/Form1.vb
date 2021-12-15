Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click

        Dim strNum1 As String = InputBox("Enter Number 1")
        Dim dblNum1 As Double
        Double.TryParse(strNum1, dblNum1)

        Dim strNum2 As String = InputBox("Enter Number 2")
        Dim dblNum2 As Double
        Double.TryParse(strNum2, dblNum2)


        lblAddOutput.Text = "Your product is: " & multNumbers(dblNum1, dblNum2).ToString()

    End Sub


    Public Function multNumbers(ByVal num1 As Double, ByVal num2 As Double) As Double

        multNumbers = num1 * num2

        Return multNumbers

    End Function

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click

        Dim fullName As String = txtName.Text

        MessageBox.Show(reformatNames(fullName))

    End Sub

    Public Function reformatNames(ByVal name As String) As String

        Dim fName As String = name.Substring(name.IndexOf(",") + 1).Trim
        Dim lName As String = name.Substring(0, name.IndexOf(","))

        reformatNames = fName & " " & lName

        Return reformatNames

    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim keyName As String = InputBox("Please enter the name of the employee you would like to search for.")

        For Each workerName As String In lstNames.Items

            If workerName = keyName Then

                MessageBox.Show("Name is found.")
                Return

            End If

        Next

        MessageBox.Show("Name is not found.")
    End Sub
End Class
