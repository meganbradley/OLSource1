        internal void ToggleButtonOnDocument()
        {
            Document vstoDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            string name = "MyButton";

            if (Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked)
            {
                Word.Selection selection = this.Application.Selection;
                if (selection != null && selection.Range != null)
                {
                    button = vstoDocument.Controls.AddButton(
                        selection.Range, 100, 30, name);
                }
            }
            else
            {
                vstoDocument.Controls.Remove(name);
            }
        }