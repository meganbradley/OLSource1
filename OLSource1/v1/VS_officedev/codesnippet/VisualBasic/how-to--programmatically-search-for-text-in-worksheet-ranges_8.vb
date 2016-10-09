    Private Sub DemoFind()
        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing

        Dim Fruits As Excel.Range = Me.Application.Range("A1", "B2")
        ' You should specify all these parameters every time you call this method, 
        ' since they can be overridden in the user interface.
        currentFind = Fruits.Find("apples", , _
            Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart, _
            Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, False)

        While Not currentFind Is Nothing

            ' Keep track of the first range you find.
            If firstFind Is Nothing Then
                firstFind = currentFind

            ' If you didn't move to a new range, you are done.
            ElseIf currentFind.Address = firstFind.Address Then
                Exit While
            End If

            With currentFind.Font
                .Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
                .Bold = True
            End With

            currentFind = Fruits.FindNext(currentFind)
        End While
    End Sub