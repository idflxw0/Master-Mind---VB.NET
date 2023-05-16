Imports System.IO
Imports System.Text

Public Class FormSettings
    Private Sub FromSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_no.Checked = True
        color_button_no.Checked = True
        MButton_yes.Checked = False

        If button_no.Checked = True Then
            MButton_yes.Enabled = False
            MButton_no.Enabled = True
        End If

        TimeLimit_Button_no.Checked = True
        RadioButton3.Checked = True
        change_limit_no.Checked = True
        filePath_no.Checked = True
    End Sub

    Private Sub button_CheckedChanged(sender As Object, e As EventArgs) Handles button_yes.CheckedChanged, button_no.CheckedChanged
        If button_yes.Checked = True Then
            TextBox1.Enabled = True
            MButton_yes.Checked = True
            MButton_yes.Enabled = True
            MButton_no.Enabled = True
        End If
        If button_no.Checked = True Then
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub SetLabelColor(label As Label)
        ColorDialog1.ShowDialog()
        label.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetLabelColor(label_absent)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetLabelColor(label_present)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SetLabelColor(label_PBP)
    End Sub



    Private Sub color_button_yes_CheckedChanged(sender As Object, e As EventArgs) Handles color_button_yes.CheckedChanged
        For Each button As Control In color_panel.Controls
            If TypeOf button Is Button Then
                button.Enabled = True
            End If
        Next
    End Sub
    Private Sub color_button_no_CheckedChanged(sender As Object, e As EventArgs) Handles color_button_no.CheckedChanged
        For Each button As Control In color_panel.Controls
            If TypeOf button Is Button Then
                button.Enabled = False
            End If
        Next
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If MButton_yes.Checked Then
            TextBox1.Text = TextBox1.Text.ToUpper()
        End If
        If MButton_no.Checked Then
            TextBox1.Text = TextBox1.Text.ToLower()
        End If
    End Sub

    Private Function sameLetters(textbox As TextBox) As Boolean
        If textbox.Text.Length <= 1 Then
            Return False
        End If
        For i As Integer = 0 To textbox.Text.Length - 2
            If textbox.Text(i) = textbox.Text(i + 1) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub button_return_Click(sender As Object, e As EventArgs) Handles button_return.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub button_save_Click(sender As Object, e As EventArgs) Handles button_save.Click
        If button_yes.Checked = True Then
            If sameLetters(TextBox1) Then
                TextBox1.ForeColor = Color.Red
                TextBox1.Focus()
                MsgBox("Veuillez saisir les différentes lettres!", MsgBoxStyle.Critical, "Erreur")
                Exit Sub
            End If
            Form_Pattern_a_deviner.setUsableChar(TextBox1.Text)
        End If

        If color_button_yes.Checked = True Then
            If changingColors() = False Then
                MsgBox("Veuillez sélectionner les différentes couleurs!", MsgBoxStyle.Critical, "Erreur")
                Exit Sub
            Else : changingColors()
            End If
        End If
        activateTimer()
        changeTimeLimit()

        If change_limit_yes.Checked = True Then
            Form_Game.setChances(Integer.Parse(TextBox_chance.Text))
        End If

        If filePath_yes.Checked = True Then
            If FilePathTextBox.Text = String.Empty Then
                MsgBox("le nouveau chemin de fichier ne peut pas être vide!", MsgBoxStyle.Critical, "Erreur")
                FilePathTextBox.Focus()
                Exit Sub
            End If

            If FilePathTextBox.Text <> String.Empty Then
                Dim filePath As String = FilePathTextBox.Text
                FormAccueil.setCustomFilePath(True, filePath)
                MsgBox(FilePathTextBox.Text)
                MsgBox("le chemin du fichier a été modifié avec succès", MsgBoxStyle.Information)
            End If
        End If
        Me.Hide()
        FormAccueil.Show()
    End Sub


    Private Function changingColors() As Boolean
        If label_absent.ForeColor = label_present.ForeColor Or label_absent.ForeColor = label_PBP.ForeColor Or label_present.ForeColor = label_PBP.ForeColor Or label_present.ForeColor = label_absent.ForeColor Or label_PBP.ForeColor = label_absent.ForeColor Or label_PBP.ForeColor = label_present.ForeColor Then
            Return False
        End If
        Form_Game.setAbsentColor(label_absent, label_present, label_PBP)
        Return True
    End Function



    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged
        If RadioButton4.Checked = True Then
            Text_TimeLimite.Enabled = True
            TextBox_Sec.Enabled = True
            TimeLimit_Button_no.Enabled = False
            Time_limitButton_yes.Enabled = False
        End If
        If RadioButton3.Checked = True Then
            TimeLimit_Button_no.Enabled = True
            Time_limitButton_yes.Enabled = True
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Text_TimeLimite.Enabled = False
        TextBox_Sec.Enabled = False
    End Sub

    Private Sub activateTimer()
        If Time_limitButton_yes.Checked = True Then
            Form_Game.havingTimer(False)
        End If
        If TimeLimit_Button_no.Checked = True Then
            Form_Game.havingTimer(True)
        End If
    End Sub

    Private Sub changeTimeLimit()
        If RadioButton4.Checked = True Then
            Form_Game.havingTimer(True)
            If TextBox_Sec.Text = "0" Then
                TextBox_Sec.Text = "00"
            End If
            Form_Game.setTimeLimit(Text_TimeLimite.Text, TextBox_Sec.Text)
        End If
    End Sub

    Private Sub Text_TimeLimite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_TimeLimite.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_Sec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Sec.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Time_limitButton_yes_CheckedChanged(sender As Object, e As EventArgs) Handles Time_limitButton_yes.CheckedChanged, TimeLimit_Button_no.CheckedChanged
        If Time_limitButton_yes.Checked = True Then
            Panel4.Enabled = False
        End If
        If TimeLimit_Button_no.Checked = True Then
            Panel4.Enabled = True
        End If
    End Sub

    Private Sub change_limit_yes_CheckedChanged(sender As Object, e As EventArgs) Handles change_limit_yes.CheckedChanged, change_limit_no.CheckedChanged
        If change_limit_no.Checked = True Then
            TextBox_chance.Enabled = False
        End If
        If change_limit_yes.Checked = True Then
            TextBox_chance.Enabled = True
        End If
    End Sub

    Private Sub TextBox_chance_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_chance.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles filePath_yes.CheckedChanged, filePath_no.CheckedChanged
        If filePath_no.Checked = True Then
            FilePathTextBox.Enabled = False
            Button_browse.Enabled = False
        End If
        If filePath_yes.Checked = True Then
            FilePathTextBox.Enabled = True
            Button_browse.Enabled = True
        End If
    End Sub

    Private Sub Button_browse_Click(sender As Object, e As EventArgs) Handles Button_browse.Click
        Dim dialog As New FolderBrowserDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            FilePathTextBox.Text = dialog.SelectedPath
        End If
    End Sub


End Class