        Dim productDataSet As New AdventureWorksDataSet.AdventureWorksLTDataSet()
        Dim productTableAdapter As _
            New AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter()

        Dim workbookPath As String = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.MyDocuments) & _
            "\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx"
        Dim serverDocument1 As ServerDocument = Nothing