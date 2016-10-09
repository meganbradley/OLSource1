    Private Sub TestDynamicDialog()
        Dim dialog As Word.Dialog = Application.Dialogs(Word.WdWordDialog.wdDialogFileOpen)
        dialog.Name = "Testing"
        dialog.Show()
        MessageBox.Show(dialog.Name)
    End Sub