<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorForm))
        Me.CalculatorPanel = New System.Windows.Forms.Panel()
        Me.operationPerformedLabel = New System.Windows.Forms.Label()
        Me.CalculatorTopBar = New System.Windows.Forms.Panel()
        Me.CalcHelpButton = New System.Windows.Forms.Button()
        Me.CalcViewButton = New System.Windows.Forms.Button()
        Me.CalcEditButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserInputLabel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SquareRootButton = New System.Windows.Forms.Button()
        Me.ModuloButton = New System.Windows.Forms.Button()
        Me.EqualsButton = New System.Windows.Forms.Button()
        Me.DevideButton = New System.Windows.Forms.Button()
        Me.TimesButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.DigitNineButton = New System.Windows.Forms.Button()
        Me.DigitSixButton = New System.Windows.Forms.Button()
        Me.DigitThreeButton = New System.Windows.Forms.Button()
        Me.DigitPointButton = New System.Windows.Forms.Button()
        Me.DigitEightButton = New System.Windows.Forms.Button()
        Me.DigitFiveButton = New System.Windows.Forms.Button()
        Me.DigitTwoButton = New System.Windows.Forms.Button()
        Me.PlusMinusButton = New System.Windows.Forms.Button()
        Me.DigitSevenButton = New System.Windows.Forms.Button()
        Me.DigitFourButton = New System.Windows.Forms.Button()
        Me.DigitOneButton = New System.Windows.Forms.Button()
        Me.DigitZeroButton = New System.Windows.Forms.Button()
        Me.CalcInputLabel = New System.Windows.Forms.Label()
        Me.MCButton = New System.Windows.Forms.Button()
        Me.MRButton = New System.Windows.Forms.Button()
        Me.MSButton = New System.Windows.Forms.Button()
        Me.MPlusButton = New System.Windows.Forms.Button()
        Me.CalculatorPanel.SuspendLayout
        Me.CalculatorTopBar.SuspendLayout
        Me.UserInputLabel.SuspendLayout
        Me.SuspendLayout
        '
        'CalculatorPanel
        '
        Me.CalculatorPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CalculatorPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.CalculatorPanel.Controls.Add(Me.operationPerformedLabel)
        Me.CalculatorPanel.Controls.Add(Me.CalculatorTopBar)
        Me.CalculatorPanel.Controls.Add(Me.Panel2)
        Me.CalculatorPanel.Controls.Add(Me.Panel1)
        Me.CalculatorPanel.Controls.Add(Me.UserInputLabel)
        Me.CalculatorPanel.Controls.Add(Me.ClearAllButton)
        Me.CalculatorPanel.Controls.Add(Me.ClearButton)
        Me.CalculatorPanel.Controls.Add(Me.BackButton)
        Me.CalculatorPanel.Controls.Add(Me.SquareRootButton)
        Me.CalculatorPanel.Controls.Add(Me.ModuloButton)
        Me.CalculatorPanel.Controls.Add(Me.EqualsButton)
        Me.CalculatorPanel.Controls.Add(Me.DevideButton)
        Me.CalculatorPanel.Controls.Add(Me.TimesButton)
        Me.CalculatorPanel.Controls.Add(Me.MinusButton)
        Me.CalculatorPanel.Controls.Add(Me.PlusButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitNineButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitSixButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitThreeButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitPointButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitEightButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitFiveButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitTwoButton)
        Me.CalculatorPanel.Controls.Add(Me.PlusMinusButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitSevenButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitFourButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitOneButton)
        Me.CalculatorPanel.Controls.Add(Me.DigitZeroButton)
        Me.CalculatorPanel.Controls.Add(Me.MCButton)
        Me.CalculatorPanel.Controls.Add(Me.MRButton)
        Me.CalculatorPanel.Controls.Add(Me.MSButton)
        Me.CalculatorPanel.Controls.Add(Me.MPlusButton)
        Me.CalculatorPanel.Location = New System.Drawing.Point(-3, 0)
        Me.CalculatorPanel.Name = "CalculatorPanel"
        Me.CalculatorPanel.Size = New System.Drawing.Size(447, 432)
        Me.CalculatorPanel.TabIndex = 0
        '
        'operationPerformedLabel
        '
        Me.operationPerformedLabel.AutoSize = true
        Me.operationPerformedLabel.Font = New System.Drawing.Font("Verdana", 12!)
        Me.operationPerformedLabel.Location = New System.Drawing.Point(17, 72)
        Me.operationPerformedLabel.Name = "operationPerformedLabel"
        Me.operationPerformedLabel.Size = New System.Drawing.Size(0, 18)
        Me.operationPerformedLabel.TabIndex = 32
        '
        'CalculatorTopBar
        '
        Me.CalculatorTopBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CalculatorTopBar.BackColor = System.Drawing.Color.Gainsboro
        Me.CalculatorTopBar.Controls.Add(Me.CalcHelpButton)
        Me.CalculatorTopBar.Controls.Add(Me.CalcViewButton)
        Me.CalculatorTopBar.Controls.Add(Me.CalcEditButton)
        Me.CalculatorTopBar.Location = New System.Drawing.Point(3, -2)
        Me.CalculatorTopBar.Name = "CalculatorTopBar"
        Me.CalculatorTopBar.Size = New System.Drawing.Size(441, 44)
        Me.CalculatorTopBar.TabIndex = 31
        '
        'CalcHelpButton
        '
        Me.CalcHelpButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CalcHelpButton.BackColor = System.Drawing.Color.Gainsboro
        Me.CalcHelpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CalcHelpButton.FlatAppearance.BorderSize = 0
        Me.CalcHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcHelpButton.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CalcHelpButton.Location = New System.Drawing.Point(136, 3)
        Me.CalcHelpButton.Name = "CalcHelpButton"
        Me.CalcHelpButton.Size = New System.Drawing.Size(62, 36)
        Me.CalcHelpButton.TabIndex = 2
        Me.CalcHelpButton.Text = "Help"
        Me.CalcHelpButton.UseVisualStyleBackColor = false
        '
        'CalcViewButton
        '
        Me.CalcViewButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CalcViewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CalcViewButton.FlatAppearance.BorderSize = 0
        Me.CalcViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcViewButton.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CalcViewButton.Location = New System.Drawing.Point(68, 3)
        Me.CalcViewButton.Name = "CalcViewButton"
        Me.CalcViewButton.Size = New System.Drawing.Size(62, 36)
        Me.CalcViewButton.TabIndex = 1
        Me.CalcViewButton.Text = "View"
        Me.CalcViewButton.UseVisualStyleBackColor = true
        '
        'CalcEditButton
        '
        Me.CalcEditButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CalcEditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CalcEditButton.FlatAppearance.BorderSize = 0
        Me.CalcEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcEditButton.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CalcEditButton.Location = New System.Drawing.Point(0, 3)
        Me.CalcEditButton.Name = "CalcEditButton"
        Me.CalcEditButton.Size = New System.Drawing.Size(62, 38)
        Me.CalcEditButton.TabIndex = 0
        Me.CalcEditButton.Text = "Edit"
        Me.CalcEditButton.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(1, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 5)
        Me.Panel2.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(13, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 47)
        Me.Panel1.TabIndex = 29
        '
        'UserInputLabel
        '
        Me.UserInputLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserInputLabel.BackColor = System.Drawing.SystemColors.Window
        Me.UserInputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserInputLabel.Controls.Add(Me.CalcInputLabel)
        Me.UserInputLabel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.UserInputLabel.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UserInputLabel.Location = New System.Drawing.Point(13, 93)
        Me.UserInputLabel.Name = "UserInputLabel"
        Me.UserInputLabel.Size = New System.Drawing.Size(411, 39)
        Me.UserInputLabel.TabIndex = 28
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearAllButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearAllButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.ClearAllButton.ForeColor = System.Drawing.Color.Maroon
        Me.ClearAllButton.Location = New System.Drawing.Point(343, 146)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(81, 47)
        Me.ClearAllButton.TabIndex = 26
        Me.ClearAllButton.Text = "C"
        Me.ClearAllButton.UseVisualStyleBackColor = true
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.ClearButton.ForeColor = System.Drawing.Color.Maroon
        Me.ClearButton.Location = New System.Drawing.Point(257, 146)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(81, 47)
        Me.ClearButton.TabIndex = 25
        Me.ClearButton.Text = "CE"
        Me.ClearButton.UseVisualStyleBackColor = true
        '
        'BackButton
        '
        Me.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.BackButton.ForeColor = System.Drawing.Color.Maroon
        Me.BackButton.Location = New System.Drawing.Point(171, 146)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(81, 47)
        Me.BackButton.TabIndex = 24
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = true
        '
        'SquareRootButton
        '
        Me.SquareRootButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SquareRootButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SquareRootButton.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SquareRootButton.ForeColor = System.Drawing.Color.Navy
        Me.SquareRootButton.Location = New System.Drawing.Point(363, 201)
        Me.SquareRootButton.Name = "SquareRootButton"
        Me.SquareRootButton.Size = New System.Drawing.Size(62, 46)
        Me.SquareRootButton.TabIndex = 23
        Me.SquareRootButton.Text = "sqrt"
        Me.SquareRootButton.UseVisualStyleBackColor = true
        '
        'ModuloButton
        '
        Me.ModuloButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ModuloButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModuloButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.ModuloButton.ForeColor = System.Drawing.Color.Navy
        Me.ModuloButton.Location = New System.Drawing.Point(363, 256)
        Me.ModuloButton.Name = "ModuloButton"
        Me.ModuloButton.Size = New System.Drawing.Size(62, 46)
        Me.ModuloButton.TabIndex = 22
        Me.ModuloButton.Text = "%"
        Me.ModuloButton.UseVisualStyleBackColor = true
        '
        'EqualsButton
        '
        Me.EqualsButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EqualsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EqualsButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.EqualsButton.ForeColor = System.Drawing.Color.Red
        Me.EqualsButton.Location = New System.Drawing.Point(363, 311)
        Me.EqualsButton.Name = "EqualsButton"
        Me.EqualsButton.Size = New System.Drawing.Size(62, 101)
        Me.EqualsButton.TabIndex = 20
        Me.EqualsButton.Text = "="
        Me.EqualsButton.UseVisualStyleBackColor = true
        '
        'DevideButton
        '
        Me.DevideButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DevideButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DevideButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DevideButton.ForeColor = System.Drawing.Color.Red
        Me.DevideButton.Location = New System.Drawing.Point(296, 201)
        Me.DevideButton.Name = "DevideButton"
        Me.DevideButton.Size = New System.Drawing.Size(62, 46)
        Me.DevideButton.TabIndex = 19
        Me.DevideButton.Text = "/"
        Me.DevideButton.UseVisualStyleBackColor = true
        '
        'TimesButton
        '
        Me.TimesButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TimesButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.TimesButton.ForeColor = System.Drawing.Color.Red
        Me.TimesButton.Location = New System.Drawing.Point(296, 256)
        Me.TimesButton.Name = "TimesButton"
        Me.TimesButton.Size = New System.Drawing.Size(62, 46)
        Me.TimesButton.TabIndex = 18
        Me.TimesButton.Text = "*"
        Me.TimesButton.UseVisualStyleBackColor = true
        '
        'MinusButton
        '
        Me.MinusButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MinusButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinusButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.MinusButton.ForeColor = System.Drawing.Color.Red
        Me.MinusButton.Location = New System.Drawing.Point(296, 311)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(62, 46)
        Me.MinusButton.TabIndex = 17
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = true
        '
        'PlusButton
        '
        Me.PlusButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlusButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlusButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.PlusButton.ForeColor = System.Drawing.Color.Red
        Me.PlusButton.Location = New System.Drawing.Point(296, 367)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(62, 46)
        Me.PlusButton.TabIndex = 16
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = true
        '
        'DigitNineButton
        '
        Me.DigitNineButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitNineButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitNineButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitNineButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitNineButton.Location = New System.Drawing.Point(229, 201)
        Me.DigitNineButton.Name = "DigitNineButton"
        Me.DigitNineButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitNineButton.TabIndex = 15
        Me.DigitNineButton.Text = "9"
        Me.DigitNineButton.UseVisualStyleBackColor = true
        '
        'DigitSixButton
        '
        Me.DigitSixButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitSixButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitSixButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitSixButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitSixButton.Location = New System.Drawing.Point(229, 256)
        Me.DigitSixButton.Name = "DigitSixButton"
        Me.DigitSixButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitSixButton.TabIndex = 14
        Me.DigitSixButton.Text = "6"
        Me.DigitSixButton.UseVisualStyleBackColor = true
        '
        'DigitThreeButton
        '
        Me.DigitThreeButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitThreeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitThreeButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitThreeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitThreeButton.Location = New System.Drawing.Point(229, 311)
        Me.DigitThreeButton.Name = "DigitThreeButton"
        Me.DigitThreeButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitThreeButton.TabIndex = 13
        Me.DigitThreeButton.Text = "3"
        Me.DigitThreeButton.UseVisualStyleBackColor = true
        '
        'DigitPointButton
        '
        Me.DigitPointButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitPointButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitPointButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitPointButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitPointButton.Location = New System.Drawing.Point(229, 366)
        Me.DigitPointButton.Name = "DigitPointButton"
        Me.DigitPointButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitPointButton.TabIndex = 12
        Me.DigitPointButton.Text = ","
        Me.DigitPointButton.UseVisualStyleBackColor = true
        '
        'DigitEightButton
        '
        Me.DigitEightButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitEightButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitEightButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitEightButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitEightButton.Location = New System.Drawing.Point(162, 201)
        Me.DigitEightButton.Name = "DigitEightButton"
        Me.DigitEightButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitEightButton.TabIndex = 11
        Me.DigitEightButton.Text = "8"
        Me.DigitEightButton.UseVisualStyleBackColor = true
        '
        'DigitFiveButton
        '
        Me.DigitFiveButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitFiveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitFiveButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitFiveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitFiveButton.Location = New System.Drawing.Point(162, 256)
        Me.DigitFiveButton.Name = "DigitFiveButton"
        Me.DigitFiveButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitFiveButton.TabIndex = 10
        Me.DigitFiveButton.Text = "5"
        Me.DigitFiveButton.UseVisualStyleBackColor = true
        '
        'DigitTwoButton
        '
        Me.DigitTwoButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitTwoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitTwoButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitTwoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitTwoButton.Location = New System.Drawing.Point(162, 311)
        Me.DigitTwoButton.Name = "DigitTwoButton"
        Me.DigitTwoButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitTwoButton.TabIndex = 9
        Me.DigitTwoButton.Text = "2"
        Me.DigitTwoButton.UseVisualStyleBackColor = true
        '
        'PlusMinusButton
        '
        Me.PlusMinusButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlusMinusButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlusMinusButton.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PlusMinusButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.PlusMinusButton.Location = New System.Drawing.Point(162, 366)
        Me.PlusMinusButton.Name = "PlusMinusButton"
        Me.PlusMinusButton.Size = New System.Drawing.Size(62, 46)
        Me.PlusMinusButton.TabIndex = 8
        Me.PlusMinusButton.Text = "+/-"
        Me.PlusMinusButton.UseVisualStyleBackColor = true
        '
        'DigitSevenButton
        '
        Me.DigitSevenButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitSevenButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitSevenButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitSevenButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitSevenButton.Location = New System.Drawing.Point(95, 201)
        Me.DigitSevenButton.Name = "DigitSevenButton"
        Me.DigitSevenButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitSevenButton.TabIndex = 7
        Me.DigitSevenButton.Text = "7"
        Me.DigitSevenButton.UseVisualStyleBackColor = true
        '
        'DigitFourButton
        '
        Me.DigitFourButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitFourButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitFourButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitFourButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitFourButton.Location = New System.Drawing.Point(94, 256)
        Me.DigitFourButton.Name = "DigitFourButton"
        Me.DigitFourButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitFourButton.TabIndex = 6
        Me.DigitFourButton.Text = "4"
        Me.DigitFourButton.UseVisualStyleBackColor = true
        '
        'DigitOneButton
        '
        Me.DigitOneButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitOneButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitOneButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitOneButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitOneButton.Location = New System.Drawing.Point(95, 311)
        Me.DigitOneButton.Name = "DigitOneButton"
        Me.DigitOneButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitOneButton.TabIndex = 5
        Me.DigitOneButton.Text = "1"
        Me.DigitOneButton.UseVisualStyleBackColor = true
        '
        'DigitZeroButton
        '
        Me.DigitZeroButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitZeroButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitZeroButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.DigitZeroButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DigitZeroButton.Location = New System.Drawing.Point(95, 366)
        Me.DigitZeroButton.Name = "DigitZeroButton"
        Me.DigitZeroButton.Size = New System.Drawing.Size(62, 46)
        Me.DigitZeroButton.TabIndex = 4
        Me.DigitZeroButton.Text = "0"
        Me.DigitZeroButton.UseVisualStyleBackColor = true
        '
        'CalcInputLabel
        '
        Me.CalcInputLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CalcInputLabel.AutoSize = true
        Me.CalcInputLabel.Font = New System.Drawing.Font("Verdana", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CalcInputLabel.Location = New System.Drawing.Point(376, 0)
        Me.CalcInputLabel.Name = "CalcInputLabel"
        Me.CalcInputLabel.Size = New System.Drawing.Size(28, 29)
        Me.CalcInputLabel.TabIndex = 0
        Me.CalcInputLabel.Text = "0"
        Me.CalcInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MCButton
        '
        Me.MCButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MCButton.BackColor = System.Drawing.Color.DarkGray
        Me.MCButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MCButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.MCButton.ForeColor = System.Drawing.Color.Red
        Me.MCButton.Location = New System.Drawing.Point(12, 201)
        Me.MCButton.Name = "MCButton"
        Me.MCButton.Size = New System.Drawing.Size(62, 46)
        Me.MCButton.TabIndex = 3
        Me.MCButton.Text = "MC"
        Me.MCButton.UseVisualStyleBackColor = false
        '
        'MRButton
        '
        Me.MRButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MRButton.BackColor = System.Drawing.Color.DarkGray
        Me.MRButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MRButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.MRButton.ForeColor = System.Drawing.Color.Red
        Me.MRButton.Location = New System.Drawing.Point(13, 256)
        Me.MRButton.Name = "MRButton"
        Me.MRButton.Size = New System.Drawing.Size(62, 46)
        Me.MRButton.TabIndex = 2
        Me.MRButton.Text = "MR"
        Me.MRButton.UseVisualStyleBackColor = false
        '
        'MSButton
        '
        Me.MSButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MSButton.BackColor = System.Drawing.Color.DarkGray
        Me.MSButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.MSButton.ForeColor = System.Drawing.Color.Red
        Me.MSButton.Location = New System.Drawing.Point(12, 311)
        Me.MSButton.Name = "MSButton"
        Me.MSButton.Size = New System.Drawing.Size(62, 46)
        Me.MSButton.TabIndex = 1
        Me.MSButton.Text = "MS"
        Me.MSButton.UseVisualStyleBackColor = false
        '
        'MPlusButton
        '
        Me.MPlusButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MPlusButton.BackColor = System.Drawing.Color.DarkGray
        Me.MPlusButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MPlusButton.Font = New System.Drawing.Font("Verdana", 18!)
        Me.MPlusButton.ForeColor = System.Drawing.Color.Red
        Me.MPlusButton.Location = New System.Drawing.Point(13, 366)
        Me.MPlusButton.Name = "MPlusButton"
        Me.MPlusButton.Size = New System.Drawing.Size(62, 46)
        Me.MPlusButton.TabIndex = 0
        Me.MPlusButton.Text = "M+"
        Me.MPlusButton.UseVisualStyleBackColor = false
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(443, 426)
        Me.Controls.Add(Me.CalculatorPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "CalculatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.CalculatorPanel.ResumeLayout(false)
        Me.CalculatorPanel.PerformLayout
        Me.CalculatorTopBar.ResumeLayout(false)
        Me.UserInputLabel.ResumeLayout(false)
        Me.UserInputLabel.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents CalculatorPanel As Panel
    Friend WithEvents ClearAllButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents SquareRootButton As Button
    Friend WithEvents ModuloButton As Button
    Friend WithEvents EqualsButton As Button
    Friend WithEvents DevideButton As Button
    Friend WithEvents TimesButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents PlusButton As Button
    Friend WithEvents DigitNineButton As Button
    Friend WithEvents DigitSixButton As Button
    Friend WithEvents DigitThreeButton As Button
    Friend WithEvents DigitPointButton As Button
    Friend WithEvents DigitEightButton As Button
    Friend WithEvents DigitFiveButton As Button
    Friend WithEvents DigitTwoButton As Button
    Friend WithEvents PlusMinusButton As Button
    Friend WithEvents DigitSevenButton As Button
    Friend WithEvents DigitFourButton As Button
    Friend WithEvents DigitOneButton As Button
    Friend WithEvents DigitZeroButton As Button
    Friend WithEvents UserInputLabel As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CalculatorTopBar As Panel
    Friend WithEvents CalcHelpButton As Button
    Friend WithEvents CalcViewButton As Button
    Friend WithEvents CalcEditButton As Button
    Friend WithEvents operationPerformedLabel As Label
    Friend WithEvents CalcInputLabel As Label
    Friend WithEvents MCButton As Button
    Friend WithEvents MRButton As Button
    Friend WithEvents MSButton As Button
    Friend WithEvents MPlusButton As Button
End Class
