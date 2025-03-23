<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.Saladbutton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Script MT Bold", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(208, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(360, 67)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "Hogan's Diner"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(12, 90)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(776, 229)
        Me.DisplaySpecialLabel.TabIndex = 1
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.SoupButton.Font = New System.Drawing.Font("Magneto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(44, 322)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(159, 116)
        Me.SoupButton.TabIndex = 2
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'Saladbutton
        '
        Me.Saladbutton.BackColor = System.Drawing.Color.SeaGreen
        Me.Saladbutton.Font = New System.Drawing.Font("Magneto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saladbutton.Location = New System.Drawing.Point(230, 322)
        Me.Saladbutton.Name = "Saladbutton"
        Me.Saladbutton.Size = New System.Drawing.Size(159, 116)
        Me.Saladbutton.TabIndex = 3
        Me.Saladbutton.Text = "Salad"
        Me.Saladbutton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FishButton.Font = New System.Drawing.Font("Magneto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(418, 322)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(159, 116)
        Me.FishButton.TabIndex = 4
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ExitButton.Font = New System.Drawing.Font("Magneto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(604, 322)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(159, 116)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DinerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.Saladbutton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "DinerMenu"
        Me.Text = "Diner Menu"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents Saladbutton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
End Class
