    Dim richTextControl2 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        richTextControl2 = Me.Controls.AddRichTextContentControl(Me.Paragraphs(1).Range, _
            "richTextControl2")
        richTextControl2.PlaceholderText = "Enter your first name"
    End Sub