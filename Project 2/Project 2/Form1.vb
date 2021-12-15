Option Explicit On
Option Infer Off
Option Strict On
Public Class Form1

    Dim fullName As String
    Dim intNameIndex As Integer


    Dim logicSize As Integer = -1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strDisplayName As String

        fullName = txtName.Text.Trim

        Dim fNameNew As String = fullName.Substring(0, fullName.IndexOf(" "))
        Dim lNameNew As String = fullName.Substring(fullName.IndexOf(" ") + 1)

        strDisplayName = reformatNames(fNameNew, lNameNew)

        lstNames.Items.Add(strDisplayName)
        txtName.Text = ""

        logicSize += 1

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim intSelectedItem As Integer = lstNames.SelectedIndex

        lstNames.Items.RemoveAt(intSelectedItem)

    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click

        Dim strListName As String = lstNames.SelectedItem.ToString()

        intNameIndex = strListName.IndexOf(",")

        Dim lNameNew As String = strListName.Substring(0, intNameIndex)
        Dim fNameNew As String = strListName.Substring(intNameIndex + 1)

        Dim strDisplayName As String = undoFormatting(fNameNew, lNameNew)

        MessageBox.Show(strDisplayName)

    End Sub

    Public Function undoFormatting(ByVal firstName As String, ByVal lastName As String) As String

        Dim strNewName As String = firstName & " " & lastName
        Return strNewName

    End Function


    Public Function reformatNames(ByVal firstName As String, ByVal lastName As String) As String

        Dim strNewName As String = lastName & ", " & firstName
        Return strNewName

    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim searchName As String = InputBox("Please enter the last name of the contact you're looking for.")

        If searchNames(searchName) = True Then

            MessageBox.Show("Name is found")

        Else

            MessageBox.Show("Name is not found.")

        End If


    End Sub

    Public Function searchNames(ByVal keyName As String) As Boolean


        For Each itemName As String In lstNames.Items

            Dim inputName As String = itemName.Substring(0, itemName.IndexOf(","))

            If inputName = keyName Then


                Return True

            End If

        Next


        Return False


    End Function

End Class
