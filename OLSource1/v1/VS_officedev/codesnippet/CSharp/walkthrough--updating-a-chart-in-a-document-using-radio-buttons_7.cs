        private void ChartOptions1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                object index = 1;
                Word.Shape shape = this.Shapes.get_Item(ref index);

                // Activate the shape.
                shape.OLEFormat.Activate();

                Microsoft.Office.Interop.Graph.Chart dataChart = 
                    (Microsoft.Office.Interop.Graph.Chart)shape.OLEFormat.Object;
                dataChart.ChartType = this.ChartOptions1.Selection;

                // Deactivate the shape.
                this.ChartOptions1.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }