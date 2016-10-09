        private void barChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlBarClustered;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }