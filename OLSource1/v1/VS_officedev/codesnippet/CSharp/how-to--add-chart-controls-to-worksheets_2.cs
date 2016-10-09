        private void AddChart()
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet);


            Excel.Range cells = worksheet.Range["A5", "D8"];
            Chart chart = worksheet.Controls.AddChart(cells, "employees");
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xl3DPie;
            chart.SetSourceData(cells);
        }       