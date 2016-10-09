        internal void ReplaceRestoreSelection() 
        { 
            Word.Range start = Application.Selection.Range; 
            Word.Range searchArea = Application.ActiveDocument.Range(ref missing, ref missing); 

            searchArea.Find.ClearFormatting(); 
            searchArea.Find.Text = "find me"; 

            searchArea.Find.Replacement.ClearFormatting(); 
            searchArea.Find.Replacement.Text = "Found"; 

            object replaceAll = Word.WdReplace.wdReplaceAll; 

            searchArea.Find.Execute(
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            start.Select(); 
        }