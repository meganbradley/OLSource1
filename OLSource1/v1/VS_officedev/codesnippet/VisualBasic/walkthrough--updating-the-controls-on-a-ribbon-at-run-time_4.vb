    Private Sub CustomerRibbon_Load(ByVal sender As System.Object, _
   ByVal e As Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs) _
       Handles MyBase.Load

        customerTable = nwDataSet.Customers
        customersTableAdapter.Fill(customerTable)

        Dim customerQuery = From customers In customerTable.AsEnumerable.Take(20) _
                Select CustomerID = customers.Customer_ID, _
                CustomerName = customers.Contact_Name

        ' Execute the query.
        For Each item In customerQuery
            Me.ComboBox1.Items.Add(CreateRibbonDropDownItem())

            Me.ComboBox1.Items.Last().Label = item.CustomerID.ToString() _
                + "|" + item.CustomerName
        Next item

        Me.ComboBox1.Text = Me.ComboBox1.Items.First().Label
        PopulateSalesOrderInfo()
    End Sub
