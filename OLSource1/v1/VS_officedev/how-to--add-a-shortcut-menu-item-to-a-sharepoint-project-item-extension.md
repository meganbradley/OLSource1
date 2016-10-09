---
title: "How to: Add a Shortcut Menu Item to a SharePoint Project Item Extension"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "project items [SharePoint development in Visual Studio], extending"
  - "SharePoint project items, extending"
  - "SharePoint development in Visual Studio, extending project items"
ms.assetid: d00513a6-d66d-4fbe-9efa-ef3b08c9a73a
caps.latest.revision: 17
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Add a Shortcut Menu Item to a SharePoint Project Item Extension
  You can add a shortcut menu item to an existing SharePoint project item by using a project item extension. The menu item appears when a user right-clicks the project item in **Solution Explorer**.  
  
 The following steps assume that you have already created a project item extension. For more information, see [How to: Create a SharePoint Project Item Extension](../VS_officedev/how-to--create-a-sharepoint-project-item-extension.md).  
  
### To add a shortcut menu item in a project item extension  
  
1.  In the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize*> method of your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> implementation, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event of the *projectItemType* parameter.  
  
2.  In your event handler for the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event, add a new \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.ViewMenuItems*> or \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.AddMenuItems*> collection of the event arguments parameter.  
  
3.  In the \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user clicks your shortcut menu item.  
  
## Example  
 The following code example demonstrates how to add a shortcut menu item to the Event Receiver project item. When the user right-clicks the project item in **Solution Explorer** and clicks the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window.  
  
 [!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-shortcut-menu-item-to-a-sharepoint-project-item-extension_1.vb)]
[!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#1](../VS_officedev/codesnippet/CSharp/how-to--add-a-shortcut-menu-item-to-a-sharepoint-project-item-extension_1.cs)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window. For more information, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
## Compiling the Code  
 This example requires a class library project with references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [How to: Create a SharePoint Project Item Extension](../VS_officedev/how-to--create-a-sharepoint-project-item-extension.md)   
 [How to: Add a Property to a SharePoint Project Item Extension](../VS_officedev/how-to--add-a-property-to-a-sharepoint-project-item-extension.md)   
 [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md)   
 [Walkthrough: Extending a SharePoint Project Item Type](../VS_officedev/walkthrough--extending-a-sharepoint-project-item-type.md)  
  
  