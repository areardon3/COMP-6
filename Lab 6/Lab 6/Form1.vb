Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        resetComboBoxes()

        If cmb0.SelectedIndex = 0 Then
            showIntrovertQuestions()
            hideExtrovertQuestions()
            lblScore.Text = ""

        Else

            showExtrovertQuestions()
            hideIntrovertQuestions()
            lblScore.Text = ""

        End If
    End Sub

    Public Sub resetComboBoxes()

        cmb1.SelectedIndex = 0
        cmb2.SelectedIndex = 0
        cmb3.SelectedIndex = 0
        cmb4.SelectedIndex = 0
        cmb5.SelectedIndex = 0
        cmb6.SelectedIndex = 0
        cmb7.SelectedIndex = 0
        cmb8.SelectedIndex = 0

    End Sub
    Public Sub showExtrovertQuestions()

        lblExtrovert1.Visible = True
        lblExtrovert2.Visible = True
        lblExtrovert3.Visible = True
        lblExtrovert4.Visible = True

        cmb5.Visible = True
        cmb6.Visible = True
        cmb7.Visible = True
        cmb8.Visible = True

        btnECheckScore.Visible = True
    End Sub

    Public Sub hideExtrovertQuestions()

        lblExtrovert1.Visible = False
        lblExtrovert2.Visible = False
        lblExtrovert3.Visible = False
        lblExtrovert4.Visible = False

        cmb5.Visible = False
        cmb6.Visible = False
        cmb7.Visible = False
        cmb8.Visible = False

        btnECheckScore.Visible = False
    End Sub

    Public Sub showIntrovertQuestions()

        lblIntrovert1.Visible = True
        lblIntrovert2.Visible = True
        lblIntrovert3.Visible = True
        lblIntrovert4.Visible = True

        cmb1.Visible = True
        cmb2.Visible = True
        cmb3.Visible = True
        cmb4.Visible = True

        btnECheckScore.Visible = False
        btnICheckScore.Visible = True

    End Sub

    Public Sub hideIntrovertQuestions()

        lblIntrovert1.Visible = False
        lblIntrovert2.Visible = False
        lblIntrovert3.Visible = False
        lblIntrovert4.Visible = False

        cmb1.Visible = False
        cmb2.Visible = False
        cmb3.Visible = False
        cmb4.Visible = False

        btnICheckScore.Visible = False
    End Sub
    Public Function checkExtrovertQuestions(ByVal score As Integer) As Integer

        If cmb5.SelectedIndex = 0 Then

            score += 1

        End If

        If cmb6.SelectedIndex = 0 Then

            score += 1

        End If

        If cmb7.SelectedIndex = 1 Then

            score += 1

        End If

        If cmb8.SelectedIndex = 0 Then

            score += 1

        End If

        Return score

    End Function

    Public Function checkIntrovertQuestions(ByVal score As Integer) As Integer

        If cmb1.SelectedIndex = 0 Then

            score += 1

        End If

        If cmb2.SelectedIndex = 0 Then

            score += 1

        End If

        If cmb3.SelectedIndex = 0 Then

            score += 1

        End If

        If cmb4.SelectedIndex = 0 Then

            score += 1

        End If

        Return score

    End Function

    Private Sub btnICheckScore_Click(sender As Object, e As EventArgs) Handles btnICheckScore.Click

        hideIntrovertQuestions()

        Dim iScore As Integer
        Dim finalIntrovertScore As Integer = checkIntrovertQuestions(iScore)

        If finalIntrovertScore < 3 Then

            lblScore.Text = "We do not believe you are an introvert."

        Else lblScore.Text = "Yep, you are an introvert."

        End If

    End Sub

    Private Sub btnECheckScore_Click(sender As Object, e As EventArgs) Handles btnECheckScore.Click

        hideExtrovertQuestions()

        Dim eScore As Integer
        Dim finalextrovertScore As Integer = checkExtrovertQuestions(eScore)

        If finalextrovertScore < 3 Then

            lblScore.Text = "We do not believe you are an extrovert."

        Else lblScore.Text = "Yep, you are an extrovert."

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb0.SelectedIndex = 0

    End Sub
End Class
