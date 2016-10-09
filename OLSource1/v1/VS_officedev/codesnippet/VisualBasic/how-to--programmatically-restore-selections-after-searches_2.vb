        searchArea.Find.ClearFormatting()
        searchArea.Find.Text = "find me"

        searchArea.Find.Replacement.ClearFormatting()
        searchArea.Find.Replacement.Text = "Found"

        searchArea.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)