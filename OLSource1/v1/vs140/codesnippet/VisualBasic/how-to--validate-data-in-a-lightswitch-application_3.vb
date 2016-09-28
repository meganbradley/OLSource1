        Private Sub Customers_Validate _
            (results As Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder)
            If Me.DataWorkspace.NorthwindData.Details.HasChanges Then
                Dim changeSet As EntityChangeSet = _
                    Me.DataWorkspace.NorthwindData.Details.GetChanges()

                Dim entity As IEntityObject

                For Each entity In changeSet.DeletedEntities.OfType(Of Customer)()

                    Dim cust As Customer = CType(entity, Customer)
                    If cust.Country = "USA" Then
                        entity.Details.DiscardChanges()
                        results.AddScreenResult("Unable to remove this customer." & _
                            "Cannot delete customers that are located in the USA.", _
                             ValidationSeverity.Informational)
                    End If

                Next
            End If

        End Sub