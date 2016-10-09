        If prop.Value Is Nothing Then
            prop.Value = 1
        Else
            Dim revision As Integer
            If Integer.TryParse(prop.Value.ToString(), revision) Then
                prop.Value = revision + 1
                MessageBox.Show("Revision Number = " & revision)
            Else
                MessageBox.Show("Revision Number = invalid value")
            End If
        End If