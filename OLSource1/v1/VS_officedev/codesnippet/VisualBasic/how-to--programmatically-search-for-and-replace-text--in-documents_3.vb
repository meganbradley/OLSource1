        If Application.Selection.Find.Execute(findText) = True Then
            MessageBox.Show("Text found.")
        Else
            MessageBox.Show("The text could not be located.")
        End If