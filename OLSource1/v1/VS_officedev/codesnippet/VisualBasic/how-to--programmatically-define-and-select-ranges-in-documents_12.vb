        Dim document As Word.Document = Me.Application.ActiveDocument
        If document.Sentences.Count >= 2 Then

            Dim startLocation As Object = document.Sentences(2).Start
            Dim endLocation As Object = document.Sentences(2).End

            ' Supply a Start and End value for the Range.
            rng = document.Range(Start:=startLocation, End:=endLocation)

            ' Select the Range
            rng.Select()
        End If