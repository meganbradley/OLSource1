            dynamic dialog = Application.Dialogs[Word.WdWordDialog.wdDialogFilePageSetup];
            dialog.PageWidth = "3.3\"";
            dialog.PageHeight = "6\"";
            dialog.TopMargin = "0.71\"";
            dialog.BottomMargin = "0.81\"";
            dialog.LeftMargin = "0.66\"";
            dialog.RightMargin = "0.66\"";
            dialog.HeaderDistance = "0.28\"";
            dialog.Orientation = "0";
            dialog.DifferentFirstPage = "0";
            dialog.FirstPage = "0";
            dialog.OtherPages = "0";

            // Apply these settings only to the current selection with this line of code:
            dialog.ApplyPropsTo = "3";

            // Apply the settings.
            dialog.Execute(); 