    Public Function GetCustomUI(ByVal ribbonID As String) As String Implements Office.IRibbonExtensibility.GetCustomUI
        Dim ribbonXML As String = String.Empty

        If ribbonID = "Microsoft.InfoPath.Designer" Then
            ribbonXML = GetResourceText("MyInfoPathProject.Ribbon.xml")
        End If

        Return ribbonXML

    End Function