        Dim value As Object = rng.Value2

        If Not value Is Nothing Then
            If TypeOf value Is Double Then
                dt = DateTime.FromOADate(CType(value, Double))
            Else
                DateTime.TryParse(CType(value, String), dt)
            End If
        End If
        System.Windows.Forms.MessageBox.Show(dt.ToString())