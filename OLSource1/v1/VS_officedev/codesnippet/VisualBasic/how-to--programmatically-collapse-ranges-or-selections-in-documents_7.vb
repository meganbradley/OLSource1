        Dim rng As Word.Range = Me.Paragraphs(1).Range

        rng.Collapse(Word.WdCollapseDirection.wdCollapseStart)

        rng.Text = " New Text "
        rng.Select()