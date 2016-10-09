        Dim dlg As Word.Dialog = Application.Dialogs(Word.WdWordDialog.wdDialogFileOpen)
        Dim dlgType As Type = GetType(Word.Dialog)

        ' Set the Name property of the dialog box.
        dlgType.InvokeMember("Name", _
            Reflection.BindingFlags.SetProperty Or _
                Reflection.BindingFlags.Public Or _
                Reflection.BindingFlags.Instance, _
            Nothing, dlg, New Object() {"Testing"}, _
            System.Globalization.CultureInfo.InvariantCulture)

        ' Display the dialog box.
        dlg.Show()

        ' Show the Name property.
        MessageBox.Show(dlgType.InvokeMember("Name", _
            Reflection.BindingFlags.GetProperty Or _
                Reflection.BindingFlags.Public Or _
                Reflection.BindingFlags.Instance, _
            Nothing, dlg, Nothing, _
            System.Globalization.CultureInfo.InvariantCulture))