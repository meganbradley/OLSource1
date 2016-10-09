    Private Sub MyRibbon_Load(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs) Handles MyBase.Load
        Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane1)
        Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane2)
        actionsPane1.Hide()
        actionsPane2.Hide()
        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = False
    End Sub