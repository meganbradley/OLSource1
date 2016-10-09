            Word.Document document = this.Application.ActiveDocument;

            if (document.Sentences.Count >= 2)
            {
                object startLocation = document.Sentences[2].Start;
                object endLocation = document.Sentences[2].End;

                // Supply a Start and End value for the Range. 
                rng = document.Range(ref startLocation, ref endLocation);

                // Select the Range.
                rng.Select();
            }