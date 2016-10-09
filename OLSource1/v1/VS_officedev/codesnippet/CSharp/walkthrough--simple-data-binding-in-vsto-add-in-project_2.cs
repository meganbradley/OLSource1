            this.adventureWorksDataSet = new AdventureWorksLTDataSet();
            this.customerTableAdapter = new AdventureWorksLTDataSetTableAdapters.CustomerTableAdapter();
            this.customerTableAdapter.Fill(this.adventureWorksDataSet.Customer);
            this.customerBindingSource = new System.Windows.Forms.BindingSource();