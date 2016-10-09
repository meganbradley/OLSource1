    Private Function GetXmlFromResource() As String
        Dim asm As System.Reflection.Assembly = _
            System.Reflection.Assembly.GetExecutingAssembly()
        Dim stream1 As System.IO.Stream = asm.GetManifestResourceStream( _
                "EmployeeControls.employees.xml")

        Using resourceReader As System.IO.StreamReader = _
            New System.IO.StreamReader(stream1)
            If resourceReader IsNot Nothing Then
                Return resourceReader.ReadToEnd()
            End If
        End Using

        Return Nothing
    End Function