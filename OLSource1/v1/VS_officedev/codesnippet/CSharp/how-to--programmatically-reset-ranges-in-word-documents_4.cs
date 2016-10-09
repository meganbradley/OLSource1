            object start = 0; 
            object end = 7; 
            Word.Range rng = this.Range(ref start,ref end); 

            // Reset the existing Range. 
            rng.SetRange(this.Sentences[2].Start, this.Sentences[5].End); 
            rng.Select();