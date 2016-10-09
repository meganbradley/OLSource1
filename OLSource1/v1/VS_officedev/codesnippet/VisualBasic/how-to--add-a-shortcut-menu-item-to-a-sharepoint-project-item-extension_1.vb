Imports System
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.Examples.ProjectItemExtensionWithMenu

    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.EventHandler")> _
    Friend Class ExampleProjectItemExtensionWithMenu
        Implements ISharePointProjectItemTypeExtension

        Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            AddHandler projectItemType.ProjectItemMenuItemsRequested, AddressOf ProjectItemMenuItemsRequested
        End Sub

        Private Sub ProjectItemMenuItemsRequested(ByVal Sender As Object,
            ByVal e As SharePointProjectItemMenuItemsRequestedEventArgs)
            Dim menuItem As IMenuItem = e.ViewMenuItems.Add("Write Message to Output Window")
            AddHandler menuItem.Click, AddressOf MenuItem_Click
        End Sub

        Private Sub MenuItem_Click(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim projectItem As ISharePointProjectItem = CType(e.Owner, ISharePointProjectItem)
            projectItem.Project.ProjectService.Logger.WriteLine(
                String.Format("This message was written from a shortcut menu for {0}.", projectItem.Name),
                LogCategory.Status)
        End Sub
    End Class
End Namespace