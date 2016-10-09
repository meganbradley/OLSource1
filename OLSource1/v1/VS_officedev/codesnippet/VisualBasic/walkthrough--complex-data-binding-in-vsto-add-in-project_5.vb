        Me.addressBindingSource.DataSource = Me.adventureWorksDataSet.Address
        Me.addressListObject.AutoSetDataBoundColumnHeaders = True
        Me.addressListObject.SetDataBinding( _
            Me.addressBindingSource, "", "AddressID", "AddressLine1", _
            "AddressLine2", "City", "StateProvince", "CountryRegion", "PostalCode")