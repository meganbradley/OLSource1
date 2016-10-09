            // Define a range of 7 characters.
            Word.Range rng = this.Application.ActiveDocument.Range(0, 7);

            // Move the start position 7 characters.
            rng.MoveStart(Word.WdUnits.wdCharacter, 7);

            // Move the end position 7 characters.
            rng.MoveEnd(Word.WdUnits.wdCharacter, 7);