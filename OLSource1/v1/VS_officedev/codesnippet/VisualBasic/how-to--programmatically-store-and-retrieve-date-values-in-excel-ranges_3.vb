        Dim value As Object = NamedRange1.Value2

        If Not value Is Nothing Then
            If TypeOf value Is Double Then
                dt = DateTime.FromOADate(CType(value, Double))
            Else
                DateTime.TryParse(CType(value, String), dt)
            End If
        End If

        MessageBox.Show(dt.ToString())