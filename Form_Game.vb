Public Class Form_Game
    Private chances As Integer = 15
    Private hidden_code As String = Form_Pattern_a_deviner.getMessage()
    Private seconds, minutes As Integer
    Private Authorized_Characters As String = "#$£%@"
    Private letter_found As Integer = 0
    Private Const must_find As Integer = 5

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
    Private Function timer(sender As Object, e As EventArgs)
        timer_label.Text = Format(minutes, "00:") & Format(seconds, "00")
        seconds += 1
        If seconds = 60 Then
            minutes += 1
            seconds = 0
        End If
        Return Nothing
    End Function

    Private Function letterPlaced(guessBox As Control)
        For i As Integer = 0 To guess_panel.Controls.Count - 1
            If perfectlyPlaced(guessBox) Then
                guessBox.BackColor = Color.Green
                greenColors(guessBox)
                Exit For
            ElseIf abesentLetter(guessBox) Then
                guessBox.BackColor = Color.Red
                Exit For
            ElseIf presentButNotPerfectlyPlaced(guessBox) Then
                guessBox.BackColor = Color.Blue
                Exit For
            End If
        Next
        Return Nothing
    End Function

    Private Function perfectlyPlaced(guessBox As Control)
        For i As Integer = 0 To guess_panel.Controls.Count - 1
            If abesentLetter(guessBox) = False AndAlso presentButNotPerfectlyPlaced(guessBox) = False Then
                If guessBox.Text = hidden_code(i) Then
                    Return True
                    Exit For
                End If
            End If

        Next
        Return False
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
        For i As Integer = 0 To hidden_code.Length - 1
            If abesentLetter(guessBox) = False Then
                If hidden_code.Contains(guessBox.Text) Then
                    If guessBox.Text <> hidden_code(i) Then
                        Return True
                        Exit For
                    Else Return False
                    End If
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Function greenColors(guessBox As Control)
        If guessBox.BackColor = Color.Green Then
            letter_found += 1
        End If
        Return Nothing
    End Function


    Private Sub Guess_Button_Click(sender As Object, e As EventArgs) Handles Guess_Button.Click

        For Each guess_box As Control In guess_panel.Controls
            If TypeOf guess_box Is TextBox Then
                letterPlaced(guess_box)
                If letter_found = must_find Then
                    Timer1.Stop()
                    label_found.Visible = True
                End If
            End If
        Next
        If letter_found <> must_find Then
            chances -= 1
            Me.Text = "Il vous reste " & chances & " coup(s)..."
        End If
    End Sub

    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste " & chances & " coup(s)..."
        Me.hideAll()
        Me.Timer1.Start()
        Me.Timer1.Interval = 1000
        Me.Timer1_Tick(sender, e)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer(sender, e)
        checkmate()
    End Sub



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