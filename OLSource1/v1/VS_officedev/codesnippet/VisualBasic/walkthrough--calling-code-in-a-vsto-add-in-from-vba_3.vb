    Private utilities As AddInUtilities

    Protected Overrides Function RequestComAddInAutomationService() As Object
        If utilities Is Nothing Then
            utilities = New AddInUtilities()
        End If
        Return utilities
    End Function