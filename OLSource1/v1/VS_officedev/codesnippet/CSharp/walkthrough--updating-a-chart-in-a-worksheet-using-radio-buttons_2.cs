        private void areaBlockChart_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlAreaStacked;
                if (this.SelectionChanged != null)
                {
                    this.SelectionChanged(this, EventArgs.Empty);
                }
            }
        }