Public Class Form_Game
    Private chances As Integer = 15
    Private hidden_code As String = Form_Pattern_a_deviner.getMessage()
    Private seconds, minutes As Integer
    Private Authorized_Characters As String = "#$£%@"
    Private letter_found As Integer = 0
    Private Const must_find As Integer = 5

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
        For Each guess_box As Control In guess_panel.Controls
            If TypeOf guess_box Is TextBox Then
                perfectyPlaced(guess_box)
                If letter_found = must_find Then
                    Timer1.Stop()
                    label_found.Visible = True
                End If

            End If
        Next
    End Sub

    Private Function perfectyPlaced(guessBox As Control)
        For i As Integer = 0 To guess_panel.Controls.Count - 1
            If guessBox.Text = hidden_code(i) Then
                Me.letter_found += 1
                guessBox.BackColor = Color.Green
                Exit For
            ElseIf abesentLetter(guessBox) Then
                guessBox.BackColor = Color.Red
                Exit For
            End If
        Next
        Return Nothing
    End Function

    Private Function abesentLetter(guessBox As Control)
        For i As Integer = 0 To guess_panel.Controls.Count - 1
            If hidden_code.Contains(guessBox.Text) = False Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function presentButNotPerfectlyPlaced(guessBox As Control)

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer(sender, e)
        checkmate()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged
        If Authorized_Characters.Contains(sender.Text) Then
            label_error_input.Visible = False
            Exit Sub
        ElseIf sender.Text.length() > 1 Then
            sender.text = ""
            label_error_input.Visible = True
        End If

    End Sub

    Private Function checkmate()
        If Me.minutes = 1 AndAlso Me.seconds = 30 Then
            Timer1.Stop()
        End If

        Return Nothing
    End Function
End Class