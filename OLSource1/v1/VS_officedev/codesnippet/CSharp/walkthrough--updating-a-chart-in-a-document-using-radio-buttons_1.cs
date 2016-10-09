        public event EventHandler SelectionChanged;

        private Microsoft.Office.Interop.Graph.XlChartType selectedType =
            Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered;

        public Microsoft.Office.Interop.Graph.XlChartType Selection
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