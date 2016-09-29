        Private Sub RetrieveCustomer_Execute()
            Dim order As Order
            order = Me.DataWorkspace.NorthwindData.Orders_Single _
                (Orders.SelectedItem.OrderID)
            Dim cust As Customer
            cust = order.Customer
            'Perform some task on the order entity.
        End Sub