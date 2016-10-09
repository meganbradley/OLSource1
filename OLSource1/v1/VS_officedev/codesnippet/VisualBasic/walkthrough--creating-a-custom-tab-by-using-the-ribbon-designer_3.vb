    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles Button1.Click
        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = True
        actionsPane2.Hide()
        actionsPane1.Show()
        ToggleButton1.Checked = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles Button2.Click

        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = True
        actionsPane1.Hide()
        actionsPane2.Show()
        ToggleButton1.Checked = False

    End Sub


    Private Sub ToggleButton1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles ToggleButton1.Click

        If ToggleButton1.Checked Then
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = False
        Else
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = True
        End If

    End Sub