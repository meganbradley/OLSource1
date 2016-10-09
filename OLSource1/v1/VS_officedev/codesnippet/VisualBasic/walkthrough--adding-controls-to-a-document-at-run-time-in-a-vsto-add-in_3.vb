    Friend Sub ToggleRichTextControlOnDocument()

        Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        Dim name As String = "MyRichTextBoxControl"

        If Globals.Ribbons.MyRibbon.addRichTextCheckBox.Checked Then
            Dim selection = Me.Application.Selection
            If selection IsNot Nothing AndAlso selection.Range IsNot Nothing Then
                richTextControl = vstoDocument.Controls.AddRichTextContentControl( _
                        selection.Range, name)
            End If
        Else
            vstoDocument.Controls.Remove(name)
        End If
    End Sub