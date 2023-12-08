<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Story
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StoryToStartUpButton = New System.Windows.Forms.Button()
        Me.CircLabel = New System.Windows.Forms.Label()
        Me.SqrLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Main_Game.My.Resources.Resources.Story_Sequence__2_
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1155, 803)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StoryToStartUpButton
        '
        Me.StoryToStartUpButton.BackColor = System.Drawing.Color.Transparent
        Me.StoryToStartUpButton.Location = New System.Drawing.Point(1032, 12)
        Me.StoryToStartUpButton.Name = "StoryToStartUpButton"
        Me.StoryToStartUpButton.Size = New System.Drawing.Size(97, 54)
        Me.StoryToStartUpButton.TabIndex = 3
        Me.StoryToStartUpButton.Text = "Go to The Main Menu"
        Me.StoryToStartUpButton.UseVisualStyleBackColor = False
        '
        'CircLabel
        '
        Me.CircLabel.BackColor = System.Drawing.Color.White
        Me.CircLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircLabel.Location = New System.Drawing.Point(679, 50)
        Me.CircLabel.Name = "CircLabel"
        Me.CircLabel.Size = New System.Drawing.Size(163, 91)
        Me.CircLabel.TabIndex = 4
        Me.CircLabel.Text = "𝐀𝐧𝐨𝐭𝐡𝐞𝐫 𝐀𝐫𝐭𝐡𝐮𝐫 𝐚𝐧𝐝 𝐂𝐫𝐲𝐬𝐭𝐚𝐥 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "𝐀𝐝𝐯𝐞𝐧𝐭𝐮𝐫𝐞.. 𝐋𝐞𝐭𝐬" &
    " 𝐆𝐨!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqrLabel
        '
        Me.SqrLabel.BackColor = System.Drawing.Color.White
        Me.SqrLabel.Font = New System.Drawing.Font("Georgia", 7.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqrLabel.Location = New System.Drawing.Point(399, 167)
        Me.SqrLabel.Name = "SqrLabel"
        Me.SqrLabel.Size = New System.Drawing.Size(168, 82)
        Me.SqrLabel.TabIndex = 5
        Me.SqrLabel.Text = "Hey we Should check out that Chapel.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I Heard there was a bounty on the monsters" &
    " undeneath it.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Story
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 796)
        Me.Controls.Add(Me.SqrLabel)
        Me.Controls.Add(Me.CircLabel)
        Me.Controls.Add(Me.StoryToStartUpButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Story"
        Me.Text = "Story"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StoryToStartUpButton As Button
    Friend WithEvents CircLabel As Label
    Friend WithEvents SqrLabel As Label
End Class
