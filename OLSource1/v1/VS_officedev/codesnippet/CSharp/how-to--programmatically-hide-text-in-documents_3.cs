            HideText(bookmark1.Range);

            object oTrue = true;
            object oFalse = false;
            object range = Word.WdPrintOutRange.wdPrintAllDocument;
            object items = Word.WdPrintOutItem.wdPrintDocumentContent;
            object copies = "1";
            object pages = "";
            object pageType = Word.WdPrintOutPages.wdPrintAllPages;

            this.PrintOut(
                ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);

            UnhideText(bookmark1.Range);