    Private richTextControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.RichTextContentControl)

    Private Sub CreateRichTextControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlRichText Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.RichTextContentControl = _
                    Me.Controls.AddRichTextContentControl(nativeControl, _
                    "VSTORichTextContentControl" + count.ToString())
                richTextControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub