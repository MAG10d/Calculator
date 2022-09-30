Public Class frmCalculator
    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_selector As Boolean = False

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRightBracket.Click

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtResults.Text <> 0 Then
            txtResults.Text += "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResults.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "1"
        Else
            txtResults.Text = "1"
        End If
    End Sub

    Private Sub btnClearEntry_Click(sender As Object, e As EventArgs) Handles btnClearEntry.Click
        txtResults.Text = "0"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "2"
        Else
            txtResults.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "3"
        Else
            txtResults.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "4"
        Else
            txtResults.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "5"
        Else
            txtResults.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "6"
        Else
            txtResults.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "7"
        Else
            txtResults.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "8"
        Else
            txtResults.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtResults.Text <> "0" Then
            txtResults.Text += "9"
        Else
            txtResults.Text = "9"
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If Operator_selector = True Then
            Secondnum = txtResults.Text
            If Operations = 1 Then
                txtResults.Text = Firstnum + Secondnum
            ElseIf Operations = 2 Then
                txtResults.Text = Firstnum - Secondnum
            ElseIf Operations = 3 Then
                txtResults.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    txtResults.Text = "Are you 低能"
                    txtResults.Text = Firstnum / Secondnum
                End If
            End If
            Operator_selector = False
        End If
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Firstnum = txtResults.Text
        txtResults.Text = "0"
        Operator_selector = True
        Operations = 1 ' = +

    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If Not (txtResults.Text.Contains(".")) Then
            txtResults.Text += "."
        End If
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        Firstnum = txtResults.Text
        txtResults.Text = "0"
        Operator_selector = True
        Operations = 2 ' = -
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Firstnum = txtResults.Text
        txtResults.Text = "0"
        Operator_selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Firstnum = txtResults.Text
        txtResults.Text = "0"
        Operator_selector = True
        Operations = 4 ' = /
    End Sub
End Class
