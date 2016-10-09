    Private Sub ChartOptions1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ChartOptions1.SelectionChanged

        Try
            dataChart.ChartType = Me.ChartOptions1.Selection
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub