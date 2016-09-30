        Private Sub RetrieveSalesOrders_Execute()
            Dim cust As Customer = Me.Customers.SelectedItem
            For Each myOrder As Order In cust.Orders
                If myOrder.OrderDate = Today Then
                    'Perform some task on the order entity.
                End If
            Next
        End Sub