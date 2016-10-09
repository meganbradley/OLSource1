    Private Sub AutoFill()
        Dim rng As Excel.Range = Me.Application.Range("B1")
        rng.AutoFill(Me.Application.Range("B1:B5"), Excel.XlAutoFillType.xlFillWeekdays)

        rng = Me.Application.Range("C1")
        rng.AutoFill(Me.Application.Range("C1:C5"), Excel.XlAutoFillType.xlFillMonths)

        rng = Me.Application.Range("D1:D2")
        rng.AutoFill(Me.Application.Range("D1:D5"), Excel.XlAutoFillType.xlFillSeries)
    End Sub