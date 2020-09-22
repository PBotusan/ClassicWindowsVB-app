Public Class CalculatorForm

    ''' <summary>
    ''' Value of result.
    ''' </summary>
    Private Dim value as Double

    ''' <summary>
    ''' Stores operation value +/-/:
    ''' </summary>
    Private Dim currentOperation as String

    ''' <summary>
    ''' True/false when operation is being used.
    ''' </summary>
    private Dim operation as Boolean = false




    Private Sub User_button_click(sender As Object, e As EventArgs) Handles DigitZeroButton.Click, SquareRootButton.Click, PlusMinusButton.Click, OnmeTimesXButton.Click, MSButton.Click, MRButton.Click, MPlusButton.Click, ModuloButton.Click, MCButton.Click, DigitTwoButton.Click, DigitThreeButton.Click, DigitSixButton.Click, DigitSevenButton.Click, DigitPointButton.Click, DigitOneButton.Click, DigitNineButton.Click, DigitFourButton.Click, DigitFiveButton.Click, DigitEightButton.Click, BackButton.Click
        
        Dim userButtonInput as Button = sender

        if CalcInputLabel.Text = "0" or operation then
            CalcInputLabel.Text = Nothing
        End If

        if userButtonInput.Text.Contains(",") then
            if CalcInputLabel.Text.Contains(",") then
                Return
            end if
        End if
        
               
        
        Dim currentLabel as String
        operation = false

        currentLabel = CalcInputLabel.Text
        CalcInputLabel.Text = currentLabel + userButtonInput.Text
    End Sub

    Private Sub Operator_Button(sender As Object, e As EventArgs) Handles PlusButton.Click, TimesButton.Click, MinusButton.Click, DevideButton.Click
        Try 
             Dim userOperationButtonInput as Button = sender
            currentOperation = userOperationButtonInput.Text
            value = Double.Parse(CalcInputLabel.Text)
            operationPerformedLabel.Text = value & " " & currentOperation
            operation = true

        Catch ex As Exception
            'Todo logger
        End Try

    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        Try 
             if currentOperation  = "-" then
                CalcInputLabel.Text = value - double.Parse(CalcInputLabel.Text)

             ElseIf currentOperation = "+" then
                CalcInputLabel.Text = value + double.Parse(CalcInputLabel.Text)

             ElseIf currentOperation = "*" then
                CalcInputLabel.Text = value * double.Parse(CalcInputLabel.Text)

             ElseIf currentOperation = "/" then
                CalcInputLabel.Text = value / double.Parse(CalcInputLabel.Text)
        
              Else
              Return
        End If

        Catch ex As Exception
            'todo logger
        End Try
       

    End Sub

     Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Try
            value = Nothing
            CalcInputLabel.Text = ""

        Catch ex As Exception
            'todo logger
        End Try
       
     End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        Try
            CalcInputLabel.Text = ""
            value = Nothing
            operationPerformedLabel.Text = value
        Catch ex As Exception
            'todo logger
        End Try
        
    End Sub

End Class