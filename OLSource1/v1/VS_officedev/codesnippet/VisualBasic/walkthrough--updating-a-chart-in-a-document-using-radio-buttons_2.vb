    Private Sub areaBlockChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles areaBlockChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlAreaStacked
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub