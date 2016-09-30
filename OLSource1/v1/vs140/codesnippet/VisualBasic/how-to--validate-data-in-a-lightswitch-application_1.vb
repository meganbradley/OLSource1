        Private Sub ShippedDate_Validate(results As EntityValidationResultsBuilder)
            If Me.ShippedDate > DateTime.Today Then
                results.AddPropertyError _
                    ("Shipped date cannot be later than today")
            End If

        End Sub