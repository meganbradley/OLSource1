        private void list1_BeforeAddDataBoundRow(object sender,
            Microsoft.Office.Tools.Excel.BeforeAddDataBoundRowEventArgs e)
        {
            System.Data.DataRow row = ((System.Data.DataRowView)e.Item).Row;

            if (row["Age"] != null && row["Age"] != Convert.DBNull)
            {
                int ageEntered = (int)row["Age"];

                if (ageEntered < 21 || ageEntered > 65)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("Age must be between 21 and 65. The row cannot be added.");
                    e.Cancel = true;
                    return;
                }
                row["ID"] = id;
                id++;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You must enter an age.");
                e.Cancel = true;
            }
        }