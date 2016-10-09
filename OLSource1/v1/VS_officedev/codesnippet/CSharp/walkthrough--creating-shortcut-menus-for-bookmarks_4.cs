        public void ButtonClick(Office.IRibbonControl control)
        {
            if (control.Id == "BoldButton")
            {
                if (Globals.ThisDocument.selectedBookmark.Bold == 
                    Globals.ThisDocument.WordTrue)
                {
                    Globals.ThisDocument.selectedBookmark.Bold = 
                        Globals.ThisDocument.WordFalse;
                }
                else
                {
                    Globals.ThisDocument.selectedBookmark.Bold = 
                        Globals.ThisDocument.WordTrue;
                }
            }
            else if (control.Id == "ItalicButton")
            {
                if (Globals.ThisDocument.selectedBookmark.Italic == 
                    Globals.ThisDocument.WordTrue)
                {
                    Globals.ThisDocument.selectedBookmark.Italic = 
                        Globals.ThisDocument.WordFalse;
                }
                else
                {
                    Globals.ThisDocument.selectedBookmark.Italic = 
                        Globals.ThisDocument.WordTrue;
                }
            }

        }