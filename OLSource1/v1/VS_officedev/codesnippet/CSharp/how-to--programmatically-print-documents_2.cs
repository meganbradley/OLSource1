            object copies = "1"; 
            object pages = "1"; 
            object range = Word.WdPrintOutRange.wdPrintCurrentPage; 
            object items = Word.WdPrintOutItem.wdPrintDocumentContent; 
            object pageType = Word.WdPrintOutPages.wdPrintAllPages; 
            object oTrue = true; 
            object oFalse = false; 

            this.PrintOut(
                ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue, 
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);