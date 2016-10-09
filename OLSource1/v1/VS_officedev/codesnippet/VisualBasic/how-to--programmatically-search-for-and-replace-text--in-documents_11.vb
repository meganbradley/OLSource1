    Private Sub SearchReplace()
        Dim FindObject As Word.Find = Application.Selection.Find
        With FindObject
            .ClearFormatting()
            .Text = "find me"
            .Replacement.ClearFormatting()
            .Replacement.Text = "Found"
            .Execute(Replace:=Word.WdReplace.wdReplaceAll)
        End With
    End Sub