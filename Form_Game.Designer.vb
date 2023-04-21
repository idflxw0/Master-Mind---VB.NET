<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Game
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Guess_Button = New System.Windows.Forms.Button()
        Me.label_codeColor = New System.Windows.Forms.Label()
        Me.absent_label = New System.Windows.Forms.Label()
        Me.present_label = New System.Windows.Forms.Label()
        Me.PB_label = New System.Windows.Forms.Label()
        Me.playable_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guess_Button)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(21, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 91)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(63, 22)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(178, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 22)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(265, 33)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(63, 22)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(344, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(63, 22)
        Me.TextBox5.TabIndex = 4
        '
        'Guess_Button
        '
        Me.Guess_Button.Location = New System.Drawing.Point(426, 32)
        Me.Guess_Button.Name = "Guess_Button"
        Me.Guess_Button.Size = New System.Drawing.Size(75, 23)
        Me.Guess_Button.TabIndex = 5
        Me.Guess_Button.Text = "Guess"
        Me.Guess_Button.UseVisualStyleBackColor = True
        '
        'label_codeColor
        '
        Me.label_codeColor.AutoSize = True
        Me.label_codeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_codeColor.Location = New System.Drawing.Point(353, 168)
        Me.label_codeColor.Name = "label_codeColor"
        Me.label_codeColor.Size = New System.Drawing.Size(112, 18)
        Me.label_codeColor.TabIndex = 1
        Me.label_codeColor.Text = "Code Couleur"
        '
        'absent_label
        '
        Me.absent_label.AutoSize = True
        Me.absent_label.Location = New System.Drawing.Point(362, 204)
        Me.absent_label.Name = "absent_label"
        Me.absent_label.Size = New System.Drawing.Size(49, 16)
        Me.absent_label.TabIndex = 2
        Me.absent_label.Text = "Absent"
        '
        'present_label
        '
        Me.present_label.AutoSize = True
        Me.present_label.ForeColor = System.Drawing.Color.Blue
        Me.present_label.Location = New System.Drawing.Point(363, 220)
        Me.present_label.Name = "present_label"
        Me.present_label.Size = New System.Drawing.Size(53, 16)
        Me.present_label.TabIndex = 3
        Me.present_label.Text = "Présent"
        '
        'PB_label
        '
        Me.PB_label.AutoSize = True
        Me.PB_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PB_label.Location = New System.Drawing.Point(362, 236)
        Me.PB_label.Name = "PB_label"
        Me.PB_label.Size = New System.Drawing.Size(135, 16)
        Me.PB_label.TabIndex = 4
        Me.PB_label.Text = "Présent et Bien Placé"
        '
        'playable_label
        '
        Me.playable_label.AutoSize = True
        Me.playable_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playable_label.Location = New System.Drawing.Point(353, 304)
        Me.playable_label.Name = "playable_label"
        Me.playable_label.Size = New System.Drawing.Size(159, 18)
        Me.playable_label.TabIndex = 5
        Me.playable_label.Text = "Caractères jouables"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "# $ £ % @"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Précédents essais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Master Mind"
        '
        'Form_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 590)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playable_label)
        Me.Controls.Add(Me.PB_label)
        Me.Controls.Add(Me.present_label)
        Me.Controls.Add(Me.absent_label)
        Me.Controls.Add(Me.label_codeColor)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Game"
        Me.Text = "Form_Game"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guess_Button As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents label_codeColor As Label
    Friend WithEvents absent_label As Label
    Friend WithEvents present_label As Label
    Friend WithEvents PB_label As Label
    Friend WithEvents playable_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
