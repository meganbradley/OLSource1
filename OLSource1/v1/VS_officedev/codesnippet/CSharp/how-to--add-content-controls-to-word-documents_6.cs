        private System.Collections.Generic.List
            <Microsoft.Office.Tools.Word.RichTextContentControl> richTextControls;

        private void Application_DocumentOpen(Microsoft.Office.Interop.Word.Document Doc)
        {
            if (Doc.ContentControls.Count > 0)
            {
                Document extendedDocument = Globals.Factory.GetVstoObject(Doc);

                richTextControls = new System.Collections.Generic.List
                    <Microsoft.Office.Tools.Word.RichTextContentControl>();
                int count = 0;

                foreach (Word.ContentControl nativeControl in Doc.ContentControls)
                {
                    if (nativeControl.Type ==
                        Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                    {
                        count++;
                        Microsoft.Office.Tools.Word.RichTextContentControl tempControl =
                            extendedDocument.Controls.AddRichTextContentControl(nativeControl,
                            "VSTORichTextControl" + count.ToString());
                        richTextControls.Add(tempControl);
                    }
                }
            }
        }