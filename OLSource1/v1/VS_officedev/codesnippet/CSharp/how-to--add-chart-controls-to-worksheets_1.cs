            Microsoft.Office.Tools.Excel.Chart employeeData;
            employeeData = this.Controls.AddChart(25, 110, 200, 150, "employees");
            employeeData.ChartType = Excel.XlChartType.xl3DPie;

            // Gets the cells that define the data to be charted.
            Excel.Range chartRange = this.get_Range("A5", "D8");
            employeeData.SetSourceData(chartRange, missing);