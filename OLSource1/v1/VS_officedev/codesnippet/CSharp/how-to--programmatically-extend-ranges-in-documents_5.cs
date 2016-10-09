            // Define a range of 7 characters.
            object start = 0;
            object end = 7;
            Word.Range rng = this.Range(ref start, ref end);

            // Move the start position 7 characters.
            rng.MoveStart(Word.WdUnits.wdCharacter, 7);

            // Move the end position 7 characters.
            rng.MoveEnd(Word.WdUnits.wdCharacter, 7);