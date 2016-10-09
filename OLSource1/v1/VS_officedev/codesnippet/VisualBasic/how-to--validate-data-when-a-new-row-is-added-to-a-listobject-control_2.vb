        employeeTable = New System.Data.DataTable("Employees")

        Dim column As System.Data.DataColumn = _
            employeeTable.Columns.Add("Id", GetType(Int32))
        column.AllowDBNull = False

        employeeTable.Columns.Add("FirstName", GetType(String))
        employeeTable.Columns.Add("LastName", GetType(String))
        employeeTable.Columns.Add("Age", GetType(Int32))

        employeeTable.Rows.Add(id, "Nancy", "Anderson", 56)
        employeeTable.Rows.Add(id, "Robert", "Brown", 44)
        id += 1

        list1.SetDataBinding(employeeTable, "", "FirstName", "LastName", "Age")