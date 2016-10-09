            else 
                if (currentSelection.Type == Word.WdSelectionType.wdSelectionNormal)
                { 
                    // Move to start of selection.
                    if (Application.Options.ReplaceSelection)
                    { 
                        object direction = Word.WdCollapseDirection.wdCollapseStart;
                        currentSelection.Collapse(ref direction);
                    }
                    currentSelection.TypeText("Inserting before a text block. ");
                    currentSelection.TypeParagraph();
                }