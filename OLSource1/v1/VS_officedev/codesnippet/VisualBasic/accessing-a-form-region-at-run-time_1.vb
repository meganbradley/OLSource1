    Private Sub Access_Form_Regions_ByInspector()
        Dim formRegions As WindowFormRegionCollection = Globals.FormRegions _
            (Globals.ThisAddIn.Application.ActiveInspector())
        formRegions.FormRegion1.textBox1.Text = "Hello World"
    End Sub
