' Name: Colors Project
' Purpose: Enter colors in Italian to change txtBox color
' February 25, 2022

Option Explicit On
Option Infer Off
Option Strict On

Public Class mainFrm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClearJD_Click(sender As Object, e As EventArgs) Handles btnClearJD.Click

        txtRedJD.Text = String.Empty
        txtYellowJD.Text = String.Empty
        txtGreenJD.Text = String.Empty

        ' changes txtBox color back to default
        txtRedJD.BackColor = Color.Empty
        txtYellowJD.BackColor = Color.Empty
        txtGreenJD.BackColor = Color.Empty

    End Sub

    Private Sub btnExitJD_Click(sender As Object, e As EventArgs) Handles btnExitJD.Click
        Me.Close()
    End Sub

    Private Sub btnRedJD_Click(sender As Object, e As EventArgs) Handles btnRedJD.Click
        Dim strRedJD As String

        strRedJD = "Rosso"

        If (txtRedJD.Text <> strRedJD) Then
            MessageBox.Show(strRedJD, "Italian Color Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtRedJD.BackColor = Color.Red

            ' change text color for better visibility
            txtRedJD.ForeColor = Color.AntiqueWhite
        End If

    End Sub

    Private Sub btnYellowJD_Click(sender As Object, e As EventArgs) Handles btnYellowJD.Click
        Dim strYellowJD As String

        strYellowJD = "Giallo"

        If (txtYellowJD.Text <> strYellowJD) Then
            MessageBox.Show(strYellowJD, "Italian Color Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtYellowJD.BackColor = Color.Yellow
        End If

    End Sub

    Private Sub btnGreenJD_Click(sender As Object, e As EventArgs) Handles btnGreenJD.Click
        Dim strGreenJD As String

        strGreenJD = "Verde"

        If (txtGreenJD.Text <> strGreenJD) Then
            MessageBox.Show(strGreenJD, "Italian Color Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtGreenJD.BackColor = Color.Green

            ' change text color for better visibility
            txtGreenJD.ForeColor = Color.AntiqueWhite
        End If

    End Sub
End Class
