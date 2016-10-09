    Private Sub ListSheets()
        Dim index As Integer = 0

        Dim rng As Excel.Range = Me.Application.Range("A1")

        For Each displayWorksheet As Excel.Worksheet In Me.Application.Worksheets
            rng.Offset(index, 0).Value2 = displayWorksheet.Name
            index += 1
        Next displayWorksheet
    End Sub