            Word.Cell cell = this.Tables[1].Cell(1, 1);

            cell.Range.Text = "Name"; 
            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;