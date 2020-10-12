Public Class MainWindow
  
    Dim backgroundColor
    Dim startPanelActive = False 

    Private Sub TimerForTaskbarTimeAndDate_Tick(sender As Object, e As EventArgs) Handles TimerForTaskbarTimeAndDate.Tick
        Dim currentTime as String = TimeOfDay.Hour & ":" & TimeOfDay.Minute
        TaskbarTimeLabel.Text = currentTime
        TaskbarDateLabel.Text = DateTime.Now.Date
    End Sub

    Private Sub CalculatorButton_Click(sender As Object, e As EventArgs) Handles CalculatorButton.Click
        'Create a new instance of the form class'
        Dim calculatorForm As New CalculatorForm

        'Show the calculator form'
        calculatorForm.Show()
    End Sub

    Private Sub TaskbarStartButton_Click(sender As Object, e As EventArgs) Handles TaskbarStartButton.Click
        if startPanelActive then
            StartTaskbarPanel.Visible = False
            startPanelActive = false
            return
        End If

        startPanelActive = True
        if startPanelActive then
            StartTaskbarPanel.Visible = True
        End If
    End Sub


    Private Sub UserPreferenceButton_Click(sender As Object, e As EventArgs) Handles UserPreferenceButton.Click
        PickColor()
    End Sub

    Private Sub PickColor()
        ColorDialogBackground.ShowDialog()
        BackgroundColor = ColorDialogBackground.Color

        ChangeColor(BackgroundColor)
    End Sub
    

    Private Sub ChangeColor(backgroundColor As Object)
        Bureaublad.BackColor = backgroundColor
    End Sub


    Private Sub ShutDownButton_Click(sender As Object, e As EventArgs) Handles ShutDownApp.Click
        Application.Exit()
    End Sub

End Class
