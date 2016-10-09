        private void FindLoop() 
        { 
            int intFound = 0; 
            Word.Range rng = this.Content; 

            rng.Find.ClearFormatting(); 
            rng.Find.Forward = true; 
            rng.Find.Text = "find me"; 

            rng.Find.Execute(
                ref missing, ref missing, ref missing, ref missing, ref missing, 
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

            while (rng.Find.Found) 
            { 
                intFound++;
                rng.Find.Execute(
                    ref missing, ref missing, ref missing, ref missing, ref missing, 
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);
            } 

            MessageBox.Show("Strings found: " + intFound.ToString()); 
        }