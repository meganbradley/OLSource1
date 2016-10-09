            dynamic dialog = Application.Dialogs[Word.WdWordDialog.wdDialogFileOpen];
            dialog.Name = "Testing";
            dialog.Show();
            MessageBox.Show(dialog.Name);