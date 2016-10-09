        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            try
            {
                // Get reference to SharePoint site.
                SPSite site = new SPSite("http://localhost");
                SPWeb web = site.OpenWeb("/");
                // Get reference to Announcements list.
                SPList announcementsList = web.Lists["Announcements"];

                // Add new announcement to Announcements list.
                SPListItem oListItem = announcementsList.Items.Add();
                oListItem["Title"] = "Deactivated Feature: " + properties.Definition.DisplayName;
                oListItem["Body"] = properties.Definition.DisplayName + " was deactivated on: " + DateTime.Now.ToString();
                oListItem.Update();

            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            
        }