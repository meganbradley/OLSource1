        private void comboBox1_TextChanged(object sender,
            RibbonControlEventArgs e)
        {
            PopulateSalesOrderInfo();
            PopulateMailItem(comboBox1.Text);
        }