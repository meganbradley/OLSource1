        private void Access_Ribbons_By_Inspector()
        {
            ThisRibbonCollection ribbonCollection = 
                Globals.Ribbons
                    [Globals.ThisAddIn.Application.ActiveInspector()];
            ribbonCollection.Ribbon1.comboBox1.Text = "Hello World";
        }