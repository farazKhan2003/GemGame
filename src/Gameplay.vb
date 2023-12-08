Option Compare Text
Imports System.Runtime.Remoting.Services
Imports Microsoft.VisualBasic.Devices

Public Class Gameplay
    Dim moveRight As Boolean = False
    Dim moveUp As Boolean = False
    Dim moveLeft As Boolean = False
    Dim moveDown As Boolean = False
    Dim score As Single = 0
    Dim HS As Single = 0
    Dim lives As Integer
    Dim Countdown As Integer = 1000
    Dim enemyarray(3) As PictureBox
    Dim UserName As String = ""
    Dim DifChoice As String
    Dim SoundEffect As New Media.SoundPlayer



    Private Sub Gameplay_KeyPush(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = True
            Case Keys.Up
                moveUp = True
            Case Keys.Left
                moveLeft = True
            Case Keys.Down
                moveDown = True

        End Select

    End Sub

    Private Sub Gameplay_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = False
            Case Keys.Up
                moveUp = False
            Case Keys.Left
                moveLeft = False
            Case Keys.Down
                moveDown = False
            Case Keys.R
                Knight.Left = 0
                Knight.Top = 0
                Skelly.Left = Int((Rnd() * (700 - (2 * Skelly.Width))) + Skelly.Width)
                Skelly.Top = Int((Rnd() * (700 - (2 * Skelly.Height))) + Skelly.Height)
                Jack.Left = Int((Rnd() * (700 - (2 * Jack.Width))) + Jack.Width)
                Jack.Top = Int((Rnd() * (700 - (2 * Jack.Height))) + Jack.Height)
                Zombie.Left = Int((Rnd() * (700 - (2 * Zombie.Width))) + Zombie.Width)
                Zombie.Top = Int((Rnd() * (700 - (2 * Zombie.Height))) + Zombie.Height)
                Countdown = 1000
                If DifChoice = "Easy" Then
                    lives = 7
                ElseIf DifChoice = "Normal" Then
                    lives = 5
                ElseIf DifChoice = "Hard" Then
                    lives = 3
                End If
                LivesLabel.Text = "Lives: " & lives
                score = 0
                ScoreLabel.Text = "Score: " & score
                moveRight = False
                moveUp = False
                moveDown = False
                moveLeft = False
                Timer1.Start()
                ReturnToMainMenuLabel.Visible = False
            Case Keys.Escape
                StartUp.Activate()
                Me.Close()

        End Select

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim FileNum As Integer

        Countdown -= 50
        Dim collided As Boolean = False
        If DifChoice = "Easy" Then
            If moveRight = True And (Knight.Left + Knight.Width < Me.Width) Then
                Knight.Left = Knight.Left + 25
            End If
            If moveLeft = True And Knight.Left > 0 Then
                Knight.Left = Knight.Left - 25
            End If
            If moveUp = True And Knight.Top > 0 Then
                Knight.Top = Knight.Top - 25
            End If
            If moveDown = True And Knight.Top + 1.5 * Knight.Width < Me.Height Then
                Knight.Top = Knight.Top + 25
            End If
        ElseIf DifChoice = "Normal" Then
            If moveRight = True And (Knight.Left + Knight.Width < Me.Width) Then
                Knight.Left = Knight.Left + 22
            End If
            If moveLeft = True And Knight.Left > 0 Then
                Knight.Left = Knight.Left - 22
            End If
            If moveUp = True And Knight.Top > 0 Then
                Knight.Top = Knight.Top - 22
            End If
            If moveDown = True And Knight.Top + 1.5 * Knight.Width < Me.Height Then
                Knight.Top = Knight.Top + 22
            End If
        ElseIf DifChoice = "Hard" Then
            If moveRight = True And (Knight.Left + Knight.Width < Me.Width) Then
                Knight.Left = Knight.Left + 19
            End If
            If moveLeft = True And Knight.Left > 0 Then
                Knight.Left = Knight.Left - 19
            End If
            If moveUp = True And Knight.Top > 0 Then
                Knight.Top = Knight.Top - 19
            End If
            If moveDown = True And Knight.Top + 1.5 * Knight.Width < Me.Height Then
                Knight.Top = Knight.Top + 19
            End If
        End If

        If Collision(Knight, Diamond) = True Then
            SoundEffect.SoundLocation = "Pickup.wav"
            SoundEffect.Play()
            Diamond.Top = Int(Rnd() * (480 - 2 * Diamond.Height) + Diamond.Height)
            Diamond.Left = Int(Rnd() * (640 - 2 * Diamond.Width) + Diamond.Width)
            Diamond.BringToFront()
            Debug.WriteLine("diamond top: " & Diamond.Top)
            Debug.WriteLine("diamond left: " & Diamond.Left)
            If DifChoice = "Easy" Then
                score += 0.5
            ElseIf DifChoice = "Normal" Then
                score += 1
            ElseIf DifChoice = "Hard" Then
                score += 2
            End If
            ScoreLabel.Text = "Score: " & score
        End If




        If Countdown > 0 Then
            Knight.BackColor = Color.Yellow
        Else
            Knight.BackColor = Color.Transparent
        End If

        If Countdown < 0 Then
            For i = 0 To 2
                If Collision(Knight, enemyarray(i)) Then
                    collided = True
                End If
            Next
        End If

        If collided = True Then
            For i = 0 To 2
                SoundEffect.SoundLocation = "HitSound.wav"
                SoundEffect.Play()
                AssignRandomPosition(enemyarray(i))
            Next
            lives -= 1
            LivesLabel.Text = "Lives: " & lives
            Knight.Top = 0
            Knight.Left = 0
            Countdown = 1000
            Countdown -= 50
            If lives = 0 Then
                Timer1.Stop()
                MsgBox("Game Over, try again!")
                ReturnToMainMenuLabel.Visible = True
                If score > HS Then
                    HS = score
                    HSLabel.Text = "High Score: " & HS
                    UserName = InputBox("Enter Your Name: ", "Username: ")
                    UserNameLabel.Text = "Best Player: " & UserName
                    FileNum = FreeFile()
                    FileOpen(FileNum, "Leaderboards.txt", OpenMode.Output)
                    PrintLine(FileNum, UserName)
                    PrintLine(FileNum, HS)
                    FileClose(FileNum)
                End If
            End If
            collided = False
        End If

        For i = 0 To 2
            Chase(enemyarray(i), Knight)
        Next
        Seperation(Skelly, Jack)
        Seperation(Jack, Zombie)
        Seperation(Skelly, Zombie)
    End Sub

    Private Sub Gameplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As Object, i As Integer = 0
        Dim FileNum As Integer


        Timer1.Stop()
        DifChoice = InputBox("What Difficulty Would You Like: Easy, Normal or Hard", "Difficulty Selection")
        DifLabel.Text = DifChoice & " Mode"
        If DifChoice = "Easy" Then
            lives = 7
        ElseIf DifChoice = "Normal" Then
            lives = 5
        ElseIf DifChoice = "Hard" Then
            lives = 3
        End If
        LivesLabel.Text = "Lives: " & lives
        Knight.SendToBack()
        Timer1.Start()
        ReturnToMainMenuLabel.Visible = False
        For Each obj In Me.Controls
            If TypeOf obj Is PictureBox AndAlso obj.tag = "enemy" Then
                enemyarray(i) = obj
                i += 1
            End If
        Next
        FileNum = FreeFile()
        FileOpen(FileNum, "Leaderboards.txt", OpenMode.Input)
        UserName = LineInput(FileNum)
        HS = LineInput(FileNum)
        UserNameLabel.Text = "Best Player: " & UserName
        HSLabel.Text = "High Score: " & HS
        FileClose(FileNum)

    End Sub
    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
                Object2.top + Object2.height >= Object1.Top And
                Object1.left + Object1.width >= Object2.left And
                Object2.left + Object2.width >= Object1.left Then
            collided = True
        End If
        Return collided
    End Function

    Private Function Chase(ByRef Object1 As Object, ByRef Object2 As Object)
        If Object1.left + Object1.width > Object2.left And DifChoice = "Easy" Then
            Object1.left -= 7
            'if the knight is closer to the leftside than the enemy, The enemy will move left 
        End If

        If Object1.left + Object1.width > Object2.left And DifChoice = "Normal" Then
            Object1.left -= 10
            'if the knight is closer to the leftside than the enemy, The enemy will move left 
        End If

        If Object1.left + Object1.width > Object2.left And DifChoice = "Hard" Then
            Object1.left -= 13
            'if the knight is closer to the leftside than the enemy, The enemy will move left 
        End If


        If Object1.left + Object1.width < Object2.Left And DifChoice = "Easy" Then
            Object1.left += 7
            'if the Enemy is closer to the leftside than the knight, the enemy will move Right 
        End If

        If Object1.left + Object1.width < Object2.Left And DifChoice = "Normal" Then
            Object1.left += 10
            'if the Enemy is closer to the leftside than the knight, the enemy will move Right 
        End If

        If Object1.left + Object1.width < Object2.Left And DifChoice = "Hard" Then
            Object1.left += 13
            'if the Enemy is closer to the leftside than the knight, the enemy will move Right 
        End If


        If Object1.Top + Object1.height > Object2.Top And DifChoice = "Easy" Then
            Object1.Top -= 7
            'if the knight is closer to the Top than the enemy, The enemy will move Up
        End If

        If Object1.Top + Object1.height > Object2.Top And DifChoice = "Normal" Then
            Object1.Top -= 10
            'if the knight is closer to the Top than the enemy, The enemy will move Up
        End If

        If Object1.Top + Object1.height > Object2.Top And DifChoice = "Hard" Then
            Object1.Top -= 13
            'if the knight is closer to the Top than the enemy, The enemy will move Up
        End If

        If Object1.Top + Object1.height < Object2.Top And DifChoice = "Easy" Then
            Object1.top += 7
            'if the Enemy is closer to the top than the knight, The enemy will move down
        End If

        If Object1.Top + Object1.height < Object2.Top And DifChoice = "Normal" Then
            Object1.top += 10
            'if the Enemy is closer to the top than the knight, The enemy will move down
        End If

        If Object1.Top + Object1.height < Object2.Top And DifChoice = "Hard" Then
            Object1.top += 13
            'if the Enemy is closer to the top than the knight, The enemy will move down
        End If


    End Function

    Private Function AssignRandomPosition(ByRef enemyobj As Object)
        enemyobj.Top = Int((Rnd() * (700 - (2 * enemyobj.height))) + enemyobj.height)
        enemyobj.Left = Int(Rnd() * (700 - (2 * enemyobj.width)) + enemyobj.width)
    End Function

    Private Function Seperation(ByRef Obj1 As Object, ByRef Obj2 As Object)
        If Collision(Obj1, Obj2) Then
            If (Obj1.left > Obj2.left) Then
                Obj1.left += 5
                Obj2.left -= 5
                'Check if object 1 is on the right of object 2, If it is then move object 1 to the right and move object 2 to the left
            Else
                Obj1.left -= 5
                Obj2.left += 5
                'Check if object 1 is on the left of object 2, If it is then move object 1 to the left and move object 2 to the right
            End If
            If (Obj1.Top > Obj2.Top) Then
                Obj1.top -= 5
                Obj2.top += 5
            Else
                Obj1.top += 5
                Obj2.top -= 5
            End If
        End If

    End Function





End Class
