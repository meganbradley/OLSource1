        For Each section As Word.Section In Me.Application.ActiveDocument.Sections
            Dim footerRange As Word.Range = section.Footers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
            footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed
            footerRange.Font.Size = 20
            footerRange.Text = "Confidential"
        Next