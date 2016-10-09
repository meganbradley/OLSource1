    Private Sub CreateDocumentPropertyTable()
        Dim rng As Word.Range = Me.Range(Start:=0, End:=0)

        ' Insert a title for the table and paragraph marks.
        With rng
            .InsertBefore("Document Statistics")
            .Font.Name = "Verdana"
            .Font.Size = 16
            .InsertParagraphAfter()
            .InsertParagraphAfter()
            .SetRange(rng.End, rng.End)
        End With

        ' Add the table.
        rng.Tables.Add(Range:=Me.Paragraphs.Item(2).Range, NumRows:=3, NumColumns:=2)

        ' Format the table and apply a style.
        With Me.Tables.Item(1)
            .Range.Font.Size = 12
            .Columns.DistributeWidth()
            .Style = "Table Professional"
        End With

        ' Insert document properties into cells.
        With Me.Tables.Item(1)
            .Cell(1, 1).Range.Text = "Document Property"
            .Cell(1, 2).Range.Text = "Value"

            .Cell(2, 1).Range.Text = "Subject"
            .Cell(2, 2).Range.Text = CType(Me.BuiltInDocumentProperties, Office.DocumentProperties) _
                (Word.WdBuiltInProperty.wdPropertySubject).Value.ToString()

            .Cell(3, 1).Range.Text = "Author"
            .Cell(3, 2).Range.Text = CType(Me.BuiltInDocumentProperties, Office.DocumentProperties) _
                (Word.WdBuiltInProperty.wdPropertyAuthor).Value.ToString()
        End With
    End Sub