Public Class Form_Game
    Private chances As Integer = 15
    Private hidden_code As String = Form_Pattern_a_deviner.getMessage()
    Private time As Integer = 0

    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste " & chances & " coup(s)..."
        Me.timer_label.Text = "00:00:00"
        Me.hideAll()
        Me.Timer1.Start()
        Me.Timer1_Tick(sender, e)

    End Sub

    Private Function hideAll()
        For Each hidLabel As Control In panel_essais.Controls
            If TypeOf hidLabel Is Label Then
                hidLabel.Visible = False
            End If
        Next
        label_found.Visible = False
        label_error_input.Visible = False
        label_lost.Visible = False
        Return Nothing
    End Function

    Private Sub Guess_Button_Click(sender As Object, e As EventArgs) Handles Guess_Button.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub
End Class