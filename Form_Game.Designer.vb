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
        Me.components = New System.ComponentModel.Container()
        Me.guess_panel = New System.Windows.Forms.Panel()
        Me.Guess_Button = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label_codeColor = New System.Windows.Forms.Label()
        Me.absent_label = New System.Windows.Forms.Label()
        Me.present_label = New System.Windows.Forms.Label()
        Me.PB_label = New System.Windows.Forms.Label()
        Me.playable_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel_essais = New System.Windows.Forms.Panel()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.button_bye = New System.Windows.Forms.Button()
        Me.label_found = New System.Windows.Forms.Label()
        Me.label_lost = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_label = New System.Windows.Forms.Label()
        Me.label_error_input = New System.Windows.Forms.Label()
        Me.guess_panel.SuspendLayout()
        Me.panel_essais.SuspendLayout()
        Me.SuspendLayout()
        '
        'guess_panel
        '
        Me.guess_panel.Controls.Add(Me.Guess_Button)
        Me.guess_panel.Controls.Add(Me.TextBox5)
        Me.guess_panel.Controls.Add(Me.TextBox4)
        Me.guess_panel.Controls.Add(Me.TextBox3)
        Me.guess_panel.Controls.Add(Me.TextBox2)
        Me.guess_panel.Controls.Add(Me.TextBox1)
        Me.guess_panel.Location = New System.Drawing.Point(28, 63)
        Me.guess_panel.Name = "guess_panel"
        Me.guess_panel.Size = New System.Drawing.Size(513, 91)
        Me.guess_panel.TabIndex = 0
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
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(338, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(63, 22)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(259, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(63, 22)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(187, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 22)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(63, 22)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 22)
        Me.TextBox1.TabIndex = 0
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
        'panel_essais
        '
        Me.panel_essais.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.panel_essais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_essais.Controls.Add(Me.Label74)
        Me.panel_essais.Controls.Add(Me.Label75)
        Me.panel_essais.Controls.Add(Me.Label76)
        Me.panel_essais.Controls.Add(Me.Label77)
        Me.panel_essais.Controls.Add(Me.Label78)
        Me.panel_essais.Controls.Add(Me.Label69)
        Me.panel_essais.Controls.Add(Me.Label70)
        Me.panel_essais.Controls.Add(Me.Label71)
        Me.panel_essais.Controls.Add(Me.Label72)
        Me.panel_essais.Controls.Add(Me.Label73)
        Me.panel_essais.Controls.Add(Me.Label64)
        Me.panel_essais.Controls.Add(Me.Label65)
        Me.panel_essais.Controls.Add(Me.Label66)
        Me.panel_essais.Controls.Add(Me.Label67)
        Me.panel_essais.Controls.Add(Me.Label68)
        Me.panel_essais.Controls.Add(Me.Label59)
        Me.panel_essais.Controls.Add(Me.Label60)
        Me.panel_essais.Controls.Add(Me.Label61)
        Me.panel_essais.Controls.Add(Me.Label62)
        Me.panel_essais.Controls.Add(Me.Label63)
        Me.panel_essais.Controls.Add(Me.Label54)
        Me.panel_essais.Controls.Add(Me.Label55)
        Me.panel_essais.Controls.Add(Me.Label56)
        Me.panel_essais.Controls.Add(Me.Label57)
        Me.panel_essais.Controls.Add(Me.Label58)
        Me.panel_essais.Controls.Add(Me.Label49)
        Me.panel_essais.Controls.Add(Me.Label50)
        Me.panel_essais.Controls.Add(Me.Label51)
        Me.panel_essais.Controls.Add(Me.Label52)
        Me.panel_essais.Controls.Add(Me.Label53)
        Me.panel_essais.Controls.Add(Me.Label44)
        Me.panel_essais.Controls.Add(Me.Label45)
        Me.panel_essais.Controls.Add(Me.Label46)
        Me.panel_essais.Controls.Add(Me.Label47)
        Me.panel_essais.Controls.Add(Me.Label48)
        Me.panel_essais.Controls.Add(Me.Label39)
        Me.panel_essais.Controls.Add(Me.Label40)
        Me.panel_essais.Controls.Add(Me.Label41)
        Me.panel_essais.Controls.Add(Me.Label42)
        Me.panel_essais.Controls.Add(Me.Label43)
        Me.panel_essais.Controls.Add(Me.Label34)
        Me.panel_essais.Controls.Add(Me.Label35)
        Me.panel_essais.Controls.Add(Me.Label36)
        Me.panel_essais.Controls.Add(Me.Label37)
        Me.panel_essais.Controls.Add(Me.Label38)
        Me.panel_essais.Controls.Add(Me.Label29)
        Me.panel_essais.Controls.Add(Me.Label30)
        Me.panel_essais.Controls.Add(Me.Label31)
        Me.panel_essais.Controls.Add(Me.Label32)
        Me.panel_essais.Controls.Add(Me.Label33)
        Me.panel_essais.Controls.Add(Me.Label24)
        Me.panel_essais.Controls.Add(Me.Label25)
        Me.panel_essais.Controls.Add(Me.Label26)
        Me.panel_essais.Controls.Add(Me.Label27)
        Me.panel_essais.Controls.Add(Me.Label28)
        Me.panel_essais.Controls.Add(Me.Label19)
        Me.panel_essais.Controls.Add(Me.Label20)
        Me.panel_essais.Controls.Add(Me.Label21)
        Me.panel_essais.Controls.Add(Me.Label22)
        Me.panel_essais.Controls.Add(Me.Label23)
        Me.panel_essais.Controls.Add(Me.Label14)
        Me.panel_essais.Controls.Add(Me.Label15)
        Me.panel_essais.Controls.Add(Me.Label16)
        Me.panel_essais.Controls.Add(Me.Label17)
        Me.panel_essais.Controls.Add(Me.Label18)
        Me.panel_essais.Controls.Add(Me.Label9)
        Me.panel_essais.Controls.Add(Me.Label10)
        Me.panel_essais.Controls.Add(Me.Label11)
        Me.panel_essais.Controls.Add(Me.Label12)
        Me.panel_essais.Controls.Add(Me.Label13)
        Me.panel_essais.Controls.Add(Me.Label8)
        Me.panel_essais.Controls.Add(Me.Label7)
        Me.panel_essais.Controls.Add(Me.Label6)
        Me.panel_essais.Controls.Add(Me.Label5)
        Me.panel_essais.Controls.Add(Me.Label4)
        Me.panel_essais.Location = New System.Drawing.Point(54, 204)
        Me.panel_essais.Name = "panel_essais"
        Me.panel_essais.Size = New System.Drawing.Size(293, 413)
        Me.panel_essais.TabIndex = 9
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(229, 377)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(55, 16)
        Me.Label74.TabIndex = 74
        Me.Label74.Text = "Label74"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(175, 377)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(55, 16)
        Me.Label75.TabIndex = 73
        Me.Label75.Text = "Label75"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(121, 377)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(55, 16)
        Me.Label76.TabIndex = 72
        Me.Label76.Text = "Label76"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(67, 377)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(55, 16)
        Me.Label77.TabIndex = 71
        Me.Label77.Text = "Label77"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(13, 377)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(55, 16)
        Me.Label78.TabIndex = 70
        Me.Label78.Text = "Label78"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(229, 348)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(55, 16)
        Me.Label69.TabIndex = 69
        Me.Label69.Text = "Label69"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(175, 348)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(55, 16)
        Me.Label70.TabIndex = 68
        Me.Label70.Text = "Label70"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(121, 348)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(55, 16)
        Me.Label71.TabIndex = 67
        Me.Label71.Text = "Label71"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(67, 348)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(55, 16)
        Me.Label72.TabIndex = 66
        Me.Label72.Text = "Label72"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(13, 348)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(55, 16)
        Me.Label73.TabIndex = 65
        Me.Label73.Text = "Label73"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(229, 321)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(55, 16)
        Me.Label64.TabIndex = 64
        Me.Label64.Text = "Label64"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(175, 321)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(55, 16)
        Me.Label65.TabIndex = 63
        Me.Label65.Text = "Label65"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(121, 321)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(55, 16)
        Me.Label66.TabIndex = 62
        Me.Label66.Text = "Label66"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(67, 321)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(55, 16)
        Me.Label67.TabIndex = 61
        Me.Label67.Text = "Label67"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(13, 321)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(55, 16)
        Me.Label68.TabIndex = 60
        Me.Label68.Text = "Label68"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(229, 294)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(55, 16)
        Me.Label59.TabIndex = 59
        Me.Label59.Text = "Label59"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(175, 294)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(55, 16)
        Me.Label60.TabIndex = 58
        Me.Label60.Text = "Label60"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(121, 294)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(55, 16)
        Me.Label61.TabIndex = 57
        Me.Label61.Text = "Label61"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(67, 294)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(55, 16)
        Me.Label62.TabIndex = 56
        Me.Label62.Text = "Label62"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(13, 294)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(55, 16)
        Me.Label63.TabIndex = 55
        Me.Label63.Text = "Label63"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(229, 268)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(55, 16)
        Me.Label54.TabIndex = 54
        Me.Label54.Text = "Label54"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(175, 268)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(55, 16)
        Me.Label55.TabIndex = 53
        Me.Label55.Text = "Label55"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(121, 268)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(55, 16)
        Me.Label56.TabIndex = 52
        Me.Label56.Text = "Label56"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(67, 268)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(55, 16)
        Me.Label57.TabIndex = 51
        Me.Label57.Text = "Label57"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(13, 268)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(55, 16)
        Me.Label58.TabIndex = 50
        Me.Label58.Text = "Label58"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(229, 242)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(55, 16)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "Label49"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(175, 242)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(55, 16)
        Me.Label50.TabIndex = 48
        Me.Label50.Text = "Label50"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(121, 242)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(55, 16)
        Me.Label51.TabIndex = 47
        Me.Label51.Text = "Label51"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(67, 242)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(55, 16)
        Me.Label52.TabIndex = 46
        Me.Label52.Text = "Label52"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(13, 242)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(55, 16)
        Me.Label53.TabIndex = 45
        Me.Label53.Text = "Label53"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(229, 216)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(55, 16)
        Me.Label44.TabIndex = 44
        Me.Label44.Text = "Label44"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(175, 216)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(55, 16)
        Me.Label45.TabIndex = 43
        Me.Label45.Text = "Label45"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(121, 216)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(55, 16)
        Me.Label46.TabIndex = 42
        Me.Label46.Text = "Label46"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(67, 216)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(55, 16)
        Me.Label47.TabIndex = 41
        Me.Label47.Text = "Label47"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(13, 216)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(55, 16)
        Me.Label48.TabIndex = 40
        Me.Label48.Text = "Label48"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(229, 191)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(55, 16)
        Me.Label39.TabIndex = 39
        Me.Label39.Text = "Label39"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(175, 191)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 16)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Label40"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(121, 191)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(55, 16)
        Me.Label41.TabIndex = 37
        Me.Label41.Text = "Label41"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(67, 191)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(55, 16)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "Label42"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(13, 191)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(55, 16)
        Me.Label43.TabIndex = 35
        Me.Label43.Text = "Label43"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(229, 166)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(55, 16)
        Me.Label34.TabIndex = 34
        Me.Label34.Text = "Label34"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(175, 166)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 16)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Label35"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(121, 166)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(55, 16)
        Me.Label36.TabIndex = 32
        Me.Label36.Text = "Label36"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(67, 166)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 16)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = "Label37"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(13, 166)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(55, 16)
        Me.Label38.TabIndex = 30
        Me.Label38.Text = "Label38"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(229, 141)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 16)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "Label29"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(175, 141)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 16)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Label30"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(121, 141)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 16)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "Label31"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(67, 141)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 16)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "Label32"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(13, 141)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(55, 16)
        Me.Label33.TabIndex = 25
        Me.Label33.Text = "Label33"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(229, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 16)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Label24"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(175, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 16)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Label25"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(121, 116)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 16)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Label26"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(67, 116)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 16)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Label27"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 116)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 16)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "Label28"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(229, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(175, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 16)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(121, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(67, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 16)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Label23"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(229, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(175, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(121, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(67, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 16)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Label18"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(229, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(175, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(121, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(67, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Label13"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'button_bye
        '
        Me.button_bye.Location = New System.Drawing.Point(447, 585)
        Me.button_bye.Name = "button_bye"
        Me.button_bye.Size = New System.Drawing.Size(75, 32)
        Me.button_bye.TabIndex = 10
        Me.button_bye.Text = "Bye"
        Me.button_bye.UseVisualStyleBackColor = True
        '
        'label_found
        '
        Me.label_found.AutoSize = True
        Me.label_found.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_found.Location = New System.Drawing.Point(410, 421)
        Me.label_found.Name = "label_found"
        Me.label_found.Size = New System.Drawing.Size(87, 25)
        Me.label_found.TabIndex = 11
        Me.label_found.Text = "Trouvé!"
        '
        'label_lost
        '
        Me.label_lost.AutoSize = True
        Me.label_lost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_lost.ForeColor = System.Drawing.Color.Red
        Me.label_lost.Location = New System.Drawing.Point(410, 464)
        Me.label_lost.Name = "label_lost"
        Me.label_lost.Size = New System.Drawing.Size(76, 25)
        Me.label_lost.TabIndex = 12
        Me.label_lost.Text = "Perdu!"
        '
        'Timer1
        '
        '
        'timer_label
        '
        Me.timer_label.AutoSize = True
        Me.timer_label.Location = New System.Drawing.Point(467, 9)
        Me.timer_label.Name = "timer_label"
        Me.timer_label.Size = New System.Drawing.Size(36, 16)
        Me.timer_label.TabIndex = 13
        Me.timer_label.Text = "timer"
        '
        'label_error_input
        '
        Me.label_error_input.AutoSize = True
        Me.label_error_input.ForeColor = System.Drawing.Color.Red
        Me.label_error_input.Location = New System.Drawing.Point(155, 35)
        Me.label_error_input.Name = "label_error_input"
        Me.label_error_input.Size = New System.Drawing.Size(276, 16)
        Me.label_error_input.TabIndex = 14
        Me.label_error_input.Text = "seulement un seul des caractères autorisées!"
        '
        'Form_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 654)
        Me.Controls.Add(Me.label_error_input)
        Me.Controls.Add(Me.timer_label)
        Me.Controls.Add(Me.label_lost)
        Me.Controls.Add(Me.label_found)
        Me.Controls.Add(Me.button_bye)
        Me.Controls.Add(Me.panel_essais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playable_label)
        Me.Controls.Add(Me.PB_label)
        Me.Controls.Add(Me.present_label)
        Me.Controls.Add(Me.absent_label)
        Me.Controls.Add(Me.label_codeColor)
        Me.Controls.Add(Me.guess_panel)
        Me.Name = "Form_Game"
        Me.Text = "Form_Game"
        Me.guess_panel.ResumeLayout(False)
        Me.guess_panel.PerformLayout()
        Me.panel_essais.ResumeLayout(False)
        Me.panel_essais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents guess_panel As Panel
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
    Friend WithEvents panel_essais As Panel
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents button_bye As Button
    Friend WithEvents label_found As Label
    Friend WithEvents label_lost As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timer_label As Label
    Friend WithEvents label_error_input As Label
End Class
