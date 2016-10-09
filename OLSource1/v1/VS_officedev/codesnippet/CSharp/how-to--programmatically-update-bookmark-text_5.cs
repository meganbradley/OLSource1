            object rng = bookmark.Range;
            string bookmarkName = bookmark.Name;

            bookmark.Range.Text = newText;

            Word.Document document = this.Application.ActiveDocument;
            document.Bookmarks.Add(bookmarkName, ref rng);
        }