    Dim deletableControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Dim editableControl As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddProtectedContentControls()

        Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        vstoDocument.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = vstoDocument.Paragraphs(1).Range

        deletableControl = vstoDocument.Controls.AddRichTextContentControl(range1, _
            "deletableControl")
        deletableControl.PlaceholderText = "You can delete this control, " & _
            "but you cannot edit it"
        deletableControl.LockContents = True

        range1.InsertParagraphAfter()
        Dim range2 As Word.Range = vstoDocument.Paragraphs(2).Range

        editableControl = vstoDocument.Controls.AddRichTextContentControl(range2, _
            "editableControl")
        editableControl.PlaceholderText = "You can edit this control, " & _
            "but you cannot delete it"
        editableControl.LockContentControl = True
    End Sub