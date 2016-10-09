        Me.button1 = extendedDocument.Controls.AddButton(range1, 60, 15, "1")
        Me.button1.Text = "Previous"
        Me.button2 = extendedDocument.Controls.AddButton(range2, 60, 15, "2")
        Me.button2.Text = "Next"

        Me.customerContentControl = extendedDocument.Controls.AddRichTextContentControl(range3, _
            "richTextContentControl1")