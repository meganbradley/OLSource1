        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=7)

        ' Reset the existing Range.
        rng.SetRange(Start:=Me.Application.ActiveDocument.Sentences(2).Start, _
            End:=Me.Application.ActiveDocument.Sentences(5).End)
        rng.Select()