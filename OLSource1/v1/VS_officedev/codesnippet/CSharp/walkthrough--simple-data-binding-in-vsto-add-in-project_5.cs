            this.button1 = extendedDocument.Controls.AddButton(range1, 60, 15, "1");
            this.button1.Text = "Previous";
            this.button2 = extendedDocument.Controls.AddButton(range2, 60, 15, "2");
            this.button2.Text = "Next";

            this.customerContentControl = extendedDocument.Controls.AddRichTextContentControl(
                range3, "richTextContentControl1");