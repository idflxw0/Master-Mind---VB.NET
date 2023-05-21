Public Class FormStats

    Public Sub ClearAll()
        ListBox_Name.Items.Clear()
        ListBox_Score.Items.Clear()
        ListBox_Pattern.Items.Clear()
        ListBox_deviner.Items.Clear()
        ListBox_time.Items.Clear()
        ListBox_CumuleTemps.Items.Clear()
    End Sub

    Private Sub FromStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Statistique"
        For i As Integer = 0 To players.getnumPlayer() - 1
            ListBox_Name.Items.Add(players.getPlayer(i).nom)
            ListBox_Score.Items.Add(players.getPlayer(i).score)
            ListBox_Pattern.Items.Add(players.getPlayer(i).partieJ1)
            ListBox_deviner.Items.Add(players.getPlayer(i).partieJ2)
            ListBox_time.Items.Add(players.getPlayer(i).time)
            ListBox_CumuleTemps.Items.Add(players.getPlayer(i).accumulatedTime)
        Next
    End Sub

    Private Sub buttonRetour(sender As Object, e As EventArgs) Handles button_return.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub buttonSortAlpha(sender As Object, e As EventArgs) Handles Sort_alpha.Click
        ClearAll()
        players.sortByOrderAlpha()
        FormAccueil.playerStats()
    End Sub

    Private Sub ListBox_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Name.SelectedIndexChanged, ListBox_Score.SelectedIndexChanged, ListBox_Pattern.SelectedIndexChanged, ListBox_deviner.SelectedIndexChanged, ListBox_time.SelectedIndexChanged, ListBox_CumuleTemps.SelectedIndexChanged
        Dim index As Integer = sender.SelectedIndex
        ListBox_Name.SelectedIndex = index
        ListBox_Score.SelectedIndex = index
        ListBox_Pattern.SelectedIndex = index
        ListBox_deviner.SelectedIndex = index
        ListBox_time.SelectedIndex = index
        ListBox_CumuleTemps.SelectedIndex = index

    End Sub

    Private Sub buttonSortScore(sender As Object, e As EventArgs) Handles Button_score.Click
        ClearAll()
        players.sortByScore()
        FormAccueil.playerStats()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_time.Click
        ClearAll()
        players.sortByTime()
        FormAccueil.playerStats()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ClearAll()
        players.sortByTotalTime()
        FormAccueil.playerStats()
    End Sub
End Class