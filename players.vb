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
            If player(playerIndex).time = Nothing Then
                player(playerIndex).time = time
            End If
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

    Public Sub setTheNewBestTime(name As String, time As Integer)
        For i As Integer = 0 To total_player - 1
            If player(i).time >= time Then
                player(i).time = time
            End If
        Next
    End Sub


    Public Function getPlayer(index As Integer) As Splayers
        Return player(index)
    End Function

    Public Sub sortByOrderAlpha()
        quickSortOrderAlpha(player, 0, total_player - 1)
    End Sub
    Public Sub sortByScore()
        quickSortScore(player, 0, total_player - 1)
    End Sub

    Public Sub quickSortOrderAlpha(array() As Splayers, lowIndex As Integer, highIndex As Integer)
        If lowIndex >= highIndex Then
            Exit Sub
        End If

        Dim pivotIndex As Integer = partition(array, lowIndex, highIndex)
        quickSortOrderAlpha(array, lowIndex, pivotIndex - 1)
        quickSortOrderAlpha(array, pivotIndex + 1, highIndex)
    End Sub

    Private Function partition(array() As Splayers, lowIndex As Integer, highIndex As Integer) As Integer
        Dim pivot As String = array(highIndex).nom
        Dim i As Integer = lowIndex - 1

        For j As Integer = lowIndex To highIndex - 1
            If String.Compare(array(j).nom, pivot) < 0 Then
                i += 1
                swap(array, i, j)
            End If
        Next

        i += 1
        swap(array, i, highIndex)

        Return i
    End Function

    Public Sub quickSortScore(array() As Splayers, lowIndex As Integer, highIndex As Integer)
        If lowIndex < highIndex Then
            Dim pivot As Splayers = array(highIndex)
            Dim partitionIndex As Integer = partition(array, lowIndex, highIndex, pivot)
            quickSortScore(array, lowIndex, partitionIndex - 1)
            quickSortScore(array, partitionIndex + 1, highIndex)
        End If
    End Sub

    Private Function partition(array() As Splayers, lowIndex As Integer, highIndex As Integer, pivot As Splayers) As Integer
        Dim partitionIndex As Integer = lowIndex - 1
        For i As Integer = lowIndex To highIndex - 1
            If array(i).score >= pivot.score Then
                partitionIndex += 1
                swap(array, partitionIndex, i)
            End If
        Next
        swap(array, partitionIndex + 1, highIndex)
        Return partitionIndex + 1
    End Function

    Private Sub swap(array() As Splayers, index1 As Integer, index2 As Integer)
        Dim temp As Splayers = array(index1)
        array(index1) = array(index2)
        array(index2) = temp
    End Sub

    Sub main()
        Application.Run(FormAccueil)
    End Sub
End Module
