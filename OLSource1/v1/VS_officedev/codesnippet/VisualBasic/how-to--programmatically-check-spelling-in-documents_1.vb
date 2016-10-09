        Dim result As String = "Spelled incorrectly."

        If Me.Application.CheckSpelling(Me.Range.Text) = True Then
            result = "Spelled correctly."
        End If

        MessageBox.Show(result)