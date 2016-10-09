    Private Sub BoldCurrentRow(ByVal ws As Excel.Worksheet)

        ' Keep track of the previously bolded row.
        Static previousRow As Integer = 0

        ' Work with the current active cell.
        Dim currentCell As Excel.Range = Me.Application.ActiveCell

        ' Bold the current row.
        currentCell.EntireRow.Font.Bold = True

        ' If a pass has been done previously, make the old row not bold.
        ' Make sure previousRow is not 0 (otherwise this is your first pass through).
        If previousRow <> 0 Then

            ' Make sure the current row is not the same as the previous row.
            If currentCell.Row <> previousRow Then

                Dim rng As Excel.Range = DirectCast(ws.Rows(previousRow), Excel.Range)
                rng.EntireRow.Font.Bold = False
            End If
        End If

        ' Store the new row number for the next pass.
        previousRow = currentCell.Row
    End Sub