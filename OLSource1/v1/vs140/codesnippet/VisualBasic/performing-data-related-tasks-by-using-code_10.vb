        Private Sub Customers_CanUpdate(ByRef result As Boolean)
            result = Me.Application.User.HasPermission(Permissions.RoleUpdate)
        End Sub