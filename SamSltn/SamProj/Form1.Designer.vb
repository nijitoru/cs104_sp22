<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPriceJD = New System.Windows.Forms.TextBox()
        Me.txtQuantityJD = New System.Windows.Forms.TextBox()
        Me.btnCalculateJD = New System.Windows.Forms.Button()
        Me.btnClearJD = New System.Windows.Forms.Button()
        Me.btnExitJD = New System.Windows.Forms.Button()
        Me.lblTotalJD = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPriceJD
        '
        Me.txtPriceJD.Location = New System.Drawing.Point(97, 51)
        Me.txtPriceJD.Name = "txtPriceJD"
        Me.txtPriceJD.Size = New System.Drawing.Size(100, 23)
        Me.txtPriceJD.TabIndex = 0
        '
        'txtQuantityJD
        '
        Me.txtQuantityJD.Location = New System.Drawing.Point(97, 80)
        Me.txtQuantityJD.Name = "txtQuantityJD"
        Me.txtQuantityJD.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantityJD.TabIndex = 1
        '
        'btnCalculateJD
        '
        Me.btnCalculateJD.Location = New System.Drawing.Point(259, 79)
        Me.btnCalculateJD.Name = "btnCalculateJD"
        Me.btnCalculateJD.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateJD.TabIndex = 2
        Me.btnCalculateJD.Text = "&Calculate"
        Me.btnCalculateJD.UseVisualStyleBackColor = True
        '
        'btnClearJD
        '
        Me.btnClearJD.Location = New System.Drawing.Point(259, 108)
        Me.btnClearJD.Name = "btnClearJD"
        Me.btnClearJD.Size = New System.Drawing.Size(75, 23)
        Me.btnClearJD.TabIndex = 3
        Me.btnClearJD.Text = "C&lear"
        Me.btnClearJD.UseVisualStyleBackColor = True
        '
        'btnExitJD
        '
        Me.btnExitJD.Location = New System.Drawing.Point(259, 137)
        Me.btnExitJD.Name = "btnExitJD"
        Me.btnExitJD.Size = New System.Drawing.Size(75, 23)
        Me.btnExitJD.TabIndex = 4
        Me.btnExitJD.Text = "E&xit"
        Me.btnExitJD.UseVisualStyleBackColor = True
        '
        'lblTotalJD
        '
        Me.lblTotalJD.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalJD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalJD.Location = New System.Drawing.Point(97, 137)
        Me.lblTotalJD.Name = "lblTotalJD"
        Me.lblTotalJD.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalJD.TabIndex = 5
        Me.lblTotalJD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Price:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantity:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 231)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalJD)
        Me.Controls.Add(Me.btnExitJD)
        Me.Controls.Add(Me.btnClearJD)
        Me.Controls.Add(Me.btnCalculateJD)
        Me.Controls.Add(Me.txtQuantityJD)
        Me.Controls.Add(Me.txtPriceJD)
        Me.Name = "Form1"
        Me.Text = "Sam's Paper Shoppe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPriceJD As TextBox
    Friend WithEvents txtQuantityJD As TextBox
    Friend WithEvents btnCalculateJD As Button
    Friend WithEvents btnClearJD As Button
    Friend WithEvents btnExitJD As Button
    Friend WithEvents lblTotalJD As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
