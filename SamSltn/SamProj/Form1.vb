' Name: Sam's Project
' Purpose: Displays total amount customer owes and if quantity is over 5, the customer is given a 15% discount.
' February 11, 2022

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnCalculateJD_Click(sender As Object, e As EventArgs) Handles btnCalculateJD.Click
        ' variables
        Dim dblPrice, dblTotal As Double
        Dim intQuant As Integer

        ' hold em
        Double.TryParse(lblTotalJD.Text, dblTotal)
        Double.TryParse(txtPriceJD.Text, dblPrice)
        Integer.TryParse(txtQuantityJD.Text, intQuant)

        ' calculate total owed
        If intQuant > 5 Then
            dblTotal = dblPrice * intQuant * (1 - 0.15)
        Else
            dblTotal = dblPrice * intQuant
        End If

        dblTotal.ToString("c2")
        lblTotalJD.Text = Convert.ToString(dblTotal)

    End Sub

    Private Sub btnClearJD_Click(sender As Object, e As EventArgs) Handles btnClearJD.Click
        txtPriceJD.Text = String.Empty
        txtQuantityJD.Text = String.Empty
        lblTotalJD.Text = String.Empty

        'focus to price txt box
        txtPriceJD.Focus()
    End Sub

    Private Sub btnExitJD_Click(sender As Object, e As EventArgs) Handles btnExitJD.Click
        Me.Close()
    End Sub
End Class
