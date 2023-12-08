<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartUp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LeaderBoardButton = New System.Windows.Forms.Button()
        Me.Knight = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Diamond = New System.Windows.Forms.PictureBox()
        Me.Jack = New System.Windows.Forms.PictureBox()
        Me.Skelly = New System.Windows.Forms.PictureBox()
        Me.Zombie = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StartGameButton = New System.Windows.Forms.Button()
        Me.SuperKnight = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.Knight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diamond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skelly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperKnight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 45)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "King Arthurs Dungeon Quest:"
        '
        'LeaderBoardButton
        '
        Me.LeaderBoardButton.Location = New System.Drawing.Point(642, 21)
        Me.LeaderBoardButton.Name = "LeaderBoardButton"
        Me.LeaderBoardButton.Size = New System.Drawing.Size(146, 41)
        Me.LeaderBoardButton.TabIndex = 19
        Me.LeaderBoardButton.Text = "View Leaderboard"
        Me.LeaderBoardButton.UseVisualStyleBackColor = True
        '
        'Knight
        '
        Me.Knight.Image = CType(resources.GetObject("Knight.Image"), System.Drawing.Image)
        Me.Knight.Location = New System.Drawing.Point(12, 72)
        Me.Knight.Name = "Knight"
        Me.Knight.Size = New System.Drawing.Size(84, 86)
        Me.Knight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Knight.TabIndex = 20
        Me.Knight.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "This is King Arthur, you can control him with the arrow keys"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 40)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Collect the Diamonds as part of King Arthurs treasure hunt, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The higher the scor" &
    "e the higher your position on the leaderboards!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Diamond
        '
        Me.Diamond.Image = CType(resources.GetObject("Diamond.Image"), System.Drawing.Image)
        Me.Diamond.Location = New System.Drawing.Point(12, 192)
        Me.Diamond.Name = "Diamond"
        Me.Diamond.Size = New System.Drawing.Size(84, 86)
        Me.Diamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Diamond.TabIndex = 33
        Me.Diamond.TabStop = False
        '
        'Jack
        '
        Me.Jack.Image = CType(resources.GetObject("Jack.Image"), System.Drawing.Image)
        Me.Jack.Location = New System.Drawing.Point(12, 299)
        Me.Jack.Name = "Jack"
        Me.Jack.Size = New System.Drawing.Size(64, 74)
        Me.Jack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jack.TabIndex = 34
        Me.Jack.TabStop = False
        Me.Jack.Tag = "enemy"
        '
        'Skelly
        '
        Me.Skelly.Image = CType(resources.GetObject("Skelly.Image"), System.Drawing.Image)
        Me.Skelly.Location = New System.Drawing.Point(82, 299)
        Me.Skelly.Name = "Skelly"
        Me.Skelly.Size = New System.Drawing.Size(64, 74)
        Me.Skelly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Skelly.TabIndex = 35
        Me.Skelly.TabStop = False
        Me.Skelly.Tag = "enemy"
        '
        'Zombie
        '
        Me.Zombie.Image = CType(resources.GetObject("Zombie.Image"), System.Drawing.Image)
        Me.Zombie.Location = New System.Drawing.Point(45, 381)
        Me.Zombie.Name = "Zombie"
        Me.Zombie.Size = New System.Drawing.Size(64, 74)
        Me.Zombie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie.TabIndex = 36
        Me.Zombie.TabStop = False
        Me.Zombie.Tag = "enemy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(383, 40)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "These are the Monsters roaming the dungeon, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "avoid them at all cost or King Arth" &
    "ur will lose a life"
        '
        'StartGameButton
        '
        Me.StartGameButton.Location = New System.Drawing.Point(642, 397)
        Me.StartGameButton.Name = "StartGameButton"
        Me.StartGameButton.Size = New System.Drawing.Size(146, 41)
        Me.StartGameButton.TabIndex = 38
        Me.StartGameButton.Text = "Start Game"
        Me.StartGameButton.UseVisualStyleBackColor = True
        '
        'SuperKnight
        '
        Me.SuperKnight.Image = CType(resources.GetObject("SuperKnight.Image"), System.Drawing.Image)
        Me.SuperKnight.Location = New System.Drawing.Point(12, 508)
        Me.SuperKnight.Name = "SuperKnight"
        Me.SuperKnight.Size = New System.Drawing.Size(84, 86)
        Me.SuperKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SuperKnight.TabIndex = 39
        Me.SuperKnight.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 508)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(602, 40)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Got hit? Don't Worry! When King Arthur is attacked he briefly goes into his " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GOD" &
    " ARTHUR mode, which allows him to not take any damage for a short time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(642, 588)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(146, 41)
        Me.ExitButton.TabIndex = 41
        Me.ExitButton.Text = "Exit Game"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 641)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SuperKnight)
        Me.Controls.Add(Me.StartGameButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Zombie)
        Me.Controls.Add(Me.Skelly)
        Me.Controls.Add(Me.Jack)
        Me.Controls.Add(Me.Diamond)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Knight)
        Me.Controls.Add(Me.LeaderBoardButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StartUp"
        Me.Text = "Form1"
        CType(Me.Knight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diamond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skelly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperKnight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LeaderBoardButton As Button
    Friend WithEvents Knight As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Diamond As PictureBox
    Friend WithEvents Jack As PictureBox
    Friend WithEvents Skelly As PictureBox
    Friend WithEvents Zombie As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents StartGameButton As Button
    Friend WithEvents SuperKnight As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ExitButton As Button
End Class
