        Dim rng As Word.Range = Me.Application.ActiveDocument.Sentences(2)

        Dim startPosition As String = rng.Start.ToString()
        Dim endPosition As String = rng.End.ToString()

        MessageBox.Show("Start: " & startPosition & " End: " & endPosition, "Range Information")