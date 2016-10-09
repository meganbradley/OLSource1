    Protected Overloads Overrides Sub CreateChildControls()

        'Define the grid control that displays employee data in the Web Part.
        grid = New DataGrid()
        With grid
            .Width = Unit.Percentage(100)
            .GridLines = GridLines.Horizontal
            .HeaderStyle.CssClass = "ms-vh2"
            .CellPadding = 2
            .BorderWidth = Unit.Pixel(5)
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Center
        End With



        'Populate the grid control with data in the employee data file.
        Try
            Dim dataset As New DataSet()
            dataset.ReadXml(xmlFilePath, XmlReadMode.InferSchema)
            grid.DataSource = dataset
            grid.DataBind()
        Catch x As Exception
            errorMessage.Text += x.Message
        End Try

        'Add control to the controls collection of the Web Part.
        Controls.Add(grid)
        Controls.Add(errorMessage)
        MyBase.CreateChildControls()

    End Sub