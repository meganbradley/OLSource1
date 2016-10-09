            ElseIf .Type = Word.WdSelectionType.wdSelectionNormal Then
                ' Move to start of selection.
                If Application.Options.ReplaceSelection Then
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                End If
                .TypeText("Inserting before a text block. ")
                .TypeParagraph()