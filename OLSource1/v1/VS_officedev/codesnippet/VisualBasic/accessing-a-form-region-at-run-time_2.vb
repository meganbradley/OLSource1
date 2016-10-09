    Private Sub Access_Form_Regions_ByExplorer()
        Dim formRegions As WindowFormRegionCollection = Globals.FormRegions _
            (Globals.ThisAddIn.Application.ActiveExplorer())
        formRegions.FormRegion1.textBox1.Text = "Hello World"
    End Sub