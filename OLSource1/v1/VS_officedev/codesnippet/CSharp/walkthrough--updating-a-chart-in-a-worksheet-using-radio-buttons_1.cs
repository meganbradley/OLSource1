        public event EventHandler SelectionChanged;

        private Microsoft.Office.Interop.Excel.XlChartType selectedType =
            Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;

        public Microsoft.Office.Interop.Excel.XlChartType Selection
        {
            get
            {
                return this.selectedType;
            }
            set
            {
                this.selectedType = value;
            }
        }