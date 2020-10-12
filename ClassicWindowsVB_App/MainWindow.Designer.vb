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
        Me.StartTaskbarPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ShutDownApp = New System.Windows.Forms.Button()
        Me.StartTaskbarPanelDevider = New System.Windows.Forms.Panel()
        Me.UserPreferenceButton = New System.Windows.Forms.Button()
        Me.CalculatorButton = New System.Windows.Forms.Button()
        Me.TaskbarDown = New System.Windows.Forms.Panel()
        Me.TaskbarTimePamel = New System.Windows.Forms.Panel()
        Me.TaskbarDateLabel = New System.Windows.Forms.Label()
        Me.TaskbarTimeLabel = New System.Windows.Forms.Label()
        Me.TaskbarLeftPanel = New System.Windows.Forms.Panel()
        Me.TaskbarStartButton = New System.Windows.Forms.Button()
        Me.TimerForTaskbarTimeAndDate = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialogBackground = New System.Windows.Forms.ColorDialog()
        Me.Bureaublad.SuspendLayout
        Me.StartTaskbarPanel.SuspendLayout
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
        Me.Bureaublad.Controls.Add(Me.StartTaskbarPanel)
        Me.Bureaublad.Controls.Add(Me.UserPreferenceButton)
        Me.Bureaublad.Controls.Add(Me.CalculatorButton)
        Me.Bureaublad.Controls.Add(Me.TaskbarDown)
        Me.Bureaublad.Location = New System.Drawing.Point(0, -4)
        Me.Bureaublad.Name = "Bureaublad"
        Me.Bureaublad.Size = New System.Drawing.Size(626, 610)
        Me.Bureaublad.TabIndex = 0
        '
        'StartTaskbarPanel
        '
        Me.StartTaskbarPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.StartTaskbarPanel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.StartTaskbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StartTaskbarPanel.Controls.Add(Me.Panel1)
        Me.StartTaskbarPanel.Controls.Add(Me.Button5)
        Me.StartTaskbarPanel.Controls.Add(Me.Button4)
        Me.StartTaskbarPanel.Controls.Add(Me.Button3)
        Me.StartTaskbarPanel.Controls.Add(Me.Button2)
        Me.StartTaskbarPanel.Controls.Add(Me.ShutDownApp)
        Me.StartTaskbarPanel.Controls.Add(Me.StartTaskbarPanelDevider)
        Me.StartTaskbarPanel.Location = New System.Drawing.Point(1, 282)
        Me.StartTaskbarPanel.Name = "StartTaskbarPanel"
        Me.StartTaskbarPanel.Size = New System.Drawing.Size(250, 280)
        Me.StartTaskbarPanel.TabIndex = 3
        Me.StartTaskbarPanel.Visible = false
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(43, 279)
        Me.Panel1.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(36, 162)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(207, 47)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(36, 109)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 47)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(36, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 47)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(36, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = true
        '
        'ShutDownApp
        '
        Me.ShutDownApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShutDownApp.FlatAppearance.BorderSize = 0
        Me.ShutDownApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShutDownApp.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ShutDownApp.Location = New System.Drawing.Point(36, 225)
        Me.ShutDownApp.Name = "ShutDownApp"
        Me.ShutDownApp.Size = New System.Drawing.Size(207, 47)
        Me.ShutDownApp.TabIndex = 1
        Me.ShutDownApp.Text = "    Shut Down..."
        Me.ShutDownApp.UseVisualStyleBackColor = true
        '
        'StartTaskbarPanelDevider
        '
        Me.StartTaskbarPanelDevider.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.StartTaskbarPanelDevider.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.StartTaskbarPanelDevider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StartTaskbarPanelDevider.Location = New System.Drawing.Point(-1, 218)
        Me.StartTaskbarPanelDevider.Name = "StartTaskbarPanelDevider"
        Me.StartTaskbarPanelDevider.Size = New System.Drawing.Size(250, 4)
        Me.StartTaskbarPanelDevider.TabIndex = 0
        '
        'UserPreferenceButton
        '
        Me.UserPreferenceButton.BackgroundImage = Global.ClassicWindowsVB_App.My.Resources.Resources.win95desklamp1
        Me.UserPreferenceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UserPreferenceButton.FlatAppearance.BorderSize = 0
        Me.UserPreferenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserPreferenceButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UserPreferenceButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.UserPreferenceButton.Location = New System.Drawing.Point(509, 458)
        Me.UserPreferenceButton.Name = "UserPreferenceButton"
        Me.UserPreferenceButton.Size = New System.Drawing.Size(109, 97)
        Me.UserPreferenceButton.TabIndex = 2
        Me.UserPreferenceButton.Text = "Preferences"
        Me.UserPreferenceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UserPreferenceButton.UseVisualStyleBackColor = true
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
        'TaskbarDown
        '
        Me.TaskbarDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarDown.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TaskbarDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskbarDown.Controls.Add(Me.TaskbarTimePamel)
        Me.TaskbarDown.Controls.Add(Me.TaskbarLeftPanel)
        Me.TaskbarDown.Location = New System.Drawing.Point(0, 561)
        Me.TaskbarDown.Name = "TaskbarDown"
        Me.TaskbarDown.Size = New System.Drawing.Size(623, 52)
        Me.TaskbarDown.TabIndex = 0
        '
        'TaskbarTimePamel
        '
        Me.TaskbarTimePamel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarTimePamel.BackColor = System.Drawing.Color.Silver
        Me.TaskbarTimePamel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskbarTimePamel.Controls.Add(Me.TaskbarDateLabel)
        Me.TaskbarTimePamel.Controls.Add(Me.TaskbarTimeLabel)
        Me.TaskbarTimePamel.Location = New System.Drawing.Point(510, 2)
        Me.TaskbarTimePamel.Name = "TaskbarTimePamel"
        Me.TaskbarTimePamel.Size = New System.Drawing.Size(106, 35)
        Me.TaskbarTimePamel.TabIndex = 0
        '
        'TaskbarDateLabel
        '
        Me.TaskbarDateLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TaskbarDateLabel.AutoSize = true
        Me.TaskbarDateLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TaskbarDateLabel.Location = New System.Drawing.Point(8, 14)
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
        Me.TaskbarTimeLabel.Location = New System.Drawing.Point(28, 1)
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
        Me.TaskbarLeftPanel.Location = New System.Drawing.Point(3, 2)
        Me.TaskbarLeftPanel.Name = "TaskbarLeftPanel"
        Me.TaskbarLeftPanel.Size = New System.Drawing.Size(94, 35)
        Me.TaskbarLeftPanel.TabIndex = 1
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
        'TimerForTaskbarTimeAndDate
        '
        Me.TimerForTaskbarTimeAndDate.Enabled = true
        Me.TimerForTaskbarTimeAndDate.Interval = 1000
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(622, 599)
        Me.Controls.Add(Me.Bureaublad)
        Me.MinimumSize = New System.Drawing.Size(638, 638)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Bureaublad.ResumeLayout(false)
        Me.StartTaskbarPanel.ResumeLayout(false)
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
    Friend WithEvents UserPreferenceButton As Button
    Friend WithEvents ColorDialogBackground As ColorDialog
    Friend WithEvents StartTaskbarPanel As Panel
    Friend WithEvents StartTaskbarPanelDevider As Panel
    Friend WithEvents ShutDownApp As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
End Class
