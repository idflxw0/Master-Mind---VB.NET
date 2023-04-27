Imports System.IO
Imports System.Text

Public Class FormAccueil

    Private CustomPath As Boolean = False
    Private customFilePath As String
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPlayersFromFile()
        For i As Integer = 0 To players.getnumPlayer - 1
            ComboBox1.Items.Add(players.getPlayer(i).nom)
            ComboBox2.Items.Add(players.getPlayer(i).nom)
        Next
        error_label.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged, ComboBox2.TextChanged
        If ComboBox1.Text <> String.Empty Then
            player1.ForeColor = Color.Black
        End If
        If ComboBox2.Text <> String.Empty Then
            player2.ForeColor = Color.Black
        End If
        error_label.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim canGo As Boolean = False
        Dim focus As Boolean = True
        If canGo = False Then
            If ComboBox1.Text = String.Empty AndAlso ComboBox2.Text = String.Empty Then
                player1.ForeColor = Color.Red
                player2.ForeColor = Color.Red
                If focus Then
                    ComboBox1.Focus()
                    MsgBox("Veuillez remplir les champs svp!", MsgBoxStyle.Critical, "Erreur")
                    focus = False
                    Exit Sub
                End If
            End If
            If ComboBox1.Text = String.Empty Then
                player1.ForeColor = Color.Red
                If focus Then
                    ComboBox1.Focus()
                    MsgBox("Veuillez remplir le champ joueur1 svp!", MsgBoxStyle.Critical, "Erreur")
                    focus = False
                    Exit Sub
                End If
            End If
            If ComboBox2.Text = String.Empty Then
                player2.ForeColor = Color.Red
                If focus Then
                    ComboBox2.Focus()
                    MsgBox("Veuillez remplir le champ joueur2 svp!", MsgBoxStyle.Critical, "Erreur")
                    focus = False
                    Exit Sub
                End If
            End If

            If ComboBox1.Text = ComboBox2.Text Then
                error_label.Visible = True
                Exit Sub
            End If
            canGo = True
        End If

        If canGo Then
            ' addPlayerToComboBox(ComboBox1, ComboBox2)

            Me.Hide()
            Form_Pattern_a_deviner.Show()
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-Vous continuez", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If confirmation = DialogResult.No Then
            Exit Sub
        End If
        If confirmation = DialogResult.Yes Then
            addPlayerToFiles()
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button_settings.Click
        Me.Hide()
        FormSettings.Show()
    End Sub

    Private Sub buttons_stats_Click(sender As Object, e As EventArgs) Handles buttons_stats.Click
        Me.Hide()
        FormStats.Show()
    End Sub


    Private Sub addPlayerToFiles()
        Dim lines As New List(Of String)
        For i As Integer = 0 To getnumPlayer() - 1
            lines.Add(getPlayer(i).nom)
            lines.Add(getPlayer(i).score)
            lines.Add(getPlayer(i).partieJ1)
            lines.Add(getPlayer(i).partieJ2)
            lines.Add(getPlayer(i).time)
            lines.Add(getPlayer(i).accumulatedTime)
        Next
        Dim fileName = "players.txt"
        Dim filePath
        If CustomPath = False Then
            filePath = Path.Combine(Application.StartupPath, fileName)
            If Not File.Exists(filePath) Then
                File.Create(filePath).Dispose()
            End If
            File.WriteAllLines(filePath, lines)
        End If

        If CustomPath = True Then
            filePath = Me.customFilePath
            If Not File.Exists(filePath) Then
                File.Create(filePath).Dispose()
            End If
            File.WriteAllLines(filePath, lines)
        End If
    End Sub

    Private Sub getPlayersFromFile()
        Dim fileName = "players.txt"
        Dim filePath
        If CustomPath = False Then
            filePath = Path.Combine(Application.StartupPath, fileName)
            If Not File.Exists(filePath) Then
                File.Create(filePath).Dispose()
                Return
            End If
            Dim lines = File.ReadAllLines(filePath)
            For i As Integer = 0 To lines.Length - 1
                players.addPlayer(lines(i), lines(i + 1), lines(i + 2), lines(i + 3), lines(i + 4), lines(i + 5))
                i += 5
            Next
        End If

        If CustomPath = True Then
            filePath = Me.customFilePath
            If Not File.Exists(filePath) Then
                File.Create(filePath).Dispose()
            End If
            Dim lines = File.ReadAllLines(filePath)
            For i As Integer = 0 To lines.Length - 1
                players.addPlayer(lines(i), lines(i + 1), lines(i + 2), lines(i + 3), lines(i + 4), lines(i + 5))
                i += 5
            Next
        End If
    End Sub

    Public Sub setCustomFilePath(cPath As Boolean, newFilePath As String)
        Me.customFilePath = newFilePath
        Me.CustomPath = cPath
    End Sub

    Sub statsjoueurs()
        FormStats.ClearAll()
        For i As Integer = 0 To players.getnumPlayer - 1
            FormStats.ListBox_Name.Items.Add(getPlayer(i).nom)
            FormStats.ListBox_Score.Items.Add(getPlayer(i).score)
            FormStats.ListBox_Pattern.Items.Add(getPlayer(i).partieJ1)
            FormStats.ListBox_deviner.Items.Add(getPlayer(i).partieJ2)
            FormStats.ListBox_time.Items.Add(getPlayer(i).time)
            FormStats.ListBox_CumuleTemps.Items.Add(getPlayer(i).accumulatedTime)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        MsgBox(customFilePath)
    End Sub
End Class