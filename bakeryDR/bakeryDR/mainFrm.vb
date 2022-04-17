Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTotalItems.Text = Val(txtDonut.Text) + Val(txtWaffle.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
        'Format number to currency
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWaffle.Text = String.Empty
        txtDonut.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblTotalItems.Text = String.Empty
        'send focus to donut box
        txtDonut.Focus()
    End Sub
End Class
