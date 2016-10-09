    Friend Sub ToggleButtonOnDocument()
        Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        Dim name As String = "MyButton"

        If Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked Then
            Dim selection = Me.Application.Selection
            If selection IsNot Nothing AndAlso selection.Range IsNot Nothing Then
                button = vstoDocument.Controls.AddButton( _
                    selection.Range, 100, 30, name)
            End If
        Else
            vstoDocument.Controls.Remove(name)
        End If
    End Sub