            foreach (Word.Section section in this.Application.ActiveDocument.Sections)
            {
                Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            }