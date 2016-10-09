            this.Application.Documents.Add("");
            Visio.Page copyPage;
            Visio.Page pastePage;
            Visio.Shape rectangle = null;
            Visio.Shape oval = null;

            Visio.Pages visioPages = this.Application.ActiveDocument.Pages;

            visioPages.Add();

            try
            {
                copyPage = visioPages[1];
                rectangle = copyPage.DrawRectangle(1.1, 2.2, 4.5, 6.7);
                oval = copyPage.DrawOval(1, 8.75, 3.5, 6.25);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                pastePage = visioPages[2];
                rectangle.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
                pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
                oval.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
                pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNormal);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }