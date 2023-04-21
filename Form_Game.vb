Public Class Form_Game
    Private chances As Integer = 15
    Private hidden_code As String = Form_Pattern_a_deviner.getMessage()
    Private seconds, minutes As Integer

    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste " & chances & " coup(s)..."
        Me.hideAll()
        Me.Timer1.Start()
        Me.Timer1.Interval = 1000
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
        timer(sender, e)
        checkmate(minutes, seconds)
    End Sub
    Private Function timer(sender As Object, e As EventArgs)
        timer_label.Text = Format(minutes, "00:") & Format(seconds, "00")
        seconds += 1
        If seconds = 60 Then
            minutes += 1
            seconds = 0
        End If
        Return Nothing
    End Function

    Private Function checkmate(min As Integer, sec As Integer)
        If min = 1 AndAlso sec = 31 Then
            Timer1.Stop()
            MsgBox("vous avez perdu")
        End If
    End Function
End Class