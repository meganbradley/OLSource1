    Public Event SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private selectedType As Microsoft.Office.Interop.Graph.XlChartType = _
        Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered

    Public Property Selection() As Microsoft.Office.Interop.Graph.XlChartType
        Get
            Return Me.selectedType
        End Get
        Set(ByVal value As Microsoft.Office.Interop.Graph.XlChartType)
            Me.selectedType = value
        End Set
    End Property