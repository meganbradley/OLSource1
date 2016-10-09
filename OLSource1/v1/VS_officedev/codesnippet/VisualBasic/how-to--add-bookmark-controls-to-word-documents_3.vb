        If Me.Application.ActiveDocument.Bookmarks.Count > 0 Then
            Dim firstBookmark As Word.Bookmark = Me.Application.ActiveDocument.Bookmarks(1)

            Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

            Dim vstoBookmark As Bookmark = extendedDocument.Controls.AddBookmark( _
                firstBookmark, "VSTOBookmark")
        End If