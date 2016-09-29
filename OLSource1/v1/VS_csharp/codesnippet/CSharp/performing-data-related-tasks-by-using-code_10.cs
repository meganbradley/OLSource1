        partial void Customers_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.RoleUpdate);
        }