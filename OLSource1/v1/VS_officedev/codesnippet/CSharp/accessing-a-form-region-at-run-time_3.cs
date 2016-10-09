        internal void Access_All_Form_Regions()
        {
            foreach (Microsoft.Office.Tools.Outlook.IFormRegion formRegion 
                in Globals.FormRegions)
            {
                if (formRegion is FormRegion1)
                {
                    FormRegion1 formRegion1 = (FormRegion1)formRegion;
                    formRegion1.textBox1.Text = "Hello World";
                }
            }

        }