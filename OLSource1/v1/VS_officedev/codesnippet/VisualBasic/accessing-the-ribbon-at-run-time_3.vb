    Private Sub Access_Ribbons_By_Explorer()
        Dim ribbonCollection As ThisRibbonCollection = Globals.Ribbons _
            (Globals.ThisAddIn.Application.ActiveExplorer())
        ribbonCollection.Ribbon1.ComboBox1.Text = "Hello World"
    End Sub