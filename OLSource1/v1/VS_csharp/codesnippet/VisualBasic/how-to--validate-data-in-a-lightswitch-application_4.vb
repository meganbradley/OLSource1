        Private Sub Orders_Validate _
            (entity As Order, results As  _
             Microsoft.LightSwitch.EntitySetValidationResultsBuilder)
            If Not CustomerCreditApproval(entity.Customer) Then
                results.AddEntityError("Customer Credit has not yet been approved")
            End If

        End Sub
        Private Function CustomerCreditApproval(ByVal entity As Customer) As Boolean
            'Some custom code to check the customer’s credit status.
            Return True

        End Function