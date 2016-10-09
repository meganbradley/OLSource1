        private void Access_Form_Regions_ByExplorer()
        {
            WindowFormRegionCollection formRegions =
                Globals.FormRegions
                    [Globals.ThisAddIn.Application.ActiveExplorer()];
            formRegions.FormRegion1.textBox1.Text = "Hello World";
        }