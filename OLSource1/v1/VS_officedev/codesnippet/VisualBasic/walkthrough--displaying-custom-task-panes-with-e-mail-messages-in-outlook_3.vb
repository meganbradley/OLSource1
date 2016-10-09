    Public Sub New(ByVal Inspector As Outlook.Inspector)
        Me.inspector = Inspector
        inspectorEvents = TryCast(Me.inspector, Outlook.InspectorEvents_Event)
        taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(New TaskPaneControl(), _
            "My task pane", Inspector)
    End Sub