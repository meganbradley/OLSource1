    Private Sub Application_DocumentBeforeSave(ByVal Doc As Word.Document, ByRef SaveAsUI As Boolean, _
        ByRef Cancel As Boolean) Handles Application.DocumentBeforeSave
        Doc.Paragraphs(1).Range.InsertParagraphBefore()
        Doc.Paragraphs(1).Range.Text = "This text was added by using code."
    End Sub