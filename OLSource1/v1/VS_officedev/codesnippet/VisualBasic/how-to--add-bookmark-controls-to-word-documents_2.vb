        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)


        Dim firstParagraph As Bookmark = extendedDocument.Controls.AddBookmark( _
            extendedDocument.Paragraphs(1).Range, "FirstParagraph")