Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form_Game

    Private chances As Integer = 15
    Private guessed As Integer = 0
    Private hidden_code As String = Form_Pattern_a_deviner.getMessage()
    Private seconds, minutes As Integer
    Private Authorized_Characters As String = "#$£%@"
    Private added_letters As String

    Private index As Integer = 0 ' index pour comparer les lettres dans le textbox avec le hidden_code

    'index pour le tableau codeColor
    Private intColorIndex As Integer

    'index pour le tableau labelColor
    Private labelColorIndex As Integer

    'index pour le tableau guessedLetter
    Private GuessedLetterIndex As Integer

    'tableau pour stocker les codes couleurs des lettres
    Private codeColor(4) As Integer

    'tableau pour stocker les lettres devinées
    Private guessedLetter(4) As String

    'les codes couleurs pour identifier les couleurs
    Private CodeColorGreen = 1
    Private CodeColorBlue = 2
    Private CodeColorWhite = 3

    Private Sub hideAll()
        For Each hidePanel As Control In panel_essais.Controls
            If TypeOf hidePanel Is Panel Then
                For Each hidelabel As Control In hidePanel.Controls
                    If TypeOf hidelabel Is Label Then
                        hidelabel.Visible = False
                    End If
                Next
            End If
        Next
        label_found.Visible = False
        label_error_input.Visible = False
        label_lost.Visible = False
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

    Private Function checkmate()
        If Me.minutes = 1 AndAlso Me.seconds = 30 Then
            Timer1.Stop()
            MsgBox("Vous avez perdu!", MsgBoxStyle.Critical, "Le temps est écoulé !")
        End If
        Return Nothing
    End Function


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
        guessBox.BackColor = Color.White
        Return True
    End Function

    Private Function getPanelOrder(guess As Integer) As Panel
        Select Case guess
            Case 1
                Return Panel1
            Case 2
                Return Panel2
            Case 3
                Return Panel3
            Case 4
                Return Panel4
            Case 5
                Return Panel5
            Case 6
                Return Panel6
            Case 7
                Return Panel7
            Case 8
                Return Panel8
            Case 9
                Return Panel9
            Case 10
                Return Panel10
            Case 11
                Return Panel11
            Case 12
                Return Panel12
            Case 13
                Return Panel13
            Case 14
                Return Panel14
            Case 15
                Return Panel15
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub letterPlaced(guessBox As Control)
        If perfectlyPlaced(guessBox) Then
            guessBox.BackColor = Color.Green
        ElseIf presentButNotPerfectlyPlaced(guessBox) Then
            guessBox.BackColor = Color.Blue
        End If
    End Sub

    Private Sub resetIndexs()
        intColorIndex = 0
        labelColorIndex = 0
        GuessedLetterIndex = 0
        index = 0
    End Sub

    Private Function getTimeAsIntger(label As Label) As Integer
        Dim time As String = label.Text
        Dim timeArray() As String = time.Split(":")
        Dim minutes As Integer = Integer.Parse(timeArray(0))
        Dim seconds As Integer = Integer.Parse(timeArray(1))
        Return minutes * 60 + seconds
    End Function

    Private Sub showLabel()
        For Each label As Control In Me.getPanelOrder(guessed).Controls
            If TypeOf label Is Label Then
                label.Visible = True
                If codeColor(labelColorIndex) = CodeColorGreen Then
                    label.Text = guessedLetter(labelColorIndex)
                    label.ForeColor = Color.Green
                    labelColorIndex += 1
                ElseIf codeColor(labelColorIndex) = CodeColorBlue Then
                    label.Text = guessedLetter(labelColorIndex)
                    label.ForeColor = Color.Blue
                    labelColorIndex += 1
                ElseIf codeColor(labelColorIndex) = CodeColorWhite Then
                    label.Text = guessedLetter(labelColorIndex)
                    label.ForeColor = Color.Black
                    labelColorIndex += 1
                End If
            End If
        Next
    End Sub

    Private Sub addColorAndLettersToLabel(guessBox As Control)
        If guessBox.BackColor = Color.Green Then
            codeColor(intColorIndex) = CodeColorGreen
            intColorIndex += 1
        ElseIf guessBox.BackColor = Color.Blue Then
            codeColor(intColorIndex) = CodeColorBlue
            intColorIndex += 1
        ElseIf guessBox.BackColor = Color.White Then
            codeColor(intColorIndex) = CodeColorWhite
            intColorIndex += 1
        End If

        guessedLetter(GuessedLetterIndex) = guessBox.Text
        GuessedLetterIndex += 1
    End Sub

    Private Sub Guess_Button_Click(sender As Object, e As EventArgs) Handles Guess_Button.Click
        guessed += 1
        Me.Text = "Il vous reste " & chances - guessed & " coup(s)..."
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
                    addPlayer(FormAccueil.ComboBox1.Text, 0, 1, 0, 0)
                    addPlayer(FormAccueil.ComboBox2.Text, 1, 0, 1, getTimeAsIntger(timer_label))
                    players.setTheNewBestTime(FormAccueil.ComboBox2.Text, getTimeAsIntger(timer_label))
                    label_found.Visible = True
                    Guess_Button.Enabled = False
                End If

                addColorAndLettersToLabel(guess_box)

            End If
        Next

        showLabel()

        If added_letters <> hidden_code Then
            If guessed <> chances Then
                added_letters = ""
            ElseIf guessed = chances Then
                Timer1.Stop()
                label_lost.Visible = True
                Guess_Button.Enabled = False
                addPlayer(FormAccueil.ComboBox1.Text, 1, 1, 0, 0)
                addPlayer(FormAccueil.ComboBox2.Text, 0, 0, 1, getTimeAsIntger(timer_label))
                MsgBox("vous avez épuisé vos chances !", MsgBoxStyle.Critical, "Vous avez perdu!")
                Exit Sub
            End If
        End If

        resetIndexs()
    End Sub

    Public Sub setAbsentColor(Label As Label)
        absent_label.ForeColor = Label.ForeColor
    End Sub

    Public Sub setPresentColor(Label As Label)
        present_label.ForeColor = Label.ForeColor
    End Sub

    Public Sub setPresentAndPerfectlyPlaced(Label As Label)
        PB_label.ForeColor = Label.ForeColor
    End Sub

    Public Sub setCharLabel(label As Label)
        char_label.Text = label.Text
    End Sub

    Public Function getAbsentColor() As Color
        Return absent_label.ForeColor
    End Function

    Public Function getPresentColor() As Color
        Return present_label.ForeColor
    End Function
    Public Function getPBPcolor() As Color
        Return PB_label.ForeColor
    End Function

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

    Private Sub button_bye_Click(sender As Object, e As EventArgs) Handles button_bye.Click
        Form_Pattern_a_deviner.Close()
        Dim player1 As String = FormAccueil.ComboBox1.Text
        Dim player2 As String = FormAccueil.ComboBox2.Text
        FormAccueil.ComboBox1.Text = player2
        FormAccueil.ComboBox2.Text = player1
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles guess_box1.TextChanged, guess_box2.TextChanged, guess_box3.TextChanged, guess_box4.TextChanged, guess_box5.TextChanged
        If Authorized_Characters.Contains(sender.Text) Then
            label_error_input.Visible = False
            Exit Sub
        Else
            sender.text = ""
            label_error_input.Visible = True
        End If
    End Sub

End Class