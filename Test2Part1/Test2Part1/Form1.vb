Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intList As Integer = 1 To 100 Step 1

            lstOne.Items.Add(intList.ToString())

        Next

    End Sub
End Class
