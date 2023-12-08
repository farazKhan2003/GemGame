<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboards
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
        Me.HighestScorerLabel = New System.Windows.Forms.Label()
        Me.HighestScoreLabel = New System.Windows.Forms.Label()
        Me.ReturnLabel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HighestScorerLabel
        '
        Me.HighestScorerLabel.AutoSize = True
        Me.HighestScorerLabel.Location = New System.Drawing.Point(300, 55)
        Me.HighestScorerLabel.Name = "HighestScorerLabel"
        Me.HighestScorerLabel.Size = New System.Drawing.Size(187, 17)
        Me.HighestScorerLabel.TabIndex = 3
        Me.HighestScorerLabel.Text = "Username of Highest Scorer"
        '
        'HighestScoreLabel
        '
        Me.HighestScoreLabel.AutoSize = True
        Me.HighestScoreLabel.Location = New System.Drawing.Point(300, 155)
        Me.HighestScoreLabel.Name = "HighestScoreLabel"
        Me.HighestScoreLabel.Size = New System.Drawing.Size(105, 17)
        Me.HighestScoreLabel.TabIndex = 4
        Me.HighestScoreLabel.Text = "Highest Score: "
        '
        'ReturnLabel
        '
        Me.ReturnLabel.Location = New System.Drawing.Point(603, 376)
        Me.ReturnLabel.Name = "ReturnLabel"
        Me.ReturnLabel.Size = New System.Drawing.Size(185, 62)
        Me.ReturnLabel.TabIndex = 5
        Me.ReturnLabel.Text = "Return Back to the Main Menu"
        Me.ReturnLabel.UseVisualStyleBackColor = True
        '
        'Leaderboards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReturnLabel)
        Me.Controls.Add(Me.HighestScoreLabel)
        Me.Controls.Add(Me.HighestScorerLabel)
        Me.Name = "Leaderboards"
        Me.Text = "Leaderboards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HighestScorerLabel As Label
    Friend WithEvents HighestScoreLabel As Label
    Friend WithEvents ReturnLabel As Button
End Class
