        With Application.Selection.Find
            .ClearFormatting()
            .Execute(FindText:="find me", Forward:=True, Wrap:=Word.WdFindWrap.wdFindContinue)
        End With