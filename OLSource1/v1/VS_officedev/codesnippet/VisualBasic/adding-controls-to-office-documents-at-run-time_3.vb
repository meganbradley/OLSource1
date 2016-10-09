        Dim customControl As New UserControl1()

        Dim dynamicControl As Microsoft.Office.Tools.Excel.ControlSite = _
            Me.Controls.AddControl(customControl, range1, "dynamic")