    Private Sub AddCustomXmlPartToPresentation(ByVal presentation As PowerPoint.Presentation)
        Dim xmlString As String = _
            "<?xml version=""1.0"" encoding=""utf-8"" ?>" & _
                "<employees xmlns=""http://schemas.microsoft.com/vsto/samples"">" & _
                    "<employee>" & _
                        "<name>Karina Leal</name>" & _
                        "<hireDate>1999-04-01</hireDate>" & _
                        "<title>Manager</title>" & _
                    "</employee>" & _
                "</employees>"
        Dim employeeXMLPart As Office.CustomXMLPart = _
            presentation.CustomXMLParts.Add(xmlString)
    End Sub