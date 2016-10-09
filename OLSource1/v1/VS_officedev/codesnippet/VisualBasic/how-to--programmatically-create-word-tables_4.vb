        Dim tableLocation As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=0)
        Me.Application.ActiveDocument.Tables.Add(Range:=tableLocation, NumRows:=3, NumColumns:=4)