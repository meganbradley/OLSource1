        partial void Customers_SelectionChanged()
        {
            this.FindControl("Customers_DeleteSelected").IsEnabled = true;

            if (this.Customers.SelectedItem.CompanyName == "Great Lakes Food Market")
            {
                this.FindControl("CompanyName1").IsVisible = false;
                this.FindControl("Customers_DeleteSelected").IsEnabled = false;
            }
        }