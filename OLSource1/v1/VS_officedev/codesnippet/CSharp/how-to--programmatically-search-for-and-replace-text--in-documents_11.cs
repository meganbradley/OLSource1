        private void SearchReplace()
        {
            Word.Find findObject = Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = "find me";
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = "Found";

            object replaceAll = Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }