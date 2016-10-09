            this.customerBindingSource.DataSource = this.adventureWorksDataSet.Customer;
            this.customerContentControl.DataBindings.Add("Text", this.customerBindingSource, 
                "CompanyName", true, this.customerContentControl.DataBindings.DefaultDataSourceUpdateMode);
            
            this.button1.Click += new EventHandler(button1_Click);
            this.button2.Click += new EventHandler(button2_Click);