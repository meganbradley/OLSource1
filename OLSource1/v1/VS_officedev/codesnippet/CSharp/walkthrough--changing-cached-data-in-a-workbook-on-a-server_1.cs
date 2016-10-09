        private AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter productTableAdapter =
            new AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter();

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            if (this.NeedsFill("adventureWorksLTDataSet"))
            {
                this.productTableAdapter.Fill(this.adventureWorksLTDataSet.Product);
            }
        }