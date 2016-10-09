            Microsoft.Office.Core.DocumentProperties properties;

            properties = (Microsoft.Office.Core.DocumentProperties)
                Globals.ThisWorkbook.BuiltinDocumentProperties; 

            Microsoft.Office.Core.DocumentProperty prop;
            prop = properties["Revision Number"]; 