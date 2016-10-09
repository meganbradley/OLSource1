        private void ActionsControl_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Globals.Sheet1.suppliersBindingSource;
            this.comboBox1.DisplayMember = "CompanyName";
        }