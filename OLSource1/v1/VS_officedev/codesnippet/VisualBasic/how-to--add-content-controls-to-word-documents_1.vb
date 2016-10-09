    Dim richTextControl1 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        richTextControl1 = Me.Controls.AddRichTextContentControl("richTextControl1")
        richTextControl1.PlaceholderText = "Enter your first name"
    End Sub