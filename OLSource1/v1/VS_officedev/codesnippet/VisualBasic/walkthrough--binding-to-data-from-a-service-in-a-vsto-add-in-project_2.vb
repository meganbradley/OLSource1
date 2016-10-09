    Private Sub AddRichTextControlAtRange()

        Dim currentDocument As Word.Document = Me.Application.ActiveDocument
        currentDocument.Paragraphs(1).Range.InsertParagraphBefore()


        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)


        richTextContentControl = extendedDocument.Controls.AddRichTextContentControl _
            (currentDocument.Paragraphs(1).Range, "richTextControl2")
        richTextContentControl.PlaceholderText = _
            "Click here to download MSDN Library information about content controls."
    End Sub