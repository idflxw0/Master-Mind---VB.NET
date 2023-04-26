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
    Private hide_code As String


    Public Sub addTotalPlayer()
        total_player += 1
    End Sub

    Public Sub setHideCode(text As String)
        hide_code = text
    End Sub


    Public Function getHideCode() As String
        Return hide_code
    End Function

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
        Sort(player, 0, total_player - 1, "nom")
    End Sub
    Public Sub sortByScore()
        Sort(player, 0, total_player - 1, "score")
    End Sub

    Public Sub sortByTime()
        Sort(player, 0, total_player - 1, "time")
    End Sub

    Private Sub Sort(array() As Splayers, lowIndex As Integer, highIndex As Integer, sortProperty As String)
        If lowIndex >= highIndex Then
            Exit Sub
        End If

        Dim pivotIndex As Integer = partition(array, lowIndex, highIndex, sortProperty)
        Sort(array, lowIndex, pivotIndex - 1, sortProperty)
        Sort(array, pivotIndex + 1, highIndex, sortProperty)
    End Sub

    Private Function partition(array() As Splayers, lowIndex As Integer, highIndex As Integer, sortProperty As String) As Integer
        Dim pivotIndex As Integer = highIndex
        Dim pivotValue As Object = Nothing

        Select Case sortProperty
            Case "nom"
                pivotValue = array(highIndex).nom
            Case "score"
                pivotValue = array(highIndex).score
            Case "time"
                pivotValue = array(highIndex).time
        End Select

        Dim partitionIndex As Integer = lowIndex - 1

        For i As Integer = lowIndex To highIndex - 1
            Dim compareValue As Object = Nothing

            Select Case sortProperty
                Case "nom"
                    compareValue = array(i).nom
                Case "score"
                    compareValue = array(i).score
                Case "time"
                    compareValue = array(i).time
            End Select

            If sortProperty = "nom" Then
                If compareValue <= pivotValue Then
                    partitionIndex += 1
                    swap(array, partitionIndex, i)
                End If
            End If
            If sortProperty = "score" Or sortProperty = "time" Then
                If compareValue >= pivotValue Then
                    partitionIndex += 1
                    swap(array, partitionIndex, i)
                End If
            End If

        Next

        partitionIndex += 1
        swap(array, partitionIndex, pivotIndex)
        Return partitionIndex
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
