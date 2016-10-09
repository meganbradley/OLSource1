            this.addressBindingSource.DataSource = this.adventureWorksDataSet.Address;
            this.addressListObject.AutoSetDataBoundColumnHeaders = true;
            this.addressListObject.SetDataBinding(
                this.addressBindingSource, "", "AddressID", "AddressLine1", 
                "AddressLine2", "City", "StateProvince", "CountryRegion", "PostalCode");