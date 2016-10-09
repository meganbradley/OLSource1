        private void Application_DocumentOpen_ClearActiveXWrappers(Word.Document Doc)
        {
            Microsoft.Office.Tools.Word.Document vstoDocument = Globals.Factory.GetVstoObject(Doc);

        }