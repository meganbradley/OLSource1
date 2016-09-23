        Private Sub ImportCustomers_Execute()
            For Each spCust As SharePointCustomer In _
                Me.DataWorkspace.SharePointData.NewCustomersInSharePoint
                Dim newCust As Customer = New Customer()
                With newCust

                    .ContactName = spCust.FirstName & " " & spCust.LastName
                    .Address = spCust.Address
                    .City = spCust.City
                    .PostalCode = spCust.PostalCode
                    .Region = spCust.Region

                    'Set the CopiedToDatabase field of the item in SharePoint.
                    spCust.CopiedToDatabase = "Yes"
                End With

            Next
            Me.DataWorkspace.SharePointData.SaveChanges()



        End Sub