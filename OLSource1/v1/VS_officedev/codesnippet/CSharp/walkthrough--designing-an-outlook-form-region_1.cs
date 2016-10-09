            private void MapItFactory_FormRegionInitializing(object sender,
                Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
                Outlook.ContactItem myItem = (Outlook.ContactItem)e.OutlookItem;

                if (myItem != null)
                {
                    if ((myItem.BusinessAddress != null &&
                            myItem.BusinessAddress.Trim().Length > 0) ||
                        (myItem.HomeAddress != null && 
                            myItem.HomeAddress.Trim().Length > 0) ||
                        (myItem.OtherAddress != null && 
                            myItem.OtherAddress.Trim().Length > 0))
                    {
                        return;
                    }
                }

                e.Cancel = true;
            }