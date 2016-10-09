    Private Sub ComboBox1_TextChanged(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles ComboBox1.TextChanged
        PopulateSalesOrderInfo()
        PopulateMailItem(ComboBox1.Text)
    End Sub