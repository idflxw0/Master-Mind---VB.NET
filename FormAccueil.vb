﻿Imports System.IO
Imports System.Text

Public Class FormAccueil
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
        addPlayerToFiles()
        Me.Close()
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
        Next
        File.WriteAllLines("F:\BUT1\Semestre 2\Periode D\IHM\SAE\$.txt", lines)
    End Sub

    Private Sub getPlayersFromFile()
        Dim filePath = "F:\BUT1\Semestre 2\Periode D\IHM\SAE\$.txt"
        Dim lines = File.ReadAllLines(filePath)
        For i As Integer = 0 To lines.Length - 1
            players.addPlayer(lines(i), lines(i + 1), lines(i + 2), lines(i + 3), lines(i + 4))
            i += 4
        Next
    End Sub

    Sub statsjoueurs()
        FormStats.ClearAll()

        For i As Integer = 0 To players.getnumPlayer - 1
            FormStats.ListBox_Name.Items.Add(getPlayer(i).nom)
            FormStats.ListBox_Score.Items.Add(getPlayer(i).score)
            FormStats.ListBox_Pattern.Items.Add(getPlayer(i).partieJ1)
            FormStats.ListBox_deviner.Items.Add(getPlayer(i).partieJ2)
            FormStats.ListBox_time.Items.Add(getPlayer(i).time)
        Next
    End Sub
End Class