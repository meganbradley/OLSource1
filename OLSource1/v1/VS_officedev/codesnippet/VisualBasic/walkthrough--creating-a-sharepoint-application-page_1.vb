        Protected Sub DropDownList1_SelectedIndexChanged _
       (ByVal sender As Object, ByVal e As EventArgs) _
       Handles DropDownList1.SelectedIndexChanged
            SPSecurity.RunWithElevatedPrivileges(AddressOf GetItems)
        End Sub