        public bool GetVisible(Office.IRibbonControl control)
        {
            if (control.Id == "BoldButton")
            {
                if (Globals.ThisDocument.showBoldButton == true)
                {
                    Globals.ThisDocument.showBoldButton = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (control.Id == "ItalicButton")
            {
                if (Globals.ThisDocument.showItalicButton == true)
                {
                    Globals.ThisDocument.showItalicButton = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
       
        }
 