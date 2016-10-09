    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)> _
    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Task.Contoso")> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Attributes.FormRegion1")> _
    Partial Public Class FormRegion1Factory

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
        Private Sub FormRegion1Factory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub