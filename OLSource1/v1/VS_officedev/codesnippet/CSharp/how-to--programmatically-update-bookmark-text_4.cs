            object rng = bookmark.Range;
            string bookmarkName = bookmark.Name;
        
            bookmark.Range.Text = newText;

            this.Bookmarks.Add(bookmarkName, ref rng); 
        }