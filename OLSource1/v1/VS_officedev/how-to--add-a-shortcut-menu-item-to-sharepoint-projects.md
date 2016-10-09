---
title: "How to: Add a Shortcut Menu Item to SharePoint Projects"
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
  - "projects [SharePoint development in Visual Studio], extending"
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint projects, extending"
ms.assetid: bb251fe9-f1bf-4ddd-9359-4b7f78fbd50f
caps.latest.revision: 9
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
# How to: Add a Shortcut Menu Item to SharePoint Projects
  You can add a shortcut menu item to any SharePoint project. The menu item appears when a user right-clicks a project node in **Solution Explorer**.  
  
 The following steps assume that you have already created a project extension. For more information, see [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md).  
  
### To add a shortcut menu item to SharePoint projects  
  
1.  In the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize*> method of your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> implementation, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectMenuItemsRequested> event of the *projectService* parameter.  
  
2.  In your event handler for the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectMenuItemsRequested> event, add a new \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectMenuItemsRequestedEventArgs.ActionMenuItems*> or \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectMenuItemsRequestedEventArgs.AddMenuItems*> collection of the event arguments parameter.  
  
3.  In the \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user clicks your shortcut menu item.  
  
## Example  
 The following code example demonstrates how to add a shortcut menu item to SharePoint project nodes in **Solution Explorer**. When the user right-clicks a project node and clicks the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window. This example uses the SharePoint project service to display the message. For more information, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
 [!code[SPExtensibility.ProjectExtension.Menu#1](../VS_officedev/codesnippet/CSharp/how-to--add-a-shortcut-menu-item-to-sharepoint-projects_1.cs)]
[!code[SPExtensibility.ProjectExtension.Menu#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-shortcut-menu-item-to-sharepoint-projects_1.vb)]  
  
## Compiling the Code  
 This example requires a class library project with references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending SharePoint Projects](../VS_officedev/extending-sharepoint-projects.md)   
 [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md)   
 [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md)  
  
  