        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (textbox != null)
                {
                    textbox.Delete();
                }

                PowerPoint.Slide slide =
                    Globals.ThisAddIn.Application.ActivePresentation.Slides[1];
                textbox = slide.Shapes.AddTextbox(
                    Office.MsoTextOrientation.msoTextOrientationHorizontal,
                    50, 100, 600, 50);
                textbox.TextFrame.TextRange.Text = e.Start.ToLongDateString();
                textbox.TextFrame.TextRange.Font.Size = 48;
                textbox.TextFrame.TextRange.Font.Color.RGB =
                     Color.DarkViolet.ToArgb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }