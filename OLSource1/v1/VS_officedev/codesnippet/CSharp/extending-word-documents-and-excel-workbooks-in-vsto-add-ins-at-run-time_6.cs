        private Word.Document document2 = null;
        private Microsoft.Office.Tools.Word.Document vstoDocument = null;

        private void CreateDocument2()
        {
            document2 = this.Application.Documents.Add(ref missing,
                ref missing, ref missing, ref missing);
            vstoDocument = Globals.Factory.GetVstoObject(document2);
            vstoDocument.BeforeSave += new SaveEventHandler(vstoDocument_BeforeSave);
        }

        private void vstoDocument_BeforeSave(object sender, SaveEventArgs e)
        {
            e.Cancel = true;
        }