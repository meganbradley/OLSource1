    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup

        taskPaneControl1 = New TaskPaneControl()
        taskPaneValue = Me.CustomTaskPanes.Add( _
            taskPaneControl1, "MyCustomTaskPane")
    End Sub