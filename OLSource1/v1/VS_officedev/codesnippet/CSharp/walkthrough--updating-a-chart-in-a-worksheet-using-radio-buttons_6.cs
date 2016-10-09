        public ChartOptions()
        {
            InitializeComponent();

            areaBlockChart.CheckedChanged += new EventHandler(areaBlockChart_CheckedChanged);
            barChart.CheckedChanged += new EventHandler(barChart_CheckedChanged);
            columnChart.CheckedChanged += new EventHandler(columnChart_CheckedChanged);
            lineChart.CheckedChanged += new EventHandler(lineChart_CheckedChanged);
        }