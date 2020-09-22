<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.Bureaublad = New System.Windows.Forms.Panel()
        Me.TaskbarDown = New System.Windows.Forms.Panel()
        Me.TaskbarTimePamel = New System.Windows.Forms.Panel()
        Me.TaskbarDateLabel = New System.Windows.Forms.Label()
        Me.TaskbarTimeLabel = New System.Windows.Forms.Label()
        Me.TaskbarLeftPanel = New System.Windows.Forms.Panel()
        Me.TimerForTaskbarTimeAndDate = New System.Windows.Forms.Timer(Me.components)
        Me.CalculatorButton = New System.Windows.Forms.Button()
        Me.TaskbarStartButton = New System.Windows.Forms.Button()
        Me.Bureaublad.SuspendLayout
        Me.TaskbarDown.SuspendLayout
        Me.TaskbarTimePamel.SuspendLayout
        Me.TaskbarLeftPanel.SuspendLayout
        Me.SuspendLayout
        '
        'Bureaublad
        '
        Me.Bureaublad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Bureaublad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Bureaublad.BackColor = System.Drawing.Color.Teal
        Me.Bureaublad.Controls.Add(Me.CalculatorButton)
        Me.Bureaublad.Controls.Add(Me.TaskbarDown)
        Me.Bureaublad.Location = New System.Drawing.Point(0, -4)
        Me.Bureaublad.Name = "Bureaublad"
        Me.Bureaublad.Size = New System.Drawing.Size(601, 523)
        Me.Bureaublad.TabIndex = 0
        '
        'TaskbarDown
        '
        Me.TaskbarDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarDown.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TaskbarDown.Controls.Add(Me.TaskbarTimePamel)
        Me.TaskbarDown.Controls.Add(Me.TaskbarLeftPanel)
        Me.TaskbarDown.Location = New System.Drawing.Point(0, 473)
        Me.TaskbarDown.Name = "TaskbarDown"
        Me.TaskbarDown.Size = New System.Drawing.Size(598, 50)
        Me.TaskbarDown.TabIndex = 0
        '
        'TaskbarTimePamel
        '
        Me.TaskbarTimePamel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarTimePamel.BackColor = System.Drawing.Color.Silver
        Me.TaskbarTimePamel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskbarTimePamel.Controls.Add(Me.TaskbarDateLabel)
        Me.TaskbarTimePamel.Controls.Add(Me.TaskbarTimeLabel)
        Me.TaskbarTimePamel.Location = New System.Drawing.Point(489, 5)
        Me.TaskbarTimePamel.Name = "TaskbarTimePamel"
        Me.TaskbarTimePamel.Size = New System.Drawing.Size(106, 33)
        Me.TaskbarTimePamel.TabIndex = 0
        '
        'TaskbarDateLabel
        '
        Me.TaskbarDateLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarDateLabel.AutoSize = true
        Me.TaskbarDateLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TaskbarDateLabel.Location = New System.Drawing.Point(12, 14)
        Me.TaskbarDateLabel.Name = "TaskbarDateLabel"
        Me.TaskbarDateLabel.Size = New System.Drawing.Size(86, 16)
        Me.TaskbarDateLabel.TabIndex = 1
        Me.TaskbarDateLabel.Text = "21-09-2020"
        '
        'TaskbarTimeLabel
        '
        Me.TaskbarTimeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarTimeLabel.AutoSize = true
        Me.TaskbarTimeLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TaskbarTimeLabel.Location = New System.Drawing.Point(32, 1)
        Me.TaskbarTimeLabel.Name = "TaskbarTimeLabel"
        Me.TaskbarTimeLabel.Size = New System.Drawing.Size(46, 16)
        Me.TaskbarTimeLabel.TabIndex = 0
        Me.TaskbarTimeLabel.Text = "00:00"
        '
        'TaskbarLeftPanel
        '
        Me.TaskbarLeftPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TaskbarLeftPanel.BackColor = System.Drawing.Color.Silver
        Me.TaskbarLeftPanel.Controls.Add(Me.TaskbarStartButton)
        Me.TaskbarLeftPanel.Location = New System.Drawing.Point(3, 4)
        Me.TaskbarLeftPanel.Name = "TaskbarLeftPanel"
        Me.TaskbarLeftPanel.Size = New System.Drawing.Size(94, 35)
        Me.TaskbarLeftPanel.TabIndex = 1
        '
        'TimerForTaskbarTimeAndDate
        '
        Me.TimerForTaskbarTimeAndDate.Enabled = true
        Me.TimerForTaskbarTimeAndDate.Interval = 1000
        '
        'CalculatorButton
        '
        Me.CalculatorButton.BackgroundImage = Global.ClassicWindowsVB_App.My.Resources.Resources.calculator98
        Me.CalculatorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CalculatorButton.FlatAppearance.BorderSize = 0
        Me.CalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculatorButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CalculatorButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CalculatorButton.Location = New System.Drawing.Point(12, 16)
        Me.CalculatorButton.Name = "CalculatorButton"
        Me.CalculatorButton.Size = New System.Drawing.Size(90, 90)
        Me.CalculatorButton.TabIndex = 1
        Me.CalculatorButton.Text = "Calculator"
        Me.CalculatorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CalculatorButton.UseVisualStyleBackColor = true
        '
        'TaskbarStartButton
        '
        Me.TaskbarStartButton.BackgroundImage = Global.ClassicWindowsVB_App.My.Resources.Resources.WindowsLogo
        Me.TaskbarStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TaskbarStartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TaskbarStartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.TaskbarStartButton.FlatAppearance.BorderSize = 0
        Me.TaskbarStartButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TaskbarStartButton.Location = New System.Drawing.Point(0, 0)
        Me.TaskbarStartButton.Name = "TaskbarStartButton"
        Me.TaskbarStartButton.Size = New System.Drawing.Size(94, 34)
        Me.TaskbarStartButton.TabIndex = 0
        Me.TaskbarStartButton.Text = "Start"
        Me.TaskbarStartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TaskbarStartButton.UseVisualStyleBackColor = true
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(597, 512)
        Me.Controls.Add(Me.Bureaublad)
        Me.Name = "MainWindow"
        Me.Text = "Form1"
        Me.Bureaublad.ResumeLayout(false)
        Me.TaskbarDown.ResumeLayout(false)
        Me.TaskbarTimePamel.ResumeLayout(false)
        Me.TaskbarTimePamel.PerformLayout
        Me.TaskbarLeftPanel.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Bureaublad As Panel
    Friend WithEvents TaskbarDown As Panel
    Friend WithEvents TaskbarTimePamel As Panel
    Friend WithEvents TaskbarLeftPanel As Panel
    Friend WithEvents TaskbarTimeLabel As Label
    Friend WithEvents TimerForTaskbarTimeAndDate As Timer
    Friend WithEvents TaskbarStartButton As Button
    Friend WithEvents TaskbarDateLabel As Label
    Friend WithEvents CalculatorButton As Button
End Class
