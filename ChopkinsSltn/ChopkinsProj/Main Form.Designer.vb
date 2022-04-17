<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.txtTwelve = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.btnCalcJMDR = New System.Windows.Forms.Button()
        Me.btnClearJMDR = New System.Windows.Forms.Button()
        Me.btnExitJMDR = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(167, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(51, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Date Ordered:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(167, 92)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 23)
        Me.txtDate.TabIndex = 2
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(89, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&12 Pack:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(98, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&5 Pack:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(98, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "&2 Pack:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(83, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sale Total:"
        '
        'lblSale
        '
        Me.lblSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSale.Location = New System.Drawing.Point(167, 257)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(100, 23)
        Me.lblSale.TabIndex = 7
        Me.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(167, 183)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(100, 23)
        Me.txtFive.TabIndex = 9
        Me.txtFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTwelve
        '
        Me.txtTwelve.Location = New System.Drawing.Point(167, 147)
        Me.txtTwelve.Name = "txtTwelve"
        Me.txtTwelve.Size = New System.Drawing.Size(100, 23)
        Me.txtTwelve.TabIndex = 10
        Me.txtTwelve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(167, 218)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(100, 23)
        Me.txtTwo.TabIndex = 11
        Me.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcJMDR
        '
        Me.btnCalcJMDR.AutoSize = True
        Me.btnCalcJMDR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcJMDR.Location = New System.Drawing.Point(95, 342)
        Me.btnCalcJMDR.Name = "btnCalcJMDR"
        Me.btnCalcJMDR.Size = New System.Drawing.Size(85, 31)
        Me.btnCalcJMDR.TabIndex = 13
        Me.btnCalcJMDR.Text = "&Calculate"
        Me.btnCalcJMDR.UseVisualStyleBackColor = True
        '
        'btnClearJMDR
        '
        Me.btnClearJMDR.AutoSize = True
        Me.btnClearJMDR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearJMDR.Location = New System.Drawing.Point(186, 342)
        Me.btnClearJMDR.Name = "btnClearJMDR"
        Me.btnClearJMDR.Size = New System.Drawing.Size(75, 31)
        Me.btnClearJMDR.TabIndex = 14
        Me.btnClearJMDR.Text = "C&lear"
        Me.btnClearJMDR.UseVisualStyleBackColor = True
        '
        'btnExitJMDR
        '
        Me.btnExitJMDR.AutoSize = True
        Me.btnExitJMDR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExitJMDR.Location = New System.Drawing.Point(267, 342)
        Me.btnExitJMDR.Name = "btnExitJMDR"
        Me.btnExitJMDR.Size = New System.Drawing.Size(75, 31)
        Me.btnExitJMDR.TabIndex = 15
        Me.btnExitJMDR.Text = "E&xit"
        Me.btnExitJMDR.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Info
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(273, 257)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 16
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 418)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnExitJMDR)
        Me.Controls.Add(Me.btnClearJMDR)
        Me.Controls.Add(Me.btnCalcJMDR)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtTwelve)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Chopkins Toys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSale As Label
    Friend WithEvents txtFive As TextBox
    Friend WithEvents txtTwelve As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents btnCalcJMDR As Button
    Friend WithEvents btnClearJMDR As Button
    Friend WithEvents btnExitJMDR As Button
    Friend WithEvents lblPrice As Label
End Class
