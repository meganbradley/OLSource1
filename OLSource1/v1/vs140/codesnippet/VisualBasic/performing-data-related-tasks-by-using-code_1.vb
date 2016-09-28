        Private Sub RetrieveCustomer_Execute()
            Dim cust As Customer = Me.Customers.SelectedItem
            If cust.ContactName = "Bob" Then
                'Perform some task on the customer entity.
            End If
        End Sub