        With currentSelection

            ' Test to see if selection is an insertion point.
            If .Type = Word.WdSelectionType.wdSelectionIP Then
                .TypeText("Inserting at insertion point. ")
                .TypeParagraph()