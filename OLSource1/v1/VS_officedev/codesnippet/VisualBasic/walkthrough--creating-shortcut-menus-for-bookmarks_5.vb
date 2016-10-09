
    Private Sub Bookmark_BeforeRightClick(ByVal sender As Object, ByVal e _
    As Microsoft.Office.Tools.Word.ClickEventArgs) _
    Handles Bookmark1.BeforeRightClick, Bookmark2.BeforeRightClick
        Dim startPosition As Integer = 0
        Dim i As Integer

        ' If bookmarks overlap, get bookmark closest to cursor.
        For i = 1 To e.Selection.Bookmarks.Count
            If e.Selection.Bookmarks(i).Start > startPosition Then
                startPosition = e.Selection.Bookmarks(i).Start
            End If
        Next

        ' If closest bookmark is the sender, show the shortcut menu options.
        If DirectCast(sender, Microsoft.Office.Tools.Word.Bookmark).Start = _
            startPosition Then
            selectedBookmark = DirectCast(sender, Microsoft.Office.Tools.Word.Bookmark)

            ShowBoldButton = True
            ShowItalicButton = True

        End If

    End Sub