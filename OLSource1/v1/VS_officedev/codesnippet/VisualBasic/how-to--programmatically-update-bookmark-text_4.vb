        Dim rng As Word.Range = bookmark.Range
        Dim bookmarkName As String = bookmark.Name

        bookmark.Range.Text = newText

        Me.Bookmarks.Add(Name:=bookmarkName, Range:=rng)
    End Sub