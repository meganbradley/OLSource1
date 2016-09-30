        Private Sub UndoAllCustomerUpdates_Execute()
            For Each Cust As Customer In _
                Me.DataWorkspace.NorthwindData.Details. _
                GetChanges().OfType(Of Customer)()

                Cust.Details.DiscardChanges()

            Next
        End Sub

        Private Sub UndoAllUpdates_Execute()
            Me.DataWorkspace.NorthwindData.Details.DiscardChanges()
        End Sub

        Private Sub UnduCustomerEdit_Execute()
            Customers.SelectedItem.Details.DiscardChanges()
        End Sub