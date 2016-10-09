        Dim targetControl As Object
        For Each targetControl In Me.Controls

            If TypeOf (targetControl) Is Microsoft.Office.Tools.Word.Bookmark Then
                Dim bookMark As Microsoft.Office.Tools.Word.Bookmark = _
                    CType(targetControl, Microsoft.Office.Tools.Word.Bookmark)

                ' Do some work with the book mark here.
            End If
        Next