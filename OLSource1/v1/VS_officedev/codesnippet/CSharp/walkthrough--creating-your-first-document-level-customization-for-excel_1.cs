        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Microsoft.Office.Tools.Excel.NamedRange nr =
                this.Controls.AddNamedRange(this.Range["A2"], "NamedRange1");
            nr.Value2 = "This text was added by using code";
        }