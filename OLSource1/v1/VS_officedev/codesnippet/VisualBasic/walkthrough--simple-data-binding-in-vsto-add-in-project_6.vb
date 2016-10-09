        Me.customerBindingSource.DataSource = Me.adventureWorksDataSet.Customer
        Me.customerContentControl.DataBindings.Add("Text", Me.customerBindingSource, _
            "CompanyName", True, Me.customerContentControl.DataBindings.DefaultDataSourceUpdateMode)