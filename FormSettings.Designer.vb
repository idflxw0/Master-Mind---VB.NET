<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.button_no = New System.Windows.Forms.RadioButton()
        Me.button_yes = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.color_panel = New System.Windows.Forms.Panel()
        Me.color_button_no = New System.Windows.Forms.RadioButton()
        Me.color_button_yes = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label_PBP = New System.Windows.Forms.Label()
        Me.label_present = New System.Windows.Forms.Label()
        Me.label_absent = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.button_save = New System.Windows.Forms.Button()
        Me.button_return = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.color_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.button_no)
        Me.Panel1.Controls.Add(Me.button_yes)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(30, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 113)
        Me.Panel1.TabIndex = 0
        '
        'button_no
        '
        Me.button_no.AutoSize = True
        Me.button_no.Location = New System.Drawing.Point(142, 37)
        Me.button_no.Name = "button_no"
        Me.button_no.Size = New System.Drawing.Size(53, 20)
        Me.button_no.TabIndex = 5
        Me.button_no.TabStop = True
        Me.button_no.Text = "Non"
        Me.button_no.UseVisualStyleBackColor = True
        '
        'button_yes
        '
        Me.button_yes.AutoSize = True
        Me.button_yes.Location = New System.Drawing.Point(38, 37)
        Me.button_yes.Name = "button_yes"
        Me.button_yes.Size = New System.Drawing.Size(48, 20)
        Me.button_yes.TabIndex = 4
        Me.button_yes.TabStop = True
        Me.button_yes.Text = "Oui"
        Me.button_yes.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 76)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Modifer les caractères utilisables"
        '
        'color_panel
        '
        Me.color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.color_panel.Controls.Add(Me.color_button_no)
        Me.color_panel.Controls.Add(Me.color_button_yes)
        Me.color_panel.Controls.Add(Me.Button3)
        Me.color_panel.Controls.Add(Me.Button2)
        Me.color_panel.Controls.Add(Me.Button1)
        Me.color_panel.Controls.Add(Me.label_PBP)
        Me.color_panel.Controls.Add(Me.label_present)
        Me.color_panel.Controls.Add(Me.label_absent)
        Me.color_panel.Controls.Add(Me.Label2)
        Me.color_panel.Location = New System.Drawing.Point(461, 21)
        Me.color_panel.Name = "color_panel"
        Me.color_panel.Size = New System.Drawing.Size(327, 203)
        Me.color_panel.TabIndex = 1
        '
        'color_button_no
        '
        Me.color_button_no.AutoSize = True
        Me.color_button_no.Location = New System.Drawing.Point(192, 37)
        Me.color_button_no.Name = "color_button_no"
        Me.color_button_no.Size = New System.Drawing.Size(53, 20)
        Me.color_button_no.TabIndex = 7
        Me.color_button_no.TabStop = True
        Me.color_button_no.Text = "Non"
        Me.color_button_no.UseVisualStyleBackColor = True
        '
        'color_button_yes
        '
        Me.color_button_yes.AutoSize = True
        Me.color_button_yes.Location = New System.Drawing.Point(88, 37)
        Me.color_button_yes.Name = "color_button_yes"
        Me.color_button_yes.Size = New System.Drawing.Size(48, 20)
        Me.color_button_yes.TabIndex = 6
        Me.color_button_yes.TabStop = True
        Me.color_button_yes.Text = "Oui"
        Me.color_button_yes.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(38, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "PBP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Présent"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Absent"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label_PBP
        '
        Me.label_PBP.AutoSize = True
        Me.label_PBP.Location = New System.Drawing.Point(178, 175)
        Me.label_PBP.Name = "label_PBP"
        Me.label_PBP.Size = New System.Drawing.Size(135, 16)
        Me.label_PBP.TabIndex = 7
        Me.label_PBP.Text = "Présent et Bien Placé"
        '
        'label_present
        '
        Me.label_present.AutoSize = True
        Me.label_present.Location = New System.Drawing.Point(221, 138)
        Me.label_present.Name = "label_present"
        Me.label_present.Size = New System.Drawing.Size(53, 16)
        Me.label_present.TabIndex = 6
        Me.label_present.Text = "Présent"
        '
        'label_absent
        '
        Me.label_absent.AutoSize = True
        Me.label_absent.Location = New System.Drawing.Point(225, 96)
        Me.label_absent.Name = "label_absent"
        Me.label_absent.Size = New System.Drawing.Size(49, 16)
        Me.label_absent.TabIndex = 5
        Me.label_absent.Text = "Absent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Modifer les couleurs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'button_save
        '
        Me.button_save.Location = New System.Drawing.Point(187, 390)
        Me.button_save.Name = "button_save"
        Me.button_save.Size = New System.Drawing.Size(92, 33)
        Me.button_save.TabIndex = 2
        Me.button_save.Text = "Valider"
        Me.button_save.UseVisualStyleBackColor = True
        '
        'button_return
        '
        Me.button_return.Location = New System.Drawing.Point(392, 390)
        Me.button_return.Name = "button_return"
        Me.button_return.Size = New System.Drawing.Size(92, 33)
        Me.button_return.TabIndex = 3
        Me.button_return.Text = "Retour"
        Me.button_return.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button_return)
        Me.Controls.Add(Me.button_save)
        Me.Controls.Add(Me.color_panel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSettings"
        Me.Text = "FromSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.color_panel.ResumeLayout(False)
        Me.color_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents color_panel As Panel
    Friend WithEvents label_PBP As Label
    Friend WithEvents label_present As Label
    Friend WithEvents label_absent As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents button_no As RadioButton
    Friend WithEvents button_yes As RadioButton
    Friend WithEvents button_save As Button
    Friend WithEvents button_return As Button
    Friend WithEvents color_button_no As RadioButton
    Friend WithEvents color_button_yes As RadioButton
End Class
