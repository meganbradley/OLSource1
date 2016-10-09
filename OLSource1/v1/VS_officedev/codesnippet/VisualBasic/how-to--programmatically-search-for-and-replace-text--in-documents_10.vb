    Private Sub RangeFind()
        Dim findText As Object = "find me"

        Dim rng As Word.Range = Me.Application.ActiveDocument.Paragraphs(2).Range

        rng.Find.ClearFormatting()

        If rng.Find.Execute(findText) Then
            MessageBox.Show("Text found.")
        Else
            MessageBox.Show("Text not found.")
        End If

        rng.Select()
    End Sub