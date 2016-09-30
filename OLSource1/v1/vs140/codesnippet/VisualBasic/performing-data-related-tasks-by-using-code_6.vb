        Private Sub DeleteCustomer_Execute()
            Dim cust As Customer
            cust = Me.Customers.SelectedItem
            If Customers.CanDelete Then
                cust.Delete()
            End If

        End Sub