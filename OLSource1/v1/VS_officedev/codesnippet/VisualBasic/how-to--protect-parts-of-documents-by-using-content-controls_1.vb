    Dim deletableControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Dim editableControl As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddProtectedContentControls()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = Me.Paragraphs(1).Range

        deletableControl = Me.Controls.AddRichTextContentControl(range1, _
            "deletableControl")
        deletableControl.PlaceholderText = "You can delete this control, " & _
            "but you cannot edit it"
        deletableControl.LockContents = True

        range1.InsertParagraphAfter()
        Dim range2 As Word.Range = Me.Paragraphs(2).Range

        editableControl = Me.Controls.AddRichTextContentControl(range2, _
            "editableControl")
        editableControl.PlaceholderText = "You can edit this control, " & _
            "but you cannot delete it"
        editableControl.LockContentControl = True
    End Sub