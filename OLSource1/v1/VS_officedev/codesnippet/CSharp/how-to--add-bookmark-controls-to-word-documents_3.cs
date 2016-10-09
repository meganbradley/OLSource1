            if (this.Application.ActiveDocument.Bookmarks.Count > 0)
            {
                object index = 1;
                Word.Bookmark firstBookmark = this.Application.ActiveDocument.Bookmarks.get_Item(ref index);


                 Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);

                Bookmark vstoBookmark = extendedDocument.Controls.AddBookmark(
                        firstBookmark, "VSTOBookmark");
            }