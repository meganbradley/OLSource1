        private void Access_Form_Regions_ByInspector()
        {
            WindowFormRegionCollection formRegions = 
                Globals.FormRegions
                    [Globals.ThisAddIn.Application.ActiveInspector()];
            formRegions.FormRegion1.textBox1.Text = "Hello World";
        }