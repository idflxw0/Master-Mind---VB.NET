<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
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
        Me.title_label = New System.Windows.Forms.Label()
        Me.player1 = New System.Windows.Forms.Label()
        Me.player2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.indication = New System.Windows.Forms.Label()
        Me.indication_2 = New System.Windows.Forms.Label()
        Me.error_label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttons_stats = New System.Windows.Forms.Button()
        Me.button_settings = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_label.Location = New System.Drawing.Point(322, 9)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(113, 20)
        Me.title_label.TabIndex = 0
        Me.title_label.Text = "Master Mind"
        '
        'player1
        '
        Me.player1.AutoSize = True
        Me.player1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1.Location = New System.Drawing.Point(133, 128)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(74, 20)
        Me.player1.TabIndex = 1
        Me.player1.Text = "Joueur 1"
        '
        'player2
        '
        Me.player2.AutoSize = True
        Me.player2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2.Location = New System.Drawing.Point(554, 128)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(74, 20)
        Me.player2.TabIndex = 2
        Me.player2.Text = "Joueur 2"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(528, 195)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 4
        '
        'indication
        '
        Me.indication.AutoSize = True
        Me.indication.Location = New System.Drawing.Point(124, 172)
        Me.indication.Name = "indication"
        Me.indication.Size = New System.Drawing.Size(94, 16)
        Me.indication.TabIndex = 5
        Me.indication.Text = "Crée le pattern"
        '
        'indication_2
        '
        Me.indication_2.AutoSize = True
        Me.indication_2.Location = New System.Drawing.Point(529, 172)
        Me.indication_2.Name = "indication_2"
        Me.indication_2.Size = New System.Drawing.Size(120, 16)
        Me.indication_2.TabIndex = 6
        Me.indication_2.Text = "Devenier le pattern"
        '
        'error_label
        '
        Me.error_label.AutoSize = True
        Me.error_label.ForeColor = System.Drawing.Color.Red
        Me.error_label.Location = New System.Drawing.Point(181, 248)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(419, 16)
        Me.error_label.TabIndex = 7
        Me.error_label.Text = "le nom des deux joueurs doit être différent pour commencer une partie"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Lancer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttons_stats
        '
        Me.buttons_stats.Location = New System.Drawing.Point(501, 290)
        Me.buttons_stats.Name = "buttons_stats"
        Me.buttons_stats.Size = New System.Drawing.Size(163, 30)
        Me.buttons_stats.TabIndex = 9
        Me.buttons_stats.Text = "Voir les statistiques"
        Me.buttons_stats.UseVisualStyleBackColor = True
        '
        'button_settings
        '
        Me.button_settings.Location = New System.Drawing.Point(164, 290)
        Me.button_settings.Name = "button_settings"
        Me.button_settings.Size = New System.Drawing.Size(97, 30)
        Me.button_settings.TabIndex = 10
        Me.button_settings.Text = "Paramètres"
        Me.button_settings.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(326, 390)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 48)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Quitter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.button_settings)
        Me.Controls.Add(Me.buttons_stats)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.error_label)
        Me.Controls.Add(Me.indication_2)
        Me.Controls.Add(Me.indication)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.title_label)
        Me.Name = "FormAccueil"
        Me.Text = "FormAccueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title_label As Label
    Friend WithEvents player1 As Label
    Friend WithEvents player2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents indication As Label
    Friend WithEvents indication_2 As Label
    Friend WithEvents error_label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents buttons_stats As Button
    Friend WithEvents button_settings As Button
    Friend WithEvents Button4 As Button
End Class
