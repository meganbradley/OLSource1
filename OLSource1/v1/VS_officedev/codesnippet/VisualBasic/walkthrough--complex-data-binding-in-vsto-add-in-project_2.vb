        Me.addressTableAdapter = New AdventureWorksLTDataSetTableAdapters.AddressTableAdapter()
        Me.adventureWorksDataSet = New AdventureWorksLTDataSet()
        Me.addressTableAdapter.Fill(Me.adventureWorksDataSet.Address)
        Me.addressBindingSource = New System.Windows.Forms.BindingSource()