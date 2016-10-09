    Private Sub Access_Ribbons_By_Inspector()
        Dim ribbonCollection As ThisRibbonCollection = Globals.Ribbons _
            (Globals.ThisAddIn.Application.ActiveInspector())
        ribbonCollection.Ribbon1.ComboBox1.Text = "Hello World"
    End Sub