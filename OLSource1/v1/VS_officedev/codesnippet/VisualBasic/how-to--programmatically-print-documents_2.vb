        Me.PrintOut( _
            Background:=True, _
            Append:=False, _
            Range:=Word.WdPrintOutRange.wdPrintCurrentPage, _
            Item:=Word.WdPrintOutItem.wdPrintDocumentContent, _
            Copies:="1", _
            Pages:="1", _
            PageType:=Word.WdPrintOutPages.wdPrintAllPages, _
            PrintToFile:=False, _
            Collate:=True, _
            ManualDuplexPrint:=False)