        private Microsoft.Office.Tools.Excel.ListObject vstoListObject;
        private const int DISP_E_BADINDEX = unchecked((int)0x8002000B);

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Excel.ListObject nativeListObject = null;

            try
            {
                nativeListObject = this.ListObjects.get_Item("MyListObject");
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                // "MyListObject" does not exist.
                if (ex.ErrorCode != DISP_E_BADINDEX)
                    throw;
            }

            if (nativeListObject != null)
            {
                vstoListObject = this.Controls.AddListObject(nativeListObject);
            }
        }