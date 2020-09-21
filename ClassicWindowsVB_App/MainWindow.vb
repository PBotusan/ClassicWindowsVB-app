Public Class MainWindow
    Private Sub TimerForTaskbarTimeAndDate_Tick(sender As Object, e As EventArgs) Handles TimerForTaskbarTimeAndDate.Tick
        Dim currentTime as String = TimeOfDay.Hour & ":" & TimeOfDay.Minute
        TaskbarTimeLabel.Text = currentTime
        TaskbarDateLabel.Text = DateTime.Now.Date
    End Sub
End Class
