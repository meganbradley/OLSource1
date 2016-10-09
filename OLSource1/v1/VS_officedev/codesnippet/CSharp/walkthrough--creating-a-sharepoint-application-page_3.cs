        private void GetItems()
        {
             SPFieldUserValue currentUser = new SPFieldUserValue
             (this.Web, this.Web.CurrentUser.ID, this.Web.CurrentUser.Name);

            ArrayList resultsList = new ArrayList();

            SPFarm thisFarm = SPFarm.Local;
            SPWebService service = thisFarm.Services.GetValue<SPWebService>("");

            foreach (SPWebApplication webApp in service.WebApplications)
            {
                foreach (SPSite siteCollection in webApp.Sites)
                {
                    foreach (SPWeb web in siteCollection.AllWebs)
                    {
                        SPListCollection lists = web.Lists;
                        foreach (SPList list in lists)
                        {
                            try
                            {
                                foreach (SPListItem item in list.Items)
                                {
                                    if (item[DropDownList1.SelectedValue].ToString() ==
                                        currentUser.ToString())
                                    {
                                        resultsList.Add(item);
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                // An error with the list. Move onto the next list.
                            }
                        }
                    }
                }
            }
            CreateResultsTable(resultsList);

        }