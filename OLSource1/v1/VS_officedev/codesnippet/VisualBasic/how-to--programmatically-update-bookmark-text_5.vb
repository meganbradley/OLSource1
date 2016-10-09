        Dim rng As Object = bookmark.Range
        Dim bookmarkName As String = bookmark.Name

        bookmark.Range.Text = newText
        Me.Application.ActiveDocument.Bookmarks.Add(Name:=bookmarkName, Range:=rng)
    End Sub