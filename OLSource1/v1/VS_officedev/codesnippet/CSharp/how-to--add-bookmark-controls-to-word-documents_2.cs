            Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            Bookmark firstParagraph = extendedDocument.Controls.AddBookmark(
                extendedDocument.Paragraphs[1].Range, "FirstParagraph");