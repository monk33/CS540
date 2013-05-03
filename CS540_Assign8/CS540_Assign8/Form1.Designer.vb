<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.StatusBarLabel = New System.Windows.Forms.TextBox()
        Me.resizeControlLabel = New System.Windows.Forms.TextBox()
        Me.resizeFontLabelAlt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(222, 212)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(130, 49)
        Me.nextButton.TabIndex = 3
        Me.nextButton.Text = "NextButton"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'StatusBarLabel
        '
        Me.StatusBarLabel.Location = New System.Drawing.Point(95, 71)
        Me.StatusBarLabel.Name = "StatusBarLabel"
        Me.StatusBarLabel.Size = New System.Drawing.Size(100, 20)
        Me.StatusBarLabel.TabIndex = 4
        '
        'resizeControlLabel
        '
        Me.resizeControlLabel.Location = New System.Drawing.Point(381, 71)
        Me.resizeControlLabel.Name = "resizeControlLabel"
        Me.resizeControlLabel.Size = New System.Drawing.Size(100, 20)
        Me.resizeControlLabel.TabIndex = 5
        '
        'resizeFontLabelAlt
        '
        Me.resizeFontLabelAlt.Location = New System.Drawing.Point(222, 71)
        Me.resizeFontLabelAlt.Name = "resizeFontLabelAlt"
        Me.resizeFontLabelAlt.Size = New System.Drawing.Size(100, 20)
        Me.resizeFontLabelAlt.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 401)
        Me.Controls.Add(Me.resizeFontLabelAlt)
        Me.Controls.Add(Me.resizeControlLabel)
        Me.Controls.Add(Me.StatusBarLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents StatusBarLabel As System.Windows.Forms.TextBox
    Friend WithEvents resizeControlLabel As System.Windows.Forms.TextBox
    Friend WithEvents resizeFontLabelAlt As System.Windows.Forms.TextBox

End Class
