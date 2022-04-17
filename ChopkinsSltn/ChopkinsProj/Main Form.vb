Option Explicit On
Option Strict Off
Option Infer Off


' Name: Chopkins Project
' Purpose: Order Packs 
' Programmer: Judy Marie Delos Reyes on January 31, 2022

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcJMDR_Click(sender As Object, e As EventArgs) Handles btnCalcJMDR.Click
        Dim intTwelve, intFive, intTwo As Integer

        Integer.TryParse(txtTwelve.Text, txtFive.Text, txtTwo.Text, intTwelve)
        intTwelve = txtTwelve.Text
    End Sub

    Private Sub btnClearJMDR_Click(sender As Object, e As EventArgs) Handles btnClearJMDR.Click
        ' empty other boxes
        txtTwelve.Text = String.Empty
        txtFive.Text = String.Empty
        txtTwo.Text = String.Empty
        txtDate.Text = String.Empty
        lblPrice.Text = String.Empty
        lblSale.Text = String.Empty

        'focus to date box
        txtDate.Text = String.Empty
    End Sub

    Private Sub btnExitJMDR_Click(sender As Object, e As EventArgs) Handles btnExitJMDR.Click
        Me.Close()
    End Sub

End Class