        private void Access_Ribbons_By_Explorer()
        {
            ThisRibbonCollection ribbonCollection =
                Globals.Ribbons
                    [Globals.ThisAddIn.Application.ActiveExplorer()];
            ribbonCollection.Ribbon1.comboBox1.Text = "Hello World";
        }