        private void ChartOptions1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataChart.ChartType = this.ChartOptions1.Selection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }