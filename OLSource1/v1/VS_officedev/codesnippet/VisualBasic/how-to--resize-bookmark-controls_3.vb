
        Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        vstoDocument.ActiveWindow.View.ShowBookmarks = True
        vstoDocument.Paragraphs(1).Range.InsertParagraphBefore()

        Dim firstParagraph As Word.Range = vstoDocument.Paragraphs(1).Range
        firstParagraph.Text = "123456789abcdefghijklmnopqrstuvwxyz"

        Dim sampleBookmark As Microsoft.Office.Tools.Word.Bookmark = _
            vstoDocument.Controls.AddBookmark(firstParagraph, "bookmark1")
        sampleBookmark.Start = sampleBookmark.Start + 5
        sampleBookmark.End = sampleBookmark.End - 5