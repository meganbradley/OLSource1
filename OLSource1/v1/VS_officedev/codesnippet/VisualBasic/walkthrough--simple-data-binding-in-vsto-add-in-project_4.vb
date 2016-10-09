        extendedDocument.Paragraphs(1).Range.InsertParagraphBefore()
        extendedDocument.Paragraphs(1).Range.InsertParagraphBefore()
        extendedDocument.Paragraphs(1).Range.Text = "The companies listed in the AdventureWorksLT database:   "
        extendedDocument.Paragraphs(2).Range.Text = "  "

        Dim range1 As Word.Range = extendedDocument.Paragraphs(2).Range.Characters.First
        Dim range2 As Word.Range = extendedDocument.Paragraphs(2).Range.Characters.Last
        Dim range3 As Word.Range = extendedDocument.Paragraphs(1).Range.Characters.Last