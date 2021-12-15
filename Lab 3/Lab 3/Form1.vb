Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Const dblPI As Double = 3.14159
    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click

        Dim radiusInput As String = InputBox("Please enter the radius.")
        Dim dblCircleArea As Double
        Dim dblCircleRadius As Double

        Double.TryParse(radiusInput, dblCircleRadius)

        dblCircleArea = dblPI * dblCircleRadius ^ 2

        MessageBox.Show("The area of your circle is " & dblCircleArea)


    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click

        Dim sideInput As String = InputBox("Please enter the side length.")
        Dim dblSquareSide As Double
        Dim dblSquareArea As Double

        Double.TryParse(sideInput, dblSquareSide)

        dblSquareArea = dblSquareSide ^ 2

        MessageBox.Show("The area of your square is " & dblSquareArea)

    End Sub

    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click

        Dim baseInput As String = InputBox("Please enter the base length.")
        Dim heightInput As String = InputBox("Please enter the height.")
        Dim dblTriHeight As Double
        Dim dblTriBase As Double
        Dim dblTriArea As Double

        Double.TryParse(baseInput, dblTriBase)
        Double.TryParse(heightInput, dblTriHeight)

        dblTriArea = dblTriBase * dblTriHeight / 2

        MessageBox.Show("The area of your triangle is " & dblTriArea)

    End Sub


End Class
