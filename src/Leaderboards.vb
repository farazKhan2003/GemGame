Public Class Leaderboards
    Private Sub LeaderBoards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileNum As Integer
        Dim username As String
        Dim highscore As Integer
        FileNum = FreeFile()
        FileOpen(FileNum, "Leaderboards.txt", OpenMode.Input)
        username = LineInput(FileNum)
        highscore = LineInput(FileNum)
        HighestScorerLabel.Text = "Username of Highest Scorer is: " & username
        HighestScoreLabel.Text = "Highest Score is: " & highscore
        FileClose(FileNum)
    End Sub

    Private Sub ReturnLabel_Click(sender As Object, e As EventArgs) Handles ReturnLabel.Click
        StartUp.Show()
        Hide()
    End Sub
End Class