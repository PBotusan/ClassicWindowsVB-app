Public Class MainWindow
  
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

    End Sub

   
End Class
