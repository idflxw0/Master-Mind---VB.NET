Public Class FormSettings
    Private Sub FromSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_no.Checked = True
        color_button_no.Checked = True
    End Sub

    Private Sub button_yes_CheckedChanged(sender As Object, e As EventArgs) Handles button_yes.CheckedChanged, button_no.CheckedChanged
        If button_yes.Checked = True Then
            TextBox1.Enabled = True
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

    Private Sub button_save_Click(sender As Object, e As EventArgs) Handles button_save.Click
        If button_yes.Checked = True Then
            Form_Pattern_a_deviner.setUsableChar(TextBox1.Text)
        End If
        Me.Close()
        FormAccueil.Show()
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
End Class