            Word.Range rng = this.Application.ActiveDocument.Range(0, 7);

            // Reset the existing Range. 
            rng.SetRange(this.Application.ActiveDocument.Sentences[2].Start,
                this.Application.ActiveDocument.Sentences[5].End);
            rng.Select();