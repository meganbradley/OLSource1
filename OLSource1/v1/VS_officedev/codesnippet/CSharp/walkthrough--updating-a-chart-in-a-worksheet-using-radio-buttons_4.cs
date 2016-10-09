        private void columnChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }