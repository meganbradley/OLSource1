        private void Application_DocumentBeforeSave(Word.Document Doc, 
            ref bool SaveAsUI, ref bool Cancel)
        {
            bool isExtended = Globals.Factory.HasVstoObject(Doc);


            if (isExtended)
            {

                Microsoft.Office.Tools.Word.Document vstoDocument = Globals.Factory.GetVstoObject(Doc);

                if (vstoDocument.Controls.Contains(button))
                {
                    vstoDocument.Controls.Remove(button);
                    Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked = false;
                }
            }
        }