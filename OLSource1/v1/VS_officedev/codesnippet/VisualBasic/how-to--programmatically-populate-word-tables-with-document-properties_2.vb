        With rng
            .InsertBefore("Document Statistics")
            .Font.Name = "Verdana"
            .Font.Size = 16
            .InsertParagraphAfter()
            .InsertParagraphAfter()
            .SetRange(rng.End, rng.End)
        End With