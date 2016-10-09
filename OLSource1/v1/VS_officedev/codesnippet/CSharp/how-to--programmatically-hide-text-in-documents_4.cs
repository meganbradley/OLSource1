            HideText(bookmark1.Range);

            this.Application.ActiveDocument.PrintOut(true, false, Word.WdPrintOutRange.wdPrintAllDocument,
                Item:Word.WdPrintOutItem.wdPrintDocumentContent, Copies:"1", Pages:"", 
                PageType:Word.WdPrintOutPages.wdPrintAllPages, PrintToFile:false, Collate:true, 
                ManualDuplexPrint:false);

            UnhideText(bookmark1.Range);