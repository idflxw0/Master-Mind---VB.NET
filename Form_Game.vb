Public Class Form_Game

    Private chances As Integer = 15
    Private hidden_code As String = Form_Pattern_a_deviner.getMessage()
    Private seconds, minutes As Integer
    Private Authorized_Characters As String = "#$£%@"
    Private added_letters As String
    Private guesses(14, 4) As String


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

    Private Function checkmate()
        If Me.minutes = 1 AndAlso Me.seconds = 30 Then
            Timer1.Stop()
            MsgBox("Vous avez perdu!", MsgBoxStyle.Critical, "Le temps est écoulé !")
        End If
        Return Nothing
    End Function

    Private index As Integer = 0
    Private Function perfectlyPlaced(guessBox As Control) As Boolean
        If abesentLetter(guessBox) = False Then
            If hidden_code(index) = guessBox.Text Then
                index += 1
                Return True
            End If
        Else
            index += 1
            Return False
        End If
        Return Nothing
    End Function


    Private Function presentButNotPerfectlyPlaced(guessBox As Control) As Boolean
        If hidden_code.Contains(guessBox.Text) Then
            If hidden_code(index) <> guessBox.Text Then
                index += 1
                Return True
            Else
                index += 1
                Return False
            End If
        End If
        Return Nothing
    End Function

    Private Function abesentLetter(guessBox As Control) As Boolean
        For i As Integer = 0 To Me.hidden_code.Length - 1
            If guessBox.Text = Me.hidden_code(i) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub letterPlaced(guessBox As Control)
        If perfectlyPlaced(guessBox) Then
            guessBox.BackColor = Color.Green
        ElseIf presentButNotPerfectlyPlaced(guessBox) Then
            guessBox.BackColor = Color.Blue
        End If
    End Sub



    Private Sub Guess_Button_Click(sender As Object, e As EventArgs) Handles Guess_Button.Click

        For Each guess_box As Control In guess_panel.Controls
            If TypeOf guess_box Is TextBox Then
                If guess_box.Text = String.Empty Then
                    MessageBox.Show("Veuillez remplir tous les champs!", "Erreur")
                    Exit Sub
                End If
                letterPlaced(guess_box)
                added_letters += guess_box.Text
                If added_letters = hidden_code Then
                    Timer1.Stop()
                    label_found.Visible = True
                End If
            End If
        Next
        If added_letters <> hidden_code Then
            If chances > 0 Then
                chances -= 1
                added_letters = ""
            Else
                label_found.Visible = True
                MsgBox("vous avez épuisé vos chances !", MsgBoxStyle.Critical, "Vous avez perdu!")
            End If

            Me.Text = "Il vous reste " & chances & " coup(s)..."
        End If
        index = 0
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
        Else
            sender.text = ""
            label_error_input.Visible = True
        End If
    End Sub


End Class