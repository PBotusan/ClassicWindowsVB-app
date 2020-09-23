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

    ''' <summary>
    ''' button used for user input in sender
    ''' </summary>
    Private Dim userButtonInput As Button

    ''' <summary>
    ''' button used for user input in sender
    ''' </summary>
    Dim userOperationButtonInput as Button

    ''' <summary>
    ''' label used to show value
    ''' </summary>
    Dim currentLabel as String


    Private Sub User_button_click(sender As Object, e As EventArgs) Handles DigitZeroButton.Click, MSButton.Click, MRButton.Click, MPlusButton.Click, MCButton.Click, DigitTwoButton.Click, DigitThreeButton.Click, DigitSixButton.Click, DigitSevenButton.Click, DigitPointButton.Click, DigitOneButton.Click, DigitNineButton.Click, DigitFourButton.Click, DigitFiveButton.Click, DigitEightButton.Click
        Try
            userButtonInput = sender
            
            if CalcInputLabel.Text = "0" or operation then
                CalcInputLabel.Text = Nothing
            End If

            if userButtonInput.Text.Contains(",") then
                if CalcInputLabel.Text.Contains(",") then
                    Return
                end if
            End if
          
            operation = false

            currentLabel = CalcInputLabel.Text
            CalcInputLabel.Text = currentLabel + userButtonInput.Text
        Catch ex As Exception

        End Try
    
    End Sub

    Private Sub Operator_Button(sender As Object, e As EventArgs) Handles PlusButton.Click, TimesButton.Click, MinusButton.Click, DevideButton.Click, SquareRootButton.Click, OnmeTimesXButton.Click, ModuloButton.Click, PlusMinusButton.Click
        Try 
            userOperationButtonInput = sender
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
        
             ElseIf currentOperation = "sqrt" then
                value = Math.Sqrt(CalcInputLabel.Text)
                CalcInputLabel.Text = value 

             ElseIf currentOperation = "%" then
                CalcInputLabel.Text = value Mod double.Parse(CalcInputLabel.Text)

             ElseIf currentOperation = "1/x" then
                CalcInputLabel.Text = value Mod double.Parse(CalcInputLabel.Text)

             ElseIf currentOperation = "+/-" then
                If CalcInputLabel.Text < -0 then
                    'value = CalcInputLabel.Text.
                Else
                    value = CalcInputLabel.Text.TrimStart("-")
                    CalcInputLabel.Text = value
                End if

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

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Try
            if CalcInputLabel.Text.Length <> 0 then
                CalcInputLabel.Text = CalcInputLabel.Text.Substring(0, CalcInputLabel.Text.Length -1)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class