        private void ActionsControl_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
        }