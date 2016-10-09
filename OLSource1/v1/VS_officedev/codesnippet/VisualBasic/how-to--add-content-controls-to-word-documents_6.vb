    Private richTextControls As New System.Collections.Generic.List _
        (Of Microsoft.Office.Tools.Word.RichTextContentControl)

    Private Sub Application_DocumentOpen(ByVal Doc As Microsoft.Office.Interop.Word.Document) _
        Handles Application.DocumentOpen

        If Doc.ContentControls.Count > 0 Then

            Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Doc)

            Dim count As Integer = 0
            For Each nativeControl As Word.ContentControl In Doc.ContentControls
                If nativeControl.Type = Word.WdContentControlType.wdContentControlRichText Then
                    count += 1
                    Dim tempControl As Microsoft.Office.Tools.Word.RichTextContentControl = _
                        extendedDocument.Controls.AddRichTextContentControl(nativeControl, _
                        "VSTORichTextContentControl" + count.ToString())
                    richTextControls.Add(tempControl)
                End If
            Next nativeControl
        End If
    End Sub