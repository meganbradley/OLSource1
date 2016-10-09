        Dim properties As Microsoft.Office.Core.DocumentProperties

        properties = DirectCast(Globals.ThisWorkbook.BuiltinDocumentProperties, _
            Microsoft.Office.Core.DocumentProperties)

        Dim prop As Microsoft.Office.Core.DocumentProperty
        prop = properties.Item("Revision Number")