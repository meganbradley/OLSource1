        Dim dialog As Word.Dialog = Application.Dialogs.Item(Word.WdWordDialog.wdDialogFilePageSetup)

        ' Set the properties of the dialog box.
        ' ControlChars.Quote() is used to represent the symbol for inches.
        With dialog
            .PageWidth = 3.3 & ControlChars.Quote
            .PageHeight = 6 & ControlChars.Quote
            .TopMargin = 0.71 & ControlChars.Quote
            .BottomMargin = 0.81 & ControlChars.Quote
            .LeftMargin = 0.66 & ControlChars.Quote
            .RightMargin = 0.66 & ControlChars.Quote
            .HeaderDistance = 0.28 & ControlChars.Quote
            .Orientation = Word.WdOrientation.wdOrientPortrait
            .DifferentFirstPage = False
            .FirstPage = 0
            .OtherPages = 0

            ' Apply these settings only to the current selection with this line of code:
            .ApplyPropsTo = 3

            ' Apply the settings.
            .Execute()
        End With