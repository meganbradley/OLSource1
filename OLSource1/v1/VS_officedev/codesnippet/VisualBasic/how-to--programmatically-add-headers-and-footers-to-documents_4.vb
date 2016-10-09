        For Each section As Word.Section In Me.Application.ActiveDocument.Sections
            Dim headerRange As Word.Range = section.Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
            headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage)
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        Next