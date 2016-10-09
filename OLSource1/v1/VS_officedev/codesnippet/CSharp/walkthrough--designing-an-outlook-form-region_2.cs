        private void MapIt_FormRegionShowing(object sender, EventArgs e)
        {
            string tempLoc = "";
            string defaultAddress = "";
            string scratchPadAddress = "";

            Outlook.ContactItem myItem = (Outlook.ContactItem)this.OutlookItem;

            if (myItem != null)
            {
                if (myItem.HomeAddress != null && 
                        myItem.HomeAddress.Trim().Length > 0)
                {
                    tempLoc = myItem.HomeAddressStreet.Trim() + " " + 
                        myItem.HomeAddressCity + " " + myItem.HomeAddressState + 
                            " " + myItem.HomeAddressPostalCode;
                    if (myItem.HomeAddress == myItem.MailingAddress)
                    {
                        defaultAddress = tempLoc + "_Home";
                    }
                    else
                    {
                        scratchPadAddress += "adr." + tempLoc + "_Home~";
                    }
                }
                if (myItem.BusinessAddress != null && 
                        myItem.BusinessAddress.Trim().Length > 0)
                {
                    tempLoc = myItem.BusinessAddressStreet.Trim() + 
                        " " + myItem.BusinessAddressCity + " " + 
                            myItem.BusinessAddressState + " " + 
                                myItem.BusinessAddressPostalCode;
                    if (myItem.BusinessAddress == myItem.MailingAddress)
                    {
                        defaultAddress = tempLoc + "_Business";
                    }
                    else
                    {
                        scratchPadAddress += "adr." + tempLoc + "_Business~";
                    }
                }
                if (myItem.OtherAddress != null && myItem.OtherAddress.Trim().Length > 0)
                {
                    tempLoc = myItem.OtherAddressStreet.Trim() + " " + 
                        myItem.OtherAddressCity + " " + myItem.OtherAddressState + 
                            " " + myItem.OtherAddressPostalCode;
                    if (myItem.OtherAddress == myItem.MailingAddress)
                    {
                        defaultAddress = tempLoc + "_Other";
                    }
                    else
                    {
                        scratchPadAddress += "adr." + tempLoc + "_Other~";
                    }
                }
            }

            webBrowser1.Navigate("http://local.live.com/default.aspx?style=r&where1=" 
                + defaultAddress + "&sp=" + scratchPadAddress);

        }