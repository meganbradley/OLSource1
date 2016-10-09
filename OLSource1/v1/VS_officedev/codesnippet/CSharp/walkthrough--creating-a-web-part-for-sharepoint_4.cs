        protected override void CreateChildControls()
        {
            // Define the grid control that displays employee data in the Web Part.
            grid = new DataGrid();
            grid.Width = Unit.Percentage(100);
            grid.GridLines = GridLines.Horizontal;
            grid.HeaderStyle.CssClass = "ms-vh2";
            grid.CellPadding = 2;
            grid.BorderWidth = Unit.Pixel(5);
            grid.HeaderStyle.Font.Bold = true;
            grid.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;

            // Populate the grid control with data in the employee data file.
            try
            {
                DataSet dataset = new DataSet();
                dataset.ReadXml(xmlFilePath, XmlReadMode.InferSchema);
                grid.DataSource = dataset;
                grid.DataBind();
            }
            catch (Exception x)
            {
                errorMessage.Text += x.Message;
            }

            // Add control to the controls collection of the Web Part.
            Controls.Add(grid);
            Controls.Add(errorMessage);
            base.CreateChildControls();
        }