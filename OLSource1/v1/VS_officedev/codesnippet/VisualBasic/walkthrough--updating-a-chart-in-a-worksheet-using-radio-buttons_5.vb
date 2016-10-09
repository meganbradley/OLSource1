    Private Sub lineChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles lineChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Excel.XlChartType.xlLineMarkers
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub