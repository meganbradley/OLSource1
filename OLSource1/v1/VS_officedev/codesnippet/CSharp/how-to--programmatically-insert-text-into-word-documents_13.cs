        private void SelectionInsertText() 
        { 
            Word.Selection currentSelection = Application.Selection; 

            // Store the user's current Overtype selection
            bool userOvertype = Application.Options.Overtype;

            // Make sure Overtype is turned off.
            if (Application.Options.Overtype) 
            { 
                Application.Options.Overtype = false; 
            } 

            // Test to see if selection is an insertion point.
            if (currentSelection.Type == Word.WdSelectionType.wdSelectionIP) 
            { 
                currentSelection.TypeText("Inserting at insertion point. ");
                currentSelection.TypeParagraph(); 
            } 
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
                else
                {
                    // Do nothing.
                }

            // Restore the user's Overtype selection
            Application.Options.Overtype = userOvertype;
        }