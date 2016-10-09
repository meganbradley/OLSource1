    Private Sub PopulateSalesOrderInfo()

        Dim tempArray As [String]() = comboBox1.Text.Split(New [Char]() {"|"c})
        Menu1.Items.Clear()

        orderTable = nwDataSet.Orders
        orderDetailsTable = nwDataSet.Order_Details
        productsTable = nwDataSet.Products

        ordersTableAdapter.Fill(orderTable)
        detailsTableAdapter.Fill(orderDetailsTable)
        productsTableAdapter.Fill(productsTable)

        Dim orderQuery = From order In orderTable.AsEnumerable() _
                         Where order.Customer_ID.ToString() = tempArray(0) _
                         Select New With {.SalesOrderID = order.Order_ID}

        For Each orderItem In orderQuery
            Me.Menu1.Items.Add(CreateRibbonMenu())

            Dim orderMenu As RibbonMenu = CType(Menu1.Items.Last(), RibbonMenu)
            orderMenu.Dynamic = True
            orderMenu.Label = orderItem.SalesOrderID.ToString()
            orderMenu.Tag = orderItem.SalesOrderID

            Dim productQuery = From orderDetail In orderDetailsTable.AsEnumerable(), _
                                   product In productsTable.AsEnumerable() _
                               Where orderDetail.Product_ID = _
                                   product.Product_ID _
                               And orderDetail.Order_ID = _
                               orderMenu.Tag _
            Select productName = product.Product_Name

            For Each productItem In productQuery
                Dim button As RibbonButton = CreateRibbonButton()
                button.Label = productItem
                orderMenu.Items.Add(button)
            Next productItem
        Next orderItem
    End Sub