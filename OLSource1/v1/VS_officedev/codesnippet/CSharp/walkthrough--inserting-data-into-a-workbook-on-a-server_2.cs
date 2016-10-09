            AdventureWorksDataSet.AdventureWorksLTDataSet productDataSet = 
                new AdventureWorksDataSet.AdventureWorksLTDataSet();
            AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter productTableAdapter =
                new AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter();

            string workbookPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) +
                @"\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx";
            ServerDocument serverDocument1 = null;