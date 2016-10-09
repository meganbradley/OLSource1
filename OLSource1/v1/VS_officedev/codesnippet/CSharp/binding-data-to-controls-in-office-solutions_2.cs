        private void ListObject_DataSourceAndMember()
        {
            // Create a DataSet and two DataTables.
            DataSet ordersDataSet = new DataSet("ordersDataSet");
            DataTable tableCustomers = new DataTable("Customers");
            DataTable tableProducts = new DataTable("Products");
            ordersDataSet.Tables.Add(tableCustomers);
            ordersDataSet.Tables.Add(tableProducts);

            // Add a data to the Customers DataTable.
            tableCustomers.Columns.Add(new DataColumn("LastName"));
            tableCustomers.Columns.Add(new DataColumn("FirstName"));
            DataRow dr = tableCustomers.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            tableCustomers.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "Customers");

            // Bind the list object to the Customers table.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.DataSource = ordersDataSet;
            list1.DataMember = "Customers";
        }