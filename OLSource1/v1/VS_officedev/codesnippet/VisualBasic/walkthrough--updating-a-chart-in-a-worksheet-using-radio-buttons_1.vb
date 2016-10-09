    Public Event SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private selectedType As Microsoft.Office.Interop.Excel.XlChartType = _
        Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered

    Public Property Selection() As Microsoft.Office.Interop.Excel.XlChartType
        Get
            Return Me.selectedType
        End Get
        Set(ByVal value As Microsoft.Office.Interop.Excel.XlChartType)
            Me.selectedType = value
        End Set
    End Property