        Me.Application.Documents.Add("")
        Dim copyPage As Visio.Page
        Dim pastePage As Visio.Page
        Dim rectangle As Visio.Shape = Nothing
        Dim oval As Visio.Shape = Nothing

        Dim visioPages As Visio.Pages = Me.Application.ActiveDocument.Pages

        visioPages.Add()

        Try
            copyPage = visioPages(1)
            rectangle = copyPage.DrawRectangle(1.1, 2.2, 4.5, 6.7)
            oval = copyPage.DrawOval(1, 8.75, 3.5, 6.25)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            pastePage = visioPages(2)
            rectangle.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
            pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
            oval.Copy(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
            pastePage.Paste(Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try