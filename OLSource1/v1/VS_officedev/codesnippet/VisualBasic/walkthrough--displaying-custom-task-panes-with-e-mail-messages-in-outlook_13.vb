    Private Sub ToggleButton1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
        Handles ToggleButton1.Click

        Dim inspector As Outlook.Inspector = e.Control.Context
        Dim inspectorWrapper As InspectorWrapper = Globals.ThisAddIn.InspectorWrappers(inspector)
        Dim taskPane As CustomTaskPane = inspectorWrapper.CustomTaskPane
        If Not (taskPane Is Nothing) Then
            taskPane.Visible = TryCast(sender, RibbonToggleButton).Checked
        End If
    End Sub