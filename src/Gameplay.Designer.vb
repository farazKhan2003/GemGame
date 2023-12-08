<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gameplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.LivesLabel = New System.Windows.Forms.Label()
        Me.HSLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.ReturnToMainMenuLabel = New System.Windows.Forms.Label()
        Me.NewGameLabel = New System.Windows.Forms.Label()
        Me.Zombie = New System.Windows.Forms.PictureBox()
        Me.Skelly = New System.Windows.Forms.PictureBox()
        Me.Jack = New System.Windows.Forms.PictureBox()
        Me.Knight = New System.Windows.Forms.PictureBox()
        Me.Diamond = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DifLabel = New System.Windows.Forms.Label()
        CType(Me.Zombie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skelly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Knight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diamond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.ForeColor = System.Drawing.Color.Black
        Me.ScoreLabel.Location = New System.Drawing.Point(13, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(53, 17)
        Me.ScoreLabel.TabIndex = 10
        Me.ScoreLabel.Text = "Score: "
        '
        'LivesLabel
        '
        Me.LivesLabel.AutoSize = True
        Me.LivesLabel.BackColor = System.Drawing.Color.Transparent
        Me.LivesLabel.ForeColor = System.Drawing.Color.Black
        Me.LivesLabel.Location = New System.Drawing.Point(13, 39)
        Me.LivesLabel.Name = "LivesLabel"
        Me.LivesLabel.Size = New System.Drawing.Size(45, 17)
        Me.LivesLabel.TabIndex = 11
        Me.LivesLabel.Text = "Lives:"
        '
        'HSLabel
        '
        Me.HSLabel.AutoSize = True
        Me.HSLabel.BackColor = System.Drawing.Color.Transparent
        Me.HSLabel.ForeColor = System.Drawing.Color.Black
        Me.HSLabel.Location = New System.Drawing.Point(13, 69)
        Me.HSLabel.Name = "HSLabel"
        Me.HSLabel.Size = New System.Drawing.Size(86, 17)
        Me.HSLabel.TabIndex = 12
        Me.HSLabel.Text = "High Score: "
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserNameLabel.ForeColor = System.Drawing.Color.Black
        Me.UserNameLabel.Location = New System.Drawing.Point(13, 99)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(81, 17)
        Me.UserNameLabel.TabIndex = 15
        Me.UserNameLabel.Text = "Username: "
        '
        'ReturnToMainMenuLabel
        '
        Me.ReturnToMainMenuLabel.AutoSize = True
        Me.ReturnToMainMenuLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReturnToMainMenuLabel.ForeColor = System.Drawing.Color.Black
        Me.ReturnToMainMenuLabel.Location = New System.Drawing.Point(280, 17)
        Me.ReturnToMainMenuLabel.Name = "ReturnToMainMenuLabel"
        Me.ReturnToMainMenuLabel.Size = New System.Drawing.Size(280, 17)
        Me.ReturnToMainMenuLabel.TabIndex = 16
        Me.ReturnToMainMenuLabel.Text = "Press ESC to return back to the Main menu"
        '
        'NewGameLabel
        '
        Me.NewGameLabel.AutoSize = True
        Me.NewGameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NewGameLabel.ForeColor = System.Drawing.Color.Black
        Me.NewGameLabel.Location = New System.Drawing.Point(604, 9)
        Me.NewGameLabel.Name = "NewGameLabel"
        Me.NewGameLabel.Size = New System.Drawing.Size(193, 17)
        Me.NewGameLabel.TabIndex = 17
        Me.NewGameLabel.Text = "Press R to Start a New Game"
        '
        'Zombie
        '
        Me.Zombie.BackColor = System.Drawing.Color.Transparent
        Me.Zombie.Image = Global.Main_Game.My.Resources.Resources.Zombie
        Me.Zombie.Location = New System.Drawing.Point(608, 29)
        Me.Zombie.Name = "Zombie"
        Me.Zombie.Size = New System.Drawing.Size(64, 74)
        Me.Zombie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie.TabIndex = 18
        Me.Zombie.TabStop = False
        Me.Zombie.Tag = "enemy"
        '
        'Skelly
        '
        Me.Skelly.BackColor = System.Drawing.Color.Transparent
        Me.Skelly.Image = Global.Main_Game.My.Resources.Resources.Skeleton_Grim_Reaper
        Me.Skelly.Location = New System.Drawing.Point(583, 218)
        Me.Skelly.Name = "Skelly"
        Me.Skelly.Size = New System.Drawing.Size(64, 74)
        Me.Skelly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Skelly.TabIndex = 19
        Me.Skelly.TabStop = False
        Me.Skelly.Tag = "enemy"
        '
        'Jack
        '
        Me.Jack.BackColor = System.Drawing.Color.Transparent
        Me.Jack.Image = Global.Main_Game.My.Resources.Resources.Jack_O_Lantern_Monster
        Me.Jack.Location = New System.Drawing.Point(704, 324)
        Me.Jack.Name = "Jack"
        Me.Jack.Size = New System.Drawing.Size(64, 74)
        Me.Jack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jack.TabIndex = 20
        Me.Jack.TabStop = False
        Me.Jack.Tag = "enemy"
        '
        'Knight
        '
        Me.Knight.BackColor = System.Drawing.Color.Transparent
        Me.Knight.Image = Global.Main_Game.My.Resources.Resources.Knight
        Me.Knight.Location = New System.Drawing.Point(74, 169)
        Me.Knight.Name = "Knight"
        Me.Knight.Size = New System.Drawing.Size(84, 86)
        Me.Knight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Knight.TabIndex = 21
        Me.Knight.TabStop = False
        '
        'Diamond
        '
        Me.Diamond.Image = Global.Main_Game.My.Resources.Resources.Diamond_wo_Background
        Me.Diamond.Location = New System.Drawing.Point(224, 349)
        Me.Diamond.Name = "Diamond"
        Me.Diamond.Size = New System.Drawing.Size(40, 38)
        Me.Diamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Diamond.TabIndex = 22
        Me.Diamond.TabStop = False
        '
        'Timer1
        '
        '
        'DifLabel
        '
        Me.DifLabel.AutoSize = True
        Me.DifLabel.Location = New System.Drawing.Point(115, 9)
        Me.DifLabel.Name = "DifLabel"
        Me.DifLabel.Size = New System.Drawing.Size(16, 17)
        Me.DifLabel.TabIndex = 23
        Me.DifLabel.Text = ".."
        '
        'Gameplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DifLabel)
        Me.Controls.Add(Me.Diamond)
        Me.Controls.Add(Me.Knight)
        Me.Controls.Add(Me.Jack)
        Me.Controls.Add(Me.Skelly)
        Me.Controls.Add(Me.Zombie)
        Me.Controls.Add(Me.NewGameLabel)
        Me.Controls.Add(Me.ReturnToMainMenuLabel)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.HSLabel)
        Me.Controls.Add(Me.LivesLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Name = "Gameplay"
        Me.Text = "Gameplay"
        CType(Me.Zombie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skelly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Knight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diamond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents LivesLabel As Label
    Friend WithEvents HSLabel As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents ReturnToMainMenuLabel As Label
    Friend WithEvents NewGameLabel As Label
    Friend WithEvents Zombie As PictureBox
    Friend WithEvents Skelly As PictureBox
    Friend WithEvents Jack As PictureBox
    Friend WithEvents Knight As PictureBox
    Friend WithEvents Diamond As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DifLabel As Label
End Class
