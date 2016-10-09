            // Test to see if selection is an insertion point.
            if (currentSelection.Type == Word.WdSelectionType.wdSelectionIP) 
            { 
                currentSelection.TypeText("Inserting at insertion point. ");
                currentSelection.TypeParagraph(); 
            } 