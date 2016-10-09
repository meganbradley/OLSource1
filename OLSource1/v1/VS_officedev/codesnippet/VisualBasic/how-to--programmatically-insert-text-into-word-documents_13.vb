    Friend Sub SelectionInsertText()
        Dim currentSelection As Word.Selection = Application.Selection

        ' Store the user's current Overtype selection
        Dim userOvertype As Boolean = Application.Options.Overtype

        ' Make sure Overtype is turned off.
        If Application.Options.Overtype Then
            Application.Options.Overtype = False
        End If

        With currentSelection

            ' Test to see if selection is an insertion point.
            If .Type = Word.WdSelectionType.wdSelectionIP Then
                .TypeText("Inserting at insertion point. ")
                .TypeParagraph()

            ElseIf .Type = Word.WdSelectionType.wdSelectionNormal Then
                ' Move to start of selection.
                If Application.Options.ReplaceSelection Then
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                End If
                .TypeText("Inserting before a text block. ")
                .TypeParagraph()

            Else
                ' Do nothing.
            End If
        End With

        ' Restore the user's Overtype selection
        Application.Options.Overtype = userOvertype
    End Sub