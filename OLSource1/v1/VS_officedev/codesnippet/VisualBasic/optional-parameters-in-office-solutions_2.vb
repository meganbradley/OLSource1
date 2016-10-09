        With Me.Application.ActiveDocument.Content
            .Find.ClearFormatting()
            .Find.Execute(FindText:="blue", ReplaceWith:="red", Replace:=Word.WdReplace.wdReplaceAll)
        End With