        With Application.Selection.Find
            .ClearFormatting()
            .Forward = True
            .Wrap = Word.WdFindWrap.wdFindContinue
            .Text = "find me"
            .Execute()
        End With