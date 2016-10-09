---
title: "How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type"
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
  - "SharePoint project items, defining your own types"
  - "project items [SharePoint development in Visual Studio], defining your own types"
  - "SharePoint development in Visual Studio, defining new project item types"
ms.assetid: f6ec47a7-e7d9-4e26-810b-77943a1ab04c
caps.latest.revision: 10
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
# How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type
  When you define a custom SharePoint project item type, you can add a shortcut menu item to the project item. The menu item appears when a user right-clicks the project item in **Solution Explorer**.  
  
 The following steps assume that you have already defined your own SharePoint project item type. For more information, see [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md).  
  
### To add a shortcut menu item to a custom project item type  
  
1.  In the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType*> method of your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event of the *projectItemTypeDefinition* parameter.  
  
2.  In your event handler for the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemMenuItemsRequested> event, add a new \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object to the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.ViewMenuItems*> or \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemMenuItemsRequestedEventArgs.AddMenuItems*> collection of the event arguments parameter.  
  
3.  In the \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem.Click> event handler for the new \<xref:Microsoft.VisualStudio.SharePoint.IMenuItem> object, perform the tasks you want to execute when a user chooses your shortcut menu item.  
  
## Example  
 The following code example demonstrates how to add a context menu item to a custom project item type. When the user opens the shortcut menu from the project item in **Solution Explorer** and chooses the **Write Message to Output Window** menu item, Visual Studio displays a message in the **Output** window.  
  
 [!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#4](../VS_officedev/codesnippet/CSharp/how-to--add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type_1.cs)]
[!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#4](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type_1.vb)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window. For more information, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
## Compiling the Code  
 This example requires a class library project with references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Project Item  
 To enable other developers to use your project item, create a project template or a project item template. For more information, see [Creating Item Templates and Project Templates for SharePoint Project Items](../VS_officedev/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).  
  
 To deploy the project item, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly, the template, and any other files that you want to distribute with the project item. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md)   
 [How to: Add a Property to a Custom SharePoint Project Item Type](../VS_officedev/how-to--add-a-property-to-a-custom-sharepoint-project-item-type.md)   
 [Defining Custom SharePoint Project Item Types](../VS_officedev/defining-custom-sharepoint-project-item-types.md)  
  
  