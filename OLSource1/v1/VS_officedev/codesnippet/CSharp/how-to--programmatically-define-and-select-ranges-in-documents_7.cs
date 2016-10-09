            if (this.Sentences.Count >= 2) 
            {
                object startLocation = this.Sentences[2].Start; 
                object endLocation = this.Sentences[2].End; 

                // Supply a Start and End value for the Range. 
                rng = this.Range(ref startLocation, ref endLocation); 

                // Select the Range.
                rng.Select();
            }