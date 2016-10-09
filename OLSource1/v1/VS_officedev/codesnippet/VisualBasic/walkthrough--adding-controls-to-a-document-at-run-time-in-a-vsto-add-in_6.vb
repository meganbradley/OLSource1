    Private Sub addButtonCheckBox_Click(ByVal sender As System.Object, _
        ByVal e As RibbonControlEventArgs) Handles addButtonCheckBox.Click
        Globals.ThisAddIn.ToggleButtonOnDocument()
    End Sub

    Private Sub addRichTextCheckBox_Click(ByVal sender As System.Object, _
        ByVal e As RibbonControlEventArgs) Handles addRichTextCheckBox.Click
        Globals.ThisAddIn.ToggleRichTextControlOnDocument()
    End Sub