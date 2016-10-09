    Friend Sub PageSetupDialogHidden()
        Dim dialog As Word.Dialog = Application.Dialogs.Item(Word.WdWordDialog.wdDialogFilePageSetup)

        ' Set the properties of the dialog box.
        ' ControlChars.Quote() is used to represent the symbol for inches.
        InvokeHelper(dialog, "PageWidth", "3.3" & ControlChars.Quote)
        InvokeHelper(dialog, "PageHeight", "6" & ControlChars.Quote)
        InvokeHelper(dialog, "TopMargin", "0.71" & ControlChars.Quote)
        InvokeHelper(dialog, "BottomMargin", "0.81" & ControlChars.Quote)
        InvokeHelper(dialog, "LeftMargin", "0.66" & ControlChars.Quote)
        InvokeHelper(dialog, "RightMargin", "0.66" & ControlChars.Quote)
        InvokeHelper(dialog, "HeaderDistance", "0.28" & ControlChars.Quote)
        InvokeHelper(dialog, "Orientation", "0")
        InvokeHelper(dialog, "DifferentFirstPage", "0")
        InvokeHelper(dialog, "FirstPage", "0")
        InvokeHelper(dialog, "OtherPages", "0")

        ' Apply these settings only to the current selection with this line of code:
        InvokeHelper(dialog, "ApplyPropsTo", "3")

        ' Apply the settings.
        dialog.Execute()
    End Sub

    Private Shared Sub InvokeHelper(ByVal dialog As Word.Dialog, ByVal member As String, ByVal value As String)
        Dim dialogType As System.Type = GetType(Word.Dialog)

        ' Set the appropriate property of the dialog box.
        dialogType.InvokeMember(member,
            System.Reflection.BindingFlags.SetProperty Or
                System.Reflection.BindingFlags.Public Or
                System.Reflection.BindingFlags.Instance,
            Nothing, dialog, New Object() {value},
            System.Globalization.CultureInfo.InvariantCulture)
    End Sub