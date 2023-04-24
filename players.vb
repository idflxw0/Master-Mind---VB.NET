Module players
    Structure Splayers
        Dim nom As String
        Dim score As Integer
        Dim partieJ1 As Integer
        Dim partieJ2 As Integer
        Dim time As Integer
    End Structure

    Private player(2) As Splayers
    Private total_player As Integer = 0

    Public Sub addTotalPlayer()
        total_player += 1
    End Sub

    Public Function getnumPlayer() As Integer
        Return total_player
    End Function

    Public Sub addPlayer(nom As String, score As Integer, partieJ1 As Integer, partieJ2 As Integer, time As Integer)

        Dim playerIndex As Integer = getPlayerIndex(nom)

        If playerIndex >= 0 Then
            player(playerIndex).score += score
            player(playerIndex).partieJ1 += partieJ1
            player(playerIndex).partieJ2 += partieJ2
            player(playerIndex).time += time
        Else
            Dim newPlayer As Splayers
            newPlayer.nom = nom
            newPlayer.score = score
            newPlayer.partieJ1 = partieJ1
            newPlayer.partieJ2 = partieJ2
            newPlayer.time = time

            If total_player >= player.Length Then
                ReDim Preserve player((player.Length - 1) + 5)
            End If
            player(total_player) = newPlayer
            total_player += 1
        End If
    End Sub
    Private Function getPlayerIndex(nom As String) As Integer
        For i As Integer = 0 To total_player - 1
            If player(i).nom = nom Then
                Return i
            End If
        Next
        Return -1
    End Function


    Public Function getPlayer(index As Integer) As Splayers
        Return player(index)
    End Function

    Public Sub sortByOrderAlpha()
        For i = 0 To total_player - 2
            For j = i + 1 To total_player - 1
                If String.Compare(player(i).nom, player(j).nom) > 0 Then
                    Dim temp As Splayers = player(i)
                    player(i) = player(j)
                    player(j) = temp
                End If
            Next
        Next
    End Sub

    Public Sub sortByScore()
        For i As Integer = 0 To total_player - 1
            For j As Integer = i + 1 To total_player - 1
                If player(i).score < player(j).score Then
                    Dim tempVal As Splayers = player(j)
                    player(j) = player(i)
                    player(i) = tempVal
                End If
            Next
        Next
    End Sub

    Sub main()
        Application.Run(FormAccueil)
    End Sub
End Module
