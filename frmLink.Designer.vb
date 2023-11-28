<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLink
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
        Me.btnGym = New System.Windows.Forms.Button()
        Me.btnLoanCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGym
        '
        Me.btnGym.Location = New System.Drawing.Point(86, 94)
        Me.btnGym.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGym.Name = "btnGym"
        Me.btnGym.Size = New System.Drawing.Size(110, 96)
        Me.btnGym.TabIndex = 0
        Me.btnGym.Text = "Gym Membership Form"
        Me.btnGym.UseVisualStyleBackColor = True
        '
        'btnLoanCalc
        '
        Me.btnLoanCalc.Location = New System.Drawing.Point(285, 94)
        Me.btnLoanCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoanCalc.Name = "btnLoanCalc"
        Me.btnLoanCalc.Size = New System.Drawing.Size(110, 96)
        Me.btnLoanCalc.TabIndex = 0
        Me.btnLoanCalc.Text = "Loan Calculator"
        Me.btnLoanCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 292)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoanCalc)
        Me.Controls.Add(Me.btnGym)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmLink"
        Me.RightToLeftLayout = True
        Me.Text = "Link"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGym As Button
    Friend WithEvents btnLoanCalc As Button
    Friend WithEvents btnExit As Button
End Class
