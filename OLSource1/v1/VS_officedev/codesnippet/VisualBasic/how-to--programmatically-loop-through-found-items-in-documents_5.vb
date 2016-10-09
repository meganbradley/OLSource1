    Private Sub FindLoop()
        Dim intFound As Integer = 0
        Dim rng As Word.Range = Me.Content

        rng.Find.ClearFormatting()
        rng.Find.Forward = True
        rng.Find.Text = "find me"

        rng.Find.Execute()

        Do While rng.Find.Found = True
            intFound += 1
            rng.Find.Execute()
        Loop

        MessageBox.Show("Strings found: " & intFound.ToString())
    End Sub