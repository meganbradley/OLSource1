        void Application_DocumentBeforeClose(Word.Document Doc, ref bool Cancel)
        {

            bool isExtended = Globals.Factory.HasVstoObject(Doc);

            if (isExtended)
            {
                Microsoft.Office.Tools.Word.Document vstoDocument = Globals.Factory.GetVstoObject(Doc);

                
                System.Collections.ArrayList controlsToRemove = 
                    new System.Collections.ArrayList();
                
                // Get all of the Windows Forms controls.
                foreach (object control in vstoDocument.Controls)
                {
                    if (control is System.Windows.Forms.Control)
                    {
                        controlsToRemove.Add(control);
                    }
                }

                // Remove all of the Windows Forms controls from the document.
                foreach (object control in controlsToRemove)
                {
                    vstoDocument.Controls.Remove(control);
                }
            }
        }