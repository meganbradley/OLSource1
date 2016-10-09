    Private Sub ListObject_DataSourceAndMember()
        ' Create a DataSet and two DataTables.
        Dim ordersDataSet As New DataSet("ordersDataSet")
        Dim tableCustomers As New DataTable("Customers")
        Dim tableProducts As New DataTable("Products")
        ordersDataSet.Tables.Add(tableCustomers)
        ordersDataSet.Tables.Add(tableProducts)

        ' Add a data to the Customers DataTable.
        tableCustomers.Columns.Add(New DataColumn("LastName"))
        tableCustomers.Columns.Add(New DataColumn("FirstName"))
        Dim dr As DataRow = tableCustomers.NewRow()
        dr("LastName") = "Chan"
        dr("FirstName") = "Gareth"
        tableCustomers.Rows.Add(dr)

        ' Create a list object.
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range( _
            "A1"), "Customers")

        ' Bind the list object to the Customers table.
        List1.AutoSetDataBoundColumnHeaders = True
        List1.DataSource = ordersDataSet
        List1.DataMember = "Customers"

    End Sub
