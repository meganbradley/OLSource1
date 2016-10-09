                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyDrawing.vsd";
                this.Application.Documents.OpenEx(docPath,
                    ((short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked +
                     (short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenRO));