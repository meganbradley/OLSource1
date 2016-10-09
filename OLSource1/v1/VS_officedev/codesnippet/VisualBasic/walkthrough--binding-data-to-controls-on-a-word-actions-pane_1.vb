    Private Sub ActionsControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load

        Me.SuppliersTableAdapter.Fill(Me.NorthwindDataSet.Suppliers)
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
    End Sub