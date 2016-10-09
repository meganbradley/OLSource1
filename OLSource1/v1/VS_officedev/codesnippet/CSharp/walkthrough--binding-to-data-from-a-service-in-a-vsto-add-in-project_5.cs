        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            AddRichTextControlAtRange();
            InitializeServiceObjects();
            this.richTextContentControl.Entering += richTextContentControl_Entering;
        }