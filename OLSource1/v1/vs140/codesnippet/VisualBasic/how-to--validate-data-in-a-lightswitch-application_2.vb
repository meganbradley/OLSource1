        Private Sub RequiredDate_Validate(results As EntityValidationResultsBuilder)
            If Me.RequiredDate < Me.OrderDate Then
                results.AddEntityError _
                    ("Required data cannot be earlier than the order date")
            End If

        End Sub