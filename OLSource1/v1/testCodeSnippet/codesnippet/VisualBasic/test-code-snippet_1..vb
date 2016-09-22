        Try
            ' Do something that may cause an exception.
            Throw New ApplicationException("An error has occured.")
        Catch ex As ApplicationException
            Dim str As String = "The action failed."
            Dim exTop As ApplicationException = New ApplicationException(str, ex)
            exTop.Source = Me.Text

            ' Show a message box if the global variable is true.
            If alwaysShow Then
                Dim box As ExceptionMessageBox = New ExceptionMessageBox(exTop)
                box.ShowCheckBox = True
                box.IsCheckBoxChecked = True
                box.CheckBoxText = "Always show this message"
                box.Show(Me)

                ' Set the global variable.
                alwaysShow = box.IsCheckBoxChecked
            End If
        End Try
