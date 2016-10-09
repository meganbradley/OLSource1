    Private Sub TaskPane_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles taskPane.VisibleChanged
        Globals.Ribbons(inspector).ManageTaskPaneRibbon.ToggleButton1.Checked = taskPane.Visible
    End Sub