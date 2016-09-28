        partial void CustomersListDetail_Activated()
        {
            this.FindControl("Customers").SetBinding(
                System.Windows.Controls.ListBox.ItemsSourceProperty,
                "Value", System.Windows.Data.BindingMode.TwoWay);
        }