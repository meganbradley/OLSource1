    Private Sub BindControlsToCustomXmlPart()
        Dim xPathName As String = "ns:employees/ns:employee/ns:name"
        Me.PlainTextContentControl1.XMLMapping.SetMapping(xPathName, _
            prefix, employeeXMLPart)

        Dim xPathDate As String = "ns:employees/ns:employee/ns:hireDate"
        Me.DatePickerContentControl1.DateDisplayFormat = "MMMM d, yyyy"
        Me.DatePickerContentControl1.XMLMapping.SetMapping(xPathDate, _
            prefix, employeeXMLPart)

        Dim xPathTitle As String = "ns:employees/ns:employee/ns:title"
        Me.DropDownListContentControl1.XMLMapping.SetMapping(xPathTitle, _
            prefix, employeeXMLPart)
    End Sub