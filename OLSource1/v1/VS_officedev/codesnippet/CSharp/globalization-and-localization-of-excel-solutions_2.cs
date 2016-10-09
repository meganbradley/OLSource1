        private void ConvertDate_Click(object sender, EventArgs e)
        {
            try
            {
                double dbl = (double)(this.Range["A5"].Value2);
                System.DateTime dt = System.DateTime.FromOADate(dbl);
                this.Range["A7"].Value2 = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }