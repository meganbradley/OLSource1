            string newDocPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\test\MyOtherDrawing.vsd";
            this.Application.ActiveDocument.SaveAsEx(newDocPath,
                ((short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visSaveAsRO +
                 (short)Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visSaveAsListInMRU));