        partial void CustomersListDetail_Saving(ref bool handled)
        {
            try
            {
                this.DataWorkspace.SharePointData.SaveChanges();
            }
            catch (DataServiceOperationException ex)
            {
                if (ex.ErrorInfo == "DTSException")
                {
                    this.ShowMessageBox(ex.Message);
                }
                else
                {
                    throw ex;
                }
            }
            handled = true;


        }