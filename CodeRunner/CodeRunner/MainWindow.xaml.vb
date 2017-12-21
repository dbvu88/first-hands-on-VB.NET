Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here
        'Output("Hello World")
        Dim input As String = txtInput.Text
        Dim myNumber As Integer = 42
        Dim myDate As Date = DateValue("November 28, 2013")
        Output(input)
        Output(myNumber)
        Output(myDate)

        Dim myByte As Byte = 255
        Try
            myByte += 1
            Output(myByte)
        Catch ex As Exception
            Output(ex.Message)
        End Try

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
