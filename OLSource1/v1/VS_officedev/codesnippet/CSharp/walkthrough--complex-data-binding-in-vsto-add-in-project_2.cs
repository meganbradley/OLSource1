            this.addressTableAdapter = new AdventureWorksLTDataSetTableAdapters.AddressTableAdapter();
            this.adventureWorksDataSet = new AdventureWorksLTDataSet();
            this.addressTableAdapter.Fill(this.adventureWorksDataSet.Address);
            this.addressBindingSource = new System.Windows.Forms.BindingSource();