
        void bookmark_BeforeRightClick(object sender, ClickEventArgs e)
        {
            int startPosition = 0;

            // If bookmarks overlap, get bookmark closest to cursor.
            for (int i = 1; i <= e.Selection.Bookmarks.Count; i++)
            {
                if (e.Selection.Bookmarks[i].Start > startPosition)
                {
                    startPosition = e.Selection.Bookmarks[i].Start;
                }
            }

            // If closest bookmark is the sender, show shortcut menu options.
            if (((Microsoft.Office.Tools.Word.Bookmark)sender).Start == startPosition)
            {
                selectedBookmark = (Microsoft.Office.Tools.Word.Bookmark)sender;
                
                showBoldButton = true;
                showItalicButton = true;

            }

        }
