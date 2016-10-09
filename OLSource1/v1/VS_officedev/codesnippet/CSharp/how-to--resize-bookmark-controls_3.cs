            Microsoft.Office.Tools.Word.Document vstoDocument =
                Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            vstoDocument.ActiveWindow.View.ShowBookmarks = true;
            vstoDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Word.Range firstParagraph = vstoDocument.Paragraphs[1].Range;
            firstParagraph.Text = "123456789abcdefghijklmnopqrstuvwxyz";

            Microsoft.Office.Tools.Word.Bookmark sampleBookmark =
                vstoDocument.Controls.AddBookmark(firstParagraph, "bookmark1");
            sampleBookmark.Start = sampleBookmark.Start + 5;
            sampleBookmark.End = sampleBookmark.End - 5;