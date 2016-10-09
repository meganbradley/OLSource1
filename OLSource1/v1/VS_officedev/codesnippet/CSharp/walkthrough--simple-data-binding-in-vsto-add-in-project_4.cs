            extendedDocument.Paragraphs[1].Range.InsertParagraphBefore();
            extendedDocument.Paragraphs[1].Range.InsertParagraphBefore();
            extendedDocument.Paragraphs[1].Range.Text = 
                "The companies listed in the AdventureWorksLT database:   \n";
            extendedDocument.Paragraphs[2].Range.Text = "  "; 

            Word.Range range1 = extendedDocument.Paragraphs[2].Range.Characters.First;
            Word.Range range2 = extendedDocument.Paragraphs[2].Range.Characters.Last;
            Word.Range range3 = extendedDocument.Paragraphs[1].Range.Characters.Last;