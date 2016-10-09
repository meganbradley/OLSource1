        If Me.Sentences.Count >= 2 Then

            Dim startLocation As Object = Me.Sentences(2).Start
            Dim endLocation As Object = Me.Sentences(2).End

            ' Supply a Start and End value for the Range.
            rng = Me.Range(Start:=startLocation, End:=endLocation)

            ' Select the Range
            rng.Select()
        End If