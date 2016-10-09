    Private Sub taskPaneValue_VisibleChanged(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles taskPaneValue.VisibleChanged

        Globals.Ribbons.ManageTaskPaneRibbon.ToggleButton1.Checked = taskPaneValue.Visible
    End Sub