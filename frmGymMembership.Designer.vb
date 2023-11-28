<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGymMembership
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSenior)
        Me.GroupBox1.Controls.Add(Me.radStudent)
        Me.GroupBox1.Controls.Add(Me.radChild)
        Me.GroupBox1.Controls.Add(Me.radAdult)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Of Membership"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(27, 189)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(132, 24)
        Me.radSenior.TabIndex = 3
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "Se&nior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(27, 138)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(91, 24)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(27, 86)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(161, 24)
        Me.radChild.TabIndex = 1
        Me.radChild.TabStop = True
        Me.radChild.Text = "Chil&d (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Location = New System.Drawing.Point(27, 34)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(141, 24)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTrainer)
        Me.GroupBox2.Controls.Add(Me.chkKarate)
        Me.GroupBox2.Controls.Add(Me.chkYoga)
        Me.GroupBox2.Location = New System.Drawing.Point(383, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 248)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Location = New System.Drawing.Point(44, 149)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(150, 24)
        Me.chkTrainer.TabIndex = 2
        Me.chkTrainer.Text = "&Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(44, 100)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(82, 24)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(44, 49)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(73, 24)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "&Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMonths)
        Me.GroupBox3.Controls.Add(Me.lblMonths)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 342)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(306, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Membership Length"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(31, 102)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(186, 26)
        Me.txtMonths.TabIndex = 1
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Location = New System.Drawing.Point(27, 59)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(190, 20)
        Me.lblMonths.TabIndex = 0
        Me.lblMonths.Text = "Enter Number Of Months:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblMonthlyFee)
        Me.GroupBox4.Controls.Add(Me.lblT)
        Me.GroupBox4.Controls.Add(Me.lblMonth)
        Me.GroupBox4.Location = New System.Drawing.Point(383, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 170)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Membership Fees"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(161, 89)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 3
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyFee.Location = New System.Drawing.Point(161, 43)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlyFee.TabIndex = 2
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Location = New System.Drawing.Point(74, 89)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(52, 20)
        Me.lblT.TabIndex = 1
        Me.lblT.Text = "Total: "
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(33, 43)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(100, 20)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Monthly Fee:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(35, 548)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(133, 48)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(208, 548)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 48)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(383, 548)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 48)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(731, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "lblStatus"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(555, 548)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(132, 48)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmGymMembership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 636)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGymMembership"
        Me.Text = "Membership Fee Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents lblMonths As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents lblT As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents btnNext As Button
End Class
