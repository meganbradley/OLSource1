    Private Sub AddChart()
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim cells As Excel.Range = worksheet.Range("A5", "D8")
        Dim chart As Chart = worksheet.Controls.AddChart(cells, "employees")
        chart.ChartType = Excel.XlChartType.xl3DPie
        chart.SetSourceData(cells, Type.Missing)

    End Sub