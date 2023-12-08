Public Class StartUp
    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click
        Gameplay.Show()
    End Sub

    Private Sub LeaderBoardButton_Click(sender As Object, e As EventArgs) Handles LeaderBoardButton.Click
        LeaderBoards.Show
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

End Class