    Private Sub Application_DocumentBeforeClose(ByVal Doc As Word.Document, _
        ByRef Cancel As Boolean) Handles Application.DocumentBeforeClose

        Dim isExtended As Boolean = Globals.Factory.HasVstoObject(Doc)

        If isExtended Then

            Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Doc)

            Dim controlsToRemove As System.Collections.ArrayList = _
                New System.Collections.ArrayList()

            ' Get all of the Windows Forms controls.
            For Each control As Object In vstoDocument.Controls
                If TypeOf control Is System.Windows.Forms.Control Then
                    controlsToRemove.Add(control)
                End If
            Next

            ' Remove all of the Windows Forms controls from the document.
            For Each control As Object In controlsToRemove
                vstoDocument.Controls.Remove(control)
            Next
        End If
    End Sub