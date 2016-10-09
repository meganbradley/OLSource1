            tbl.Cell(1, 1).Range.Text = "Document Property";
            tbl.Cell(1, 2).Range.Text = "Value";

            tbl.Cell(2, 1).Range.Text = "Subject";
            tbl.Cell(2, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertySubject].Value.ToString();

            tbl.Cell(3, 1).Range.Text = "Author";
            tbl.Cell(3, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertyAuthor].Value.ToString();