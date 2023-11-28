<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoadingMsg = New System.Windows.Forms.Label()
        Me.lblProgPercent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progBar
        '
        Me.progBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progBar.Location = New System.Drawing.Point(176, 318)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(488, 47)
        Me.progBar.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'lblLoadingMsg
        '
        Me.lblLoadingMsg.AutoSize = True
        Me.lblLoadingMsg.Location = New System.Drawing.Point(176, 266)
        Me.lblLoadingMsg.Name = "lblLoadingMsg"
        Me.lblLoadingMsg.Size = New System.Drawing.Size(78, 20)
        Me.lblLoadingMsg.TabIndex = 2
        Me.lblLoadingMsg.Text = "Loading..."
        '
        'lblProgPercent
        '
        Me.lblProgPercent.AutoSize = True
        Me.lblProgPercent.Location = New System.Drawing.Point(606, 275)
        Me.lblProgPercent.Name = "lblProgPercent"
        Me.lblProgPercent.Size = New System.Drawing.Size(32, 20)
        Me.lblProgPercent.TabIndex = 3
        Me.lblProgPercent.Text = "0%"
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(854, 521)
        Me.Controls.Add(Me.lblProgPercent)
        Me.Controls.Add(Me.lblLoadingMsg)
        Me.Controls.Add(Me.progBar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents progBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLoadingMsg As Label
    Friend WithEvents lblProgPercent As Label
End Class
