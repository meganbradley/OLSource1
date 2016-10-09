    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click

        Dim tbl As System.Data.DataTable = NorthwindDataSet.Products
        Dim rows() As System.Data.DataRow

        ' Check if a product is selected.
        If Not Me.ProductNameListBox.SelectedIndex < 0 Then

            Dim product As String = Me.ProductNameListBox.SelectedItem.Row.Item("ProductName")
            Dim company As String = Me.CompanyNameComboBox.Text

            ' Return the data row from the selected Product in the list box.
            rows = tbl.Select("[ProductName] = '" & product.Replace("'", "''") & "'")

            AddData(rows(0), company)

        Else
            MessageBox.Show("Please select a product.", "Actions Pane", MessageBoxButtons.OK)
        End If
    End Sub