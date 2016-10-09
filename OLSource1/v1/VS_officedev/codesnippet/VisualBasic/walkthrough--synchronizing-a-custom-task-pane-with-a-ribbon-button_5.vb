    Private Sub ToggleButton1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles ToggleButton1.Click

        Globals.ThisAddIn.TaskPane.Visible = _
            TryCast(sender, Microsoft.Office.Tools.Ribbon.RibbonToggleButton).Checked
    End Sub