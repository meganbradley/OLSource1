        With Me.Application.ActiveDocument.Tables.Item(1)
            .Cell(1, 1).Range.Text = "Document Property"
            .Cell(1, 2).Range.Text = "Value"

            .Cell(2, 1).Range.Text = "Subject"
            .Cell(2, 2).Range.Text = CType( _
                Me.Application.ActiveDocument.BuiltInDocumentProperties,  _
                Office.DocumentProperties) _
                (Word.WdBuiltInProperty.wdPropertySubject).Value.ToString()

            .Cell(3, 1).Range.Text = "Author"
            .Cell(3, 2).Range.Text = CType( _
                Me.Application.ActiveDocument.BuiltInDocumentProperties,  _
                Office.DocumentProperties) _
                (Word.WdBuiltInProperty.wdPropertyAuthor).Value.ToString()
        End With