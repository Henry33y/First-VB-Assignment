<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtVehicleCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radUsed = New System.Windows.Forms.RadioButton()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstInterestAndPayments = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAnInterestRate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMonths)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtVehicleCost)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle and Loan Information"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(210, 116)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(124, 26)
        Me.txtMonths.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(210, 74)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(124, 26)
        Me.txtAmount.TabIndex = 2
        '
        'txtVehicleCost
        '
        Me.txtVehicleCost.Location = New System.Drawing.Point(210, 32)
        Me.txtVehicleCost.Name = "txtVehicleCost"
        Me.txtVehicleCost.Size = New System.Drawing.Size(124, 26)
        Me.txtVehicleCost.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number of Months:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Amount of Down Payment:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of Vehicle:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUsed)
        Me.GroupBox2.Controls.Add(Me.radNew)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New or Used?"
        '
        'radUsed
        '
        Me.radUsed.AutoSize = True
        Me.radUsed.Location = New System.Drawing.Point(33, 102)
        Me.radUsed.Name = "radUsed"
        Me.radUsed.Size = New System.Drawing.Size(72, 24)
        Me.radUsed.TabIndex = 0
        Me.radUsed.TabStop = True
        Me.radUsed.Text = "Used"
        Me.radUsed.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Location = New System.Drawing.Point(33, 53)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(65, 24)
        Me.radNew.TabIndex = 0
        Me.radNew.TabStop = True
        Me.radNew.Text = "New"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.CausesValidation = False
        Me.GroupBox3.Controls.Add(Me.lstInterestAndPayments)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 248)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interest and Principal Payments"
        '
        'lstInterestAndPayments
        '
        Me.lstInterestAndPayments.FormattingEnabled = True
        Me.lstInterestAndPayments.ItemHeight = 20
        Me.lstInterestAndPayments.Location = New System.Drawing.Point(14, 25)
        Me.lstInterestAndPayments.Name = "lstInterestAndPayments"
        Me.lstInterestAndPayments.Size = New System.Drawing.Size(746, 204)
        Me.lstInterestAndPayments.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(149, 520)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(125, 43)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(337, 520)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(520, 520)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 43)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(611, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Annual Interest Rate:"
        '
        'lblAnInterestRate
        '
        Me.lblAnInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnInterestRate.Location = New System.Drawing.Point(640, 132)
        Me.lblAnInterestRate.Name = "lblAnInterestRate"
        Me.lblAnInterestRate.Size = New System.Drawing.Size(100, 23)
        Me.lblAnInterestRate.TabIndex = 7
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 588)
        Me.Controls.Add(Me.lblAnInterestRate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoanCalculator"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtVehicleCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radUsed As RadioButton
    Friend WithEvents radNew As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAnInterestRate As Label
    Friend WithEvents lstInterestAndPayments As ListBox
End Class
