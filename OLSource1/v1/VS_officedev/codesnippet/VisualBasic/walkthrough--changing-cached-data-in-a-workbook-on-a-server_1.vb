    Private ProductTableAdapter As New  _
        AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter()

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        If Me.NeedsFill("AdventureWorksLTDataSet") Then
            Me.ProductTableAdapter.Fill(Me.AdventureWorksLTDataSet.Product)
        End If
    End Sub