            Microsoft.Office.Tools.Word.Controls.Button salesButton;

            Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            extendedDocument.Paragraphs[1].Range.InsertParagraphBefore();
            salesButton = extendedDocument.Controls.AddButton(
                extendedDocument.Paragraphs[1].Range, 75, 18, "salesButton");
            salesButton.Text = "Calculate Sales";