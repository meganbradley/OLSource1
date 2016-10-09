    Sub InspectorWrapper_Close() Handles inspectorEvents.Close
        If Not (taskPane Is Nothing) Then
            Globals.ThisAddIn.CustomTaskPanes.Remove(taskPane)
        End If

        taskPane = Nothing
        Globals.ThisAddIn.InspectorWrappers.Remove(inspector)
        RemoveHandler inspectorEvents.Close, AddressOf InspectorWrapper_Close
        inspector = Nothing
    End Sub