            foreach (Word.Section wordSection in this.Application.ActiveDocument.Sections)
            {
                Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 20;
                footerRange.Text = "Confidential";
            }