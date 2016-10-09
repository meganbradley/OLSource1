    Friend Sub ReplaceRestoreSelection()
        Dim start As Word.Range = Application.Selection.Range
        Dim searchArea As Word.Range = Application.ActiveDocument.Range

        searchArea.Find.ClearFormatting()
        searchArea.Find.Text = "find me"

        searchArea.Find.Replacement.ClearFormatting()
        searchArea.Find.Replacement.Text = "Found"

        searchArea.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)

        start.Select()
    End Sub