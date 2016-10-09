    Dim richTextControl2 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtRange()
        Dim currentDocument As Word.Document = Me.Application.ActiveDocument
        currentDocument.Paragraphs(1).Range.InsertParagraphBefore()

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)

        richTextControl2 = extendedDocument.Controls.AddRichTextContentControl( _
            extendedDocument.Paragraphs(1).Range, "richTextControl2")
        richTextControl2.PlaceholderText = "Enter your first name"
    End Sub