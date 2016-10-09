            employeeTable = new System.Data.DataTable("Employees");

            System.Data.DataColumn column = employeeTable.Columns.Add
                ("Id", typeof(int));
            column.AllowDBNull = false;

            employeeTable.Columns.Add("FirstName", typeof(string));
            employeeTable.Columns.Add("LastName", typeof(string));
            employeeTable.Columns.Add("Age", typeof(int));

            employeeTable.Rows.Add(id, "Nancy", "Anderson", "56");
            employeeTable.Rows.Add(id, "Robert", "Brown", "44");
            id++;

            list1.SetDataBinding(employeeTable, "", "FirstName", "LastName", "Age");

            list1.BeforeAddDataBoundRow +=new Microsoft.Office.Tools.Excel.
                BeforeAddDataBoundRowEventHandler(list1_BeforeAddDataBoundRow);