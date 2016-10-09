        internal void ToggleRichTextControlOnDocument()
        {

            Document vstoDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            string name = "MyRichTextBoxControl";

            if (Globals.Ribbons.MyRibbon.addRichTextCheckBox.Checked)
            {
                Word.Selection selection = this.Application.Selection;
                if (selection != null && selection.Range != null)
                {
                    richTextControl = vstoDocument.Controls.AddRichTextContentControl(
                        selection.Range, name);
                }
            }
            else
            {
                vstoDocument.Controls.Remove(name);
            }
        }