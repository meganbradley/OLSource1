        private void codeActivity1_ExecuteCode(object sender, System.EventArgs e)
        {
            
            try
            {
                // Get reference to SharePoint site.
                SPSite site = new SPSite("http://MyServer");
                SPWeb web = site.OpenWeb("SPD2/");
                // Get reference to Announcements list.
                SPList announcementsList = web.Lists["Announcements"];

                // Add announcement to Announcements list for the Task.
                SPListItem oListItem = announcementsList.Items.Add();
                oListItem["Title"] = "Assigned task on " + DateTime.Now.ToString();
                oListItem.Update();
            }

            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }        
        }