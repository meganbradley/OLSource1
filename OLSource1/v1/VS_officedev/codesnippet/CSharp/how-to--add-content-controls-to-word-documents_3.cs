        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.RichTextContentControl> richTextControls;

        private void CreateRichTextControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            richTextControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.RichTextContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type ==
                    Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                {
                    count++;
                    Microsoft.Office.Tools.Word.RichTextContentControl tempControl =
                        this.Controls.AddRichTextContentControl(nativeControl,
                        "VSTORichTextControl" + count.ToString());
                    richTextControls.Add(tempControl);
                }
            }
        }