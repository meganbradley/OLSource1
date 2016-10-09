    Private Sub columnChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles columnChart.CheckedChanged

        If (CType(sender, RadioButton).Checked) Then

            Me.selectedType = Microsoft.Office.Interop.Graph.XlChartType.xlColumnClustered
            RaiseEvent SelectionChanged(Me, EventArgs.Empty)
        End If
    End Sub