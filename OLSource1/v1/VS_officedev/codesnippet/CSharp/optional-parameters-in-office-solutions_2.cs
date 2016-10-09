            Word.Range documentRange = this.Application.ActiveDocument.Content;
            documentRange.Find.ClearFormatting();
            documentRange.Find.Execute(FindText: "blue", ReplaceWith: "red", Replace: Word.WdReplace.wdReplaceAll);            