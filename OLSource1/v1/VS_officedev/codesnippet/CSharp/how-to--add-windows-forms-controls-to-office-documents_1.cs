        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Microsoft.Office.Tools.Excel.Controls.Button salesButton;
            salesButton = this.Controls.AddButton(this.get_Range("C5"), "salesButton");
            salesButton.Text = "Calculate Total Sales";
        }