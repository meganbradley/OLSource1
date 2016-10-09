    Shared Sub SetHeadings(ByVal tblCell As Word.Cell, ByVal text As String)

        With tblCell.Range
            .Text = text
            .Font.Bold = True
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        End With
    End Sub