    Dim richTextControl1 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtSelection()
        Dim currentDocument As Word.Document = Me.Application.ActiveDocument
        currentDocument.Paragraphs(1).Range.InsertParagraphBefore()
        currentDocument.Paragraphs(1).Range.Select()

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)


        richTextControl1 = extendedDocument.Controls.AddRichTextContentControl("richTextControl1")
        richTextControl1.PlaceholderText = "Enter your first name"
    End Sub