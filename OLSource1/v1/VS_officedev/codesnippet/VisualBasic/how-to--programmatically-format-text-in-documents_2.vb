    Private Sub RangeFormat()

        ' Set the Range to the first paragraph.
        Dim document As Word.Document = Me.Application.ActiveDocument
        Dim rng As Word.Range = document.Paragraphs(1).Range

        ' Change the formatting. To change the font size for a right-to-left language, 
        ' such as Arabic or Hebrew, use the Font.SizeBi property instead of Font.Size.
        rng.Font.Size = 14
        rng.Font.Name = "Arial"
        rng.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

        rng.Select()
        MessageBox.Show("Formatted Range")

        ' Undo the three previous actions.
        document.Undo(Times:=3)

        rng.Select()
        MessageBox.Show("Undo 3 actions")

        ' Apply the Normal Indent style.
        rng.Style = "Normal Indent"

        rng.Select()
        MessageBox.Show("Normal Indent style applied")

        ' Undo a single action.
        document.Undo()

        rng.Select()
        MessageBox.Show("Undo 1 action")
    End Sub