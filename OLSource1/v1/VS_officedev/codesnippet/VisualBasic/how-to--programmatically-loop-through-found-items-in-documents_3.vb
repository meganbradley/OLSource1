        rng.Find.ClearFormatting()
        rng.Find.Forward = True
        rng.Find.Text = "find me"

        rng.Find.Execute()

        Do While rng.Find.Found = True
            intFound += 1
            rng.Find.Execute()
        Loop