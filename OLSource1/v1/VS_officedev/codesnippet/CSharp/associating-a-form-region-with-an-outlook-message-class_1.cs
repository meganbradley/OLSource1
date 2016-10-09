        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass
            (Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass
            ("IPM.Task.Contoso")]
        [Microsoft.Office.Tools.Outlook.FormRegionName
            ("Trin_Outlook_FR_Attributes.FormRegion1")]
        public partial class FormRegion1Factory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void FormRegion1Factory_FormRegionInitializing(object sender, 
                Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }