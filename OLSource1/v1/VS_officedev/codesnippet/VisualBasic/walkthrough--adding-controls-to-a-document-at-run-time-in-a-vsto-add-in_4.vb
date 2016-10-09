    Private Sub Application_DocumentBeforeSave(ByVal Doc As Word.Document, _
        ByRef SaveAsUI As Boolean, ByRef Cancel As Boolean) Handles Application.DocumentBeforeSave

        Dim isExtended As Boolean = Globals.Factory.HasVstoObject(Doc)


        If isExtended Then
            Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Doc)


            If vstoDocument.Controls.Contains(button) Then
                vstoDocument.Controls.Remove(button)
                Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked = False
            End If
        End If
    End Sub