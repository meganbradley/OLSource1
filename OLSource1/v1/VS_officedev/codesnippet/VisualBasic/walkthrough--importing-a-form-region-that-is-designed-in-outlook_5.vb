    Private Sub TaskFormRegion_FormRegionShowing(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
        populateComboBox()
        RefreshTaskListBox()
    End Sub