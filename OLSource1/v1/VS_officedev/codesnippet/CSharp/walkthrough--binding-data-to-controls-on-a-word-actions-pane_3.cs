        static void SetHeadings(Microsoft.Office.Interop.Word.Cell tblCell, string text)
        {
            tblCell.Range.Text = text;
            tblCell.Range.Font.Bold = 1;
            tblCell.Range.ParagraphFormat.Alignment = 
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
        }