        ' Define a range of 7 characters.
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=7)

        ' Move the start position 7 characters.
        rng.MoveStart(Unit:=Word.WdUnits.wdCharacter, Count:=7)

        ' Move the end position 7 characters.
        rng.MoveEnd(Unit:=Word.WdUnits.wdCharacter, Count:=7)