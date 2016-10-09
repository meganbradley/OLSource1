    Public Sub OnActionCallback(ByVal control As Office.IRibbonControl, _
        ByVal isPressed As Boolean)

        If (control.Id = "checkBox1") Then
            MessageBox.Show("You clicked " + control.Id)
        Else
            MessageBox.Show("You clicked a different control.")
        End If

    End Sub