        Dim rng As Word.Range = Me.Range(Start:=0, End:=7)

        ' Reset the existing Range.
        rng.SetRange(Start:=Me.Sentences(2).Start, End:=Me.Sentences(5).End)
        rng.Select()