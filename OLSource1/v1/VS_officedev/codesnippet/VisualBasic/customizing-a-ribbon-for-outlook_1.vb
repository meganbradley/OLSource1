    Public Function GetCustomUI(ByVal ribbonID As String) As String _
        Implements Office.IRibbonExtensibility.GetCustomUI

        Dim ribbonXML As String = String.Empty

        If ribbonID = "Microsoft.Outlook.Mail.Compose" Then
            ribbonXML = GetResourceText("Trin_RibbonOutlookBasic.Ribbon1.xml")
        End If

        Return ribbonXML
    End Function