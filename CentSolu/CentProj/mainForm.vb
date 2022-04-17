Option Explicit On
Option Infer Off
Option Strict Off 'too much to convert if on, but works as should

' Name: Pennies Calculator
' Purpose: Display number of dollars, quarters, dimes, nickles, and pennies the user will recieve when pennies are cashed at the bank
' Programmer: Judy Marie Delos Reyes on January 25, 2022

Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPennies.Text = String.Empty
        lblDollars.Text = String.Empty
        lblQuarters.Text = String.Empty
        lblDimes.Text = String.Empty
        lblNickels.Text = String.Empty
        lblPennies.Text = String.Empty

        ' focus to Amt of Pennies box
        txtPennies.Focus()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'calculate # of dollars quarters dimes nickles and pennies

        'declare variables
        Dim intDollars As Integer
        Dim intQuarters As Integer
        Dim intDimes As Integer
        Dim intNickels As Integer
        Dim intPennies As Integer

        'calculate n display total # of dollars dimes nickles and pennies
        Integer.TryParse(txtPennies.Text, intDollars)
        intDollars = txtPennies.Text \ 100
        lblDollars.Text = Convert.ToString(intDollars)

        Integer.TryParse(txtPennies.Text, intQuarters)
        intQuarters = (txtPennies.Text - lblDollars.Text * 100) \ 25
        lblQuarters.Text = Convert.ToString(intQuarters)

        Integer.TryParse(txtPennies.Text, intDimes)
        intDimes = (txtPennies.Text Mod 25) \ 10
        lblDimes.Text = Convert.ToString(intDimes)

        Integer.TryParse(txtPennies.Text, intNickels)
        intNickels = (txtPennies.Text - (lblDollars.Text * 100) - (lblQuarters.Text * 25) - (lblDimes.Text * 10)) \ 5
        lblNickels.Text = Convert.ToString(intNickels)

        Integer.TryParse(txtPennies.Text, intPennies)
        intPennies = (txtPennies.Text - (lblDollars.Text * 100) - (lblQuarters.Text * 25) - (lblDimes.Text * 10) - (lblNickels.Text * 5)) \ 1
        lblPennies.Text = Convert.ToString(intPennies)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
