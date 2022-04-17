<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainFrm
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
        Me.btnClearJD = New System.Windows.Forms.Button()
        Me.btnExitJD = New System.Windows.Forms.Button()
        Me.txtRedJD = New System.Windows.Forms.TextBox()
        Me.txtYellowJD = New System.Windows.Forms.TextBox()
        Me.txtGreenJD = New System.Windows.Forms.TextBox()
        Me.btnRedJD = New System.Windows.Forms.Button()
        Me.btnYellowJD = New System.Windows.Forms.Button()
        Me.btnGreenJD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(96, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Italian word then click the color button."
        '
        'btnClearJD
        '
        Me.btnClearJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearJD.Location = New System.Drawing.Point(426, 82)
        Me.btnClearJD.Name = "btnClearJD"
        Me.btnClearJD.Size = New System.Drawing.Size(75, 29)
        Me.btnClearJD.TabIndex = 1
        Me.btnClearJD.Text = "&Clear"
        Me.btnClearJD.UseVisualStyleBackColor = True
        '
        'btnExitJD
        '
        Me.btnExitJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExitJD.Location = New System.Drawing.Point(426, 119)
        Me.btnExitJD.Name = "btnExitJD"
        Me.btnExitJD.Size = New System.Drawing.Size(75, 29)
        Me.btnExitJD.TabIndex = 2
        Me.btnExitJD.Text = "E&xit"
        Me.btnExitJD.UseVisualStyleBackColor = True
        '
        'txtRedJD
        '
        Me.txtRedJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRedJD.Location = New System.Drawing.Point(31, 83)
        Me.txtRedJD.Name = "txtRedJD"
        Me.txtRedJD.Size = New System.Drawing.Size(100, 29)
        Me.txtRedJD.TabIndex = 3
        Me.txtRedJD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYellowJD
        '
        Me.txtYellowJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtYellowJD.Location = New System.Drawing.Point(137, 83)
        Me.txtYellowJD.Name = "txtYellowJD"
        Me.txtYellowJD.Size = New System.Drawing.Size(100, 29)
        Me.txtYellowJD.TabIndex = 4
        Me.txtYellowJD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGreenJD
        '
        Me.txtGreenJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGreenJD.Location = New System.Drawing.Point(243, 83)
        Me.txtGreenJD.Name = "txtGreenJD"
        Me.txtGreenJD.Size = New System.Drawing.Size(100, 29)
        Me.txtGreenJD.TabIndex = 5
        Me.txtGreenJD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRedJD
        '
        Me.btnRedJD.AllowDrop = True
        Me.btnRedJD.AutoSize = True
        Me.btnRedJD.BackColor = System.Drawing.Color.Red
        Me.btnRedJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRedJD.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRedJD.Location = New System.Drawing.Point(31, 118)
        Me.btnRedJD.Name = "btnRedJD"
        Me.btnRedJD.Size = New System.Drawing.Size(100, 31)
        Me.btnRedJD.TabIndex = 6
        Me.btnRedJD.Text = "&Red"
        Me.btnRedJD.UseVisualStyleBackColor = False
        '
        'btnYellowJD
        '
        Me.btnYellowJD.AllowDrop = True
        Me.btnYellowJD.AutoSize = True
        Me.btnYellowJD.BackColor = System.Drawing.Color.Yellow
        Me.btnYellowJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnYellowJD.Location = New System.Drawing.Point(137, 118)
        Me.btnYellowJD.Name = "btnYellowJD"
        Me.btnYellowJD.Size = New System.Drawing.Size(100, 31)
        Me.btnYellowJD.TabIndex = 7
        Me.btnYellowJD.Text = "&Yellow"
        Me.btnYellowJD.UseVisualStyleBackColor = False
        '
        'btnGreenJD
        '
        Me.btnGreenJD.AllowDrop = True
        Me.btnGreenJD.AutoSize = True
        Me.btnGreenJD.BackColor = System.Drawing.Color.Lime
        Me.btnGreenJD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGreenJD.Location = New System.Drawing.Point(243, 118)
        Me.btnGreenJD.Name = "btnGreenJD"
        Me.btnGreenJD.Size = New System.Drawing.Size(100, 31)
        Me.btnGreenJD.TabIndex = 8
        Me.btnGreenJD.Text = "&Green"
        Me.btnGreenJD.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 201)
        Me.Controls.Add(Me.btnGreenJD)
        Me.Controls.Add(Me.btnYellowJD)
        Me.Controls.Add(Me.btnRedJD)
        Me.Controls.Add(Me.txtGreenJD)
        Me.Controls.Add(Me.txtYellowJD)
        Me.Controls.Add(Me.txtRedJD)
        Me.Controls.Add(Me.btnExitJD)
        Me.Controls.Add(Me.btnClearJD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Italian Colors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearJD As Button
    Friend WithEvents btnExitJD As Button
    Friend WithEvents txtRedJD As TextBox
    Friend WithEvents txtYellowJD As TextBox
    Friend WithEvents txtGreenJD As TextBox
    Friend WithEvents btnRedJD As Button
    Friend WithEvents btnYellowJD As Button
    Friend WithEvents btnGreenJD As Button
End Class
