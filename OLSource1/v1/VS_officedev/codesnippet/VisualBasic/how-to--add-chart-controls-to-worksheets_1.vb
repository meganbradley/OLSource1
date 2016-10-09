        Dim employeeData As Microsoft.Office.Tools.Excel.Chart
        employeeData = Me.Controls.AddChart(25, 110, 200, 150, "employees")
        employeeData.ChartType = Excel.XlChartType.xl3DPie

        ' Gets the cells that define the data to be charted.
        Dim chartRange As Excel.Range = Me.Range("A5", "D8")
        employeeData.SetSourceData(chartRange)