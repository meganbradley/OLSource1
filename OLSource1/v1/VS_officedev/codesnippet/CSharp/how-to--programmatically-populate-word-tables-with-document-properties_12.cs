        private void CreateDocumentPropertyTable()
        {
            object start = 0, end = 0;
            Word.Document document = this.Application.ActiveDocument;
            Word.Range rng = document.Range(ref start, ref end);

            // Insert a title for the table and paragraph marks. 
            rng.InsertBefore("Document Statistics");
            rng.Font.Name = "Verdana";
            rng.Font.Size = 16;
            rng.InsertParagraphAfter();
            rng.InsertParagraphAfter();
            rng.SetRange(rng.End, rng.End);

            // Add the table.
            rng.Tables.Add(document.Paragraphs[2].Range, 3, 2, ref missing, ref missing);

            // Format the table and apply a style. 
            Word.Table tbl = document.Tables[1];
            tbl.Range.Font.Size = 12;
            tbl.Columns.DistributeWidth();

            object styleName = "Table Professional";
            tbl.set_Style(ref styleName);

            // Insert document properties into cells. 
            tbl.Cell(1, 1).Range.Text = "Document Property";
            tbl.Cell(1, 2).Range.Text = "Value";

            tbl.Cell(2, 1).Range.Text = "Subject";
            tbl.Cell(2, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertySubject].Value.ToString();

            tbl.Cell(3, 1).Range.Text = "Author";
            tbl.Cell(3, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertyAuthor].Value.ToString();
        }