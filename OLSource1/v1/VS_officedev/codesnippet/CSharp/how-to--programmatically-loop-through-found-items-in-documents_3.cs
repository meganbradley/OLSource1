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