    Private Sub barChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles barChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlBarClustered
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub