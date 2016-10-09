            foreach (object targetControl in this.Controls)
            {
                Microsoft.Office.Tools.Word.Bookmark bookMark =
                    targetControl as Microsoft.Office.Tools.Word.Bookmark;

                if (bookMark != null)
                {
                    // Do some work with the bookmark here.
                }
            }