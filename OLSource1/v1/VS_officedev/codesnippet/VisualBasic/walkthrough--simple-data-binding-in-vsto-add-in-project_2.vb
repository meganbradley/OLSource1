        Me.adventureWorksDataSet = New AdventureWorksLTDataSet()
        Me.customerTableAdapter = New AdventureWorksLTDataSetTableAdapters.CustomerTableAdapter()
        Me.customerTableAdapter.Fill(Me.adventureWorksDataSet.Customer)
        Me.customerBindingSource = New System.Windows.Forms.BindingSource()