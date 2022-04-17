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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(88, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter A&mount of Pennies:"
        '
        'txtPennies
        '
        Me.txtPennies.BackColor = System.Drawing.SystemColors.Info
        Me.txtPennies.Location = New System.Drawing.Point(268, 42)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(100, 23)
        Me.txtPennies.TabIndex = 1
        Me.txtPennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(45, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dollars:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDollars
        '
        Me.lblDollars.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblDollars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDollars.Location = New System.Drawing.Point(45, 116)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(100, 23)
        Me.lblDollars.TabIndex = 5
        Me.lblDollars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(194, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Quarters:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuarters
        '
        Me.lblQuarters.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuarters.Location = New System.Drawing.Point(194, 116)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(100, 23)
        Me.lblQuarters.TabIndex = 6
        Me.lblQuarters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(343, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dimes:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDimes
        '
        Me.lblDimes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDimes.Location = New System.Drawing.Point(343, 116)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(100, 23)
        Me.lblDimes.TabIndex = 7
        Me.lblDimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(492, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nickles:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNickels
        '
        Me.lblNickels.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNickels.Location = New System.Drawing.Point(492, 116)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(100, 23)
        Me.lblNickels.TabIndex = 8
        Me.lblNickels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(641, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Pennies:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPennies
        '
        Me.lblPennies.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPennies.Location = New System.Drawing.Point(641, 116)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(100, 23)
        Me.lblPennies.TabIndex = 9
        Me.lblPennies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(509, 35)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 33)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(405, 35)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 33)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Ca&lculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(613, 35)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 186)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Coin Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDollars As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
