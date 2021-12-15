Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Dim myArray(39, 2) As String
    Dim intName As Integer = 0
    Dim intStock As Integer = 1
    Dim intPrice As Integer = 2


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lstInventory.Items.Count = 40 Then

            MessageBox.Show("The max inventory space has been hit.")

            Return

        End If

        Dim strNewObject As String = InputBox("Please enter the name of the product you wish to add.")
        Dim strNewPrice As String = InputBox("Please enter the price of the item.")
        Dim strNewStock As String = InputBox("Please add the number in stock of this product.")

        lstInventory.Items.Add(strNewObject)

        Dim intCurrentRow As Integer = lstInventory.Items.IndexOf(strNewObject)

        myArray(intCurrentRow, intName) = strNewObject
        myArray(intCurrentRow, intStock) = strNewStock
        myArray(intCurrentRow, intPrice) = strNewPrice

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myArray(0, 0) = lstInventory.Items.Item(0).ToString()
        myArray(1, 0) = lstInventory.Items.Item(1).ToString()
        myArray(2, 0) = lstInventory.Items.Item(2).ToString()

        myArray(0, intStock) = "15"
        myArray(1, intStock) = "24"
        myArray(2, intStock) = "10"

        myArray(0, intPrice) = "10.99"
        myArray(1, intPrice) = "20.99"
        myArray(2, intPrice) = "24.99"


    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If lstInventory.SelectedIndex = -1 Then

            MessageBox.Show("Please select an item to check it.")

        Else

            Dim intCurrentRow As Integer = lstInventory.SelectedIndex

            MessageBox.Show("There are " & myArray(intCurrentRow, intStock) & " " & myArray(intCurrentRow, intName) & " in stock priced at $" & myArray(intCurrentRow, intPrice) & " each.")

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim intCurrentRow As Integer = lstInventory.SelectedIndex

        If lstInventory.SelectedIndex = -1 Then

            MessageBox.Show("Please select an item to remove.")
            Return

        Else

            For intCounter As Integer = intCurrentRow To lstInventory.Items.Count - 1

                If intCounter = 39 Then

                    myArray(intCounter, intName) = " "
                    myArray(intCounter, intStock) = " "
                    myArray(intCounter, intPrice) = " "

                Else

                    myArray(intCounter, intName) = myArray(intCounter + 1, intName)
                    myArray(intCounter, intStock) = myArray(intCounter + 1, intStock)
                    myArray(intCounter, intPrice) = myArray(intCounter + 1, intPrice)

                End If

            Next

        End If

        lstInventory.Items.RemoveAt(intCurrentRow)


    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim intCurrentRow As Integer = lstInventory.SelectedIndex
        Dim strNewQuantity As String = InputBox("Please enter a new quantity.")

        myArray(intCurrentRow, intStock) = strNewQuantity

    End Sub

End Class
