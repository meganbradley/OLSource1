    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Shutdown

        RemoveHandler inspectors.NewInspector, AddressOf Inspectors_NewInspector
        inspectors = Nothing
        inspectorWrappersValue = Nothing
    End Sub