            string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyDrawing.vsd";
            this.Application.ActiveDocument.SaveAs(docPath);