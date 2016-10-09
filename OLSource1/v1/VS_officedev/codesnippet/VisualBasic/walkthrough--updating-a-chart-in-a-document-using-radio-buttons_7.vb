    Private Sub ChartOptions1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ChartOptions1.SelectionChanged

        Try
            Dim shape As Word.Shape = Me.Shapes.Item(1)

            ' Activate the shape.
            shape.OLEFormat.Activate()

            Dim dataChart As Graph.Chart = CType(shape.OLEFormat.Object, Graph.Chart)
            dataChart.ChartType = Me.ChartOptions1.Selection

            ' Deactivate the shape.
            Me.ChartOptions1.Select()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub