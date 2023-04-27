<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStats
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
        Me.ListBox_Name = New System.Windows.Forms.ListBox()
        Me.ListBox_Score = New System.Windows.Forms.ListBox()
        Me.ListBox_Pattern = New System.Windows.Forms.ListBox()
        Me.ListBox_deviner = New System.Windows.Forms.ListBox()
        Me.ListBox_time = New System.Windows.Forms.ListBox()
        Me.Sort_alpha = New System.Windows.Forms.Button()
        Me.button_return = New System.Windows.Forms.Button()
        Me.Button_score = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.button_time = New System.Windows.Forms.Button()
        Me.ListBox_CumuleTemps = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox_Name
        '
        Me.ListBox_Name.FormattingEnabled = True
        Me.ListBox_Name.ItemHeight = 16
        Me.ListBox_Name.Location = New System.Drawing.Point(12, 47)
        Me.ListBox_Name.Name = "ListBox_Name"
        Me.ListBox_Name.Size = New System.Drawing.Size(170, 404)
        Me.ListBox_Name.TabIndex = 0
        '
        'ListBox_Score
        '
        Me.ListBox_Score.FormattingEnabled = True
        Me.ListBox_Score.ItemHeight = 16
        Me.ListBox_Score.Location = New System.Drawing.Point(221, 47)
        Me.ListBox_Score.Name = "ListBox_Score"
        Me.ListBox_Score.Size = New System.Drawing.Size(170, 404)
        Me.ListBox_Score.TabIndex = 1
        '
        'ListBox_Pattern
        '
        Me.ListBox_Pattern.FormattingEnabled = True
        Me.ListBox_Pattern.ItemHeight = 16
        Me.ListBox_Pattern.Location = New System.Drawing.Point(419, 47)
        Me.ListBox_Pattern.Name = "ListBox_Pattern"
        Me.ListBox_Pattern.Size = New System.Drawing.Size(170, 404)
        Me.ListBox_Pattern.TabIndex = 2
        '
        'ListBox_deviner
        '
        Me.ListBox_deviner.FormattingEnabled = True
        Me.ListBox_deviner.ItemHeight = 16
        Me.ListBox_deviner.Location = New System.Drawing.Point(635, 47)
        Me.ListBox_deviner.Name = "ListBox_deviner"
        Me.ListBox_deviner.Size = New System.Drawing.Size(170, 404)
        Me.ListBox_deviner.TabIndex = 3
        '
        'ListBox_time
        '
        Me.ListBox_time.FormattingEnabled = True
        Me.ListBox_time.ItemHeight = 16
        Me.ListBox_time.Location = New System.Drawing.Point(840, 47)
        Me.ListBox_time.Name = "ListBox_time"
        Me.ListBox_time.Size = New System.Drawing.Size(170, 404)
        Me.ListBox_time.TabIndex = 4
        '
        'Sort_alpha
        '
        Me.Sort_alpha.Location = New System.Drawing.Point(29, 480)
        Me.Sort_alpha.Name = "Sort_alpha"
        Me.Sort_alpha.Size = New System.Drawing.Size(222, 40)
        Me.Sort_alpha.TabIndex = 5
        Me.Sort_alpha.Text = "Par l'order alphabétique"
        Me.Sort_alpha.UseVisualStyleBackColor = True
        '
        'button_return
        '
        Me.button_return.Location = New System.Drawing.Point(1010, 480)
        Me.button_return.Name = "button_return"
        Me.button_return.Size = New System.Drawing.Size(222, 40)
        Me.button_return.TabIndex = 6
        Me.button_return.Text = "Retour"
        Me.button_return.UseVisualStyleBackColor = True
        '
        'Button_score
        '
        Me.Button_score.Location = New System.Drawing.Point(273, 480)
        Me.Button_score.Name = "Button_score"
        Me.Button_score.Size = New System.Drawing.Size(222, 40)
        Me.Button_score.TabIndex = 7
        Me.Button_score.Text = "Par score"
        Me.Button_score.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Partie Pattern"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(686, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Partie deviner"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(898, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Le temps"
        '
        'button_time
        '
        Me.button_time.Location = New System.Drawing.Point(517, 480)
        Me.button_time.Name = "button_time"
        Me.button_time.Size = New System.Drawing.Size(222, 40)
        Me.button_time.TabIndex = 13
        Me.button_time.Text = "Par temps"
        Me.button_time.UseVisualStyleBackColor = True
        '
        'ListBox_CumuleTemps
        '
        Me.ListBox_CumuleTemps.FormattingEnabled = True
        Me.ListBox_CumuleTemps.ItemHeight = 16
        Me.ListBox_CumuleTemps.Location = New System.Drawing.Point(1062, 47)
        Me.ListBox_CumuleTemps.Name = "ListBox_CumuleTemps"
        Me.ListBox_CumuleTemps.Size = New System.Drawing.Size(170, 404)
        Me.ListBox_CumuleTemps.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1095, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Le cumul temps"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(759, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Par cumule temps"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 532)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox_CumuleTemps)
        Me.Controls.Add(Me.button_time)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_score)
        Me.Controls.Add(Me.button_return)
        Me.Controls.Add(Me.Sort_alpha)
        Me.Controls.Add(Me.ListBox_time)
        Me.Controls.Add(Me.ListBox_deviner)
        Me.Controls.Add(Me.ListBox_Pattern)
        Me.Controls.Add(Me.ListBox_Score)
        Me.Controls.Add(Me.ListBox_Name)
        Me.Name = "FormStats"
        Me.Text = "FromStats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Name As ListBox
    Friend WithEvents ListBox_Score As ListBox
    Friend WithEvents ListBox_Pattern As ListBox
    Friend WithEvents ListBox_deviner As ListBox
    Friend WithEvents ListBox_time As ListBox
    Friend WithEvents Sort_alpha As Button
    Friend WithEvents button_return As Button
    Friend WithEvents Button_score As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents button_time As Button
    Friend WithEvents ListBox_CumuleTemps As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
