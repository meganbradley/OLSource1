        private Microsoft.Office.Tools.Excel.NamedRange namedRange1;

        public void CreateVstoNamedRange(Excel.Range range, string name)
        {
            if (!this.Controls.Contains(name))
            {
                namedRange1 = this.Controls.AddNamedRange(range, name);
                namedRange1.Selected += new Excel.DocEvents_SelectionChangeEventHandler(
                        namedRange1_Selected);
            }
            else
            {
                MessageBox.Show("A named range with this specific name " +
                    "already exists on the worksheet.");
            }
        }

        private void namedRange1_Selected(Microsoft.Office.Interop.Excel.Range Target)
        {
            MessageBox.Show("This named range was created by Visual Studio " +
                "Tools for Office.");
        }