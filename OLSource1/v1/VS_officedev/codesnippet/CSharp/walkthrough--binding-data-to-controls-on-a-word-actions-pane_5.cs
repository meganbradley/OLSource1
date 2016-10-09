        private void Insert_Click(object sender, System.EventArgs e)
        {
            System.Data.DataTable tbl = northwindDataSet.Products;
            System.Data.DataRow[] rows;

            // Check if a product is selected.
            if (this.productNameListBox.SelectedIndex >= 0)
            {
                System.Data.DataRowView productRow = (System.Data.DataRowView)this.productNameListBox.SelectedItem;

                string product = productRow.Row["ProductName"].ToString();
                string company = this.companyNameComboBox.Text;

                // Return the data row from the selected product.
                rows = tbl.Select("[ProductName] = '" + product.Replace("'", "''") + "'");

                this.AddData(rows[0], company);
            }
            else
            {
                MessageBox.Show("Please select a product.", "Actions Pane", MessageBoxButtons.OK);
            }
        }