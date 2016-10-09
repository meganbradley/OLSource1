        Dim salesButton As Microsoft.Office.Tools.Word.Controls.Button

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        extendedDocument.Paragraphs(1).Range.InsertParagraphBefore()
        salesButton = extendedDocument.Controls.AddButton( _
            extendedDocument.Paragraphs(1).Range, 75, 18, "salesButton")
        salesButton.Text = "Calculate Sales"