        Private Sub RetrieveCustomers_Execute()
            For Each cust As Customer In Me.DataWorkspace.NorthwindData.Customers
                If cust.ContactName = "Bob" Then
                    'Perform some task on the customer entity.
                End If
            Next

        End Sub