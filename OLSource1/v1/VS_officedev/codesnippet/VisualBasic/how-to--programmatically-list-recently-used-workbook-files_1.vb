        Dim rng As Excel.Range = Me.Application.Range("A1")

        Dim i As Integer
        For i = 1 To Me.Application.RecentFiles.Count
            rng.Offset(i - 1, 0).Value2 = Me.Application.RecentFiles(i).Name
        Next