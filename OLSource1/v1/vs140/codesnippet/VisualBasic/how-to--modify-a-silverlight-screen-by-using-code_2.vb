        Private Sub Customers_SelectionChanged()
            FindControl("Customers_DeleteSelected").IsEnabled = True

            If Me.Customers.SelectedItem.CompanyName = "Great Lakes Food Market" Then

                FindControl("CompanyName1").IsVisible = False
                FindControl("Customers_DeleteSelected").IsEnabled = False

            End If

        End Sub