        private void CustomerRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            customerTable = nwDataSet.Customers;
            customerTableAdapter.Fill(customerTable);

            var customerQuery = from customers in customerTable.AsEnumerable().Take(20)
                                select new
                                {
                                    CustomerID = customers.Field<string>("Customer ID"),
                                    CustomerName = customers.Field<string>("Contact Name")
                                };


            // Execute the query.
            foreach (var item in customerQuery)
            {
                this.comboBox1.Items.Add(CreateRibbonDropDownItem());
                this.comboBox1.Items.Last().Label =
                item.CustomerName + "|" + item.CustomerID.ToString();
            }
            this.comboBox1.Text = this.comboBox1.Items.First().Label;
            PopulateSalesOrderInfo();
        }