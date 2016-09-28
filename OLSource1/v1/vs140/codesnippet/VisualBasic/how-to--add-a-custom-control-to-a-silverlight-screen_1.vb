        Private Sub CustomersListDetail_Activated()
            Me.FindControl("Customers").SetBinding( _
                System.Windows.Controls.ListBox.ItemsSourceProperty, _
                        "Value", System.Windows.Data.BindingMode.TwoWay)
        End Sub