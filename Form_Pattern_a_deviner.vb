Public Class Form_Pattern_a_deviner
    Private Authorized_Characters As String = "#$£%@"
    Private hidden_code As String
    Private Sub Form_Pattern_a_deviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        error_label.Visible = False
    End Sub

    Private Sub TextBoxs_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged
        If Authorized_Characters.Contains(sender.Text) Then
            error_label.Visible = False
            Exit Sub
        Else
            sender.text = ""
            error_label.Visible = True
        End If
    End Sub

    Private Sub button_hide_Click(sender As Object, e As EventArgs) Handles button_hide.Click
        For Each txtBox As Control In Panel1.Controls
            If TypeOf txtBox Is TextBox Then
                If txtBox.Text <> String.Empty Then
                    hidden_code += txtBox.Text
                Else
                    MessageBox.Show("ajoutez votre message à cacher dans le cas!", "Erreur")
                    Exit Sub
                End If
            End If
        Next

        Me.Hide()
        Form_Game.Show()
    End Sub

    Public Function getMessage() As String
        Return hidden_code
    End Function
End Class
