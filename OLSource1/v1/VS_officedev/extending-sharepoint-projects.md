---
title: "Extending SharePoint Projects"
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
ms.assetid: 4643012b-6e6c-4b7c-bb92-b04b34f6c715
caps.latest.revision: 19
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
# Extending SharePoint Projects
  Create a project extension when you want to customize project-level features of SharePoint projects. For example, you can add custom project properties, or respond to project-level events that are raised when the user develops a SharePoint solution in Visual Studio.  
  
## Creating Project Extensions  
 To extend a project item, build a Visual Studio extension assembly that implements the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface. For more information, see [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md).  
  
 When you create a project extension, you can also add the following functionality to the SharePoint projects:  
  
-   Add a shortcut menu item. The menu item appears when you  open the shortcut menu for a SharePoint project node in **Solution Explorer** by right-clicking the node or choosing it and then choosing the Shift + F10 keys. For more information, see [How to: Add a Shortcut Menu Item to SharePoint Projects](../VS_officedev/how-to--add-a-shortcut-menu-item-to-sharepoint-projects.md).  
  
-   Add a custom property. The property appears in the **Properties** window when you choose a SharePoint project in **Solution Explorer**. For more information, see [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md).  
  
 For a walkthrough that demonstrates how to create, deploy, and test a project extension, see [Walkthrough: Creating a SharePoint Project Extension](../VS_officedev/walkthrough--creating-a-sharepoint-project-extension.md).  
  
## Understanding the Relationship Between Project Extensions and Project Instances  
 When you create a project extension, the extension loads when any kind of SharePoint project is opened in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)]. [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] includes several SharePoint project templates, such as list definitions, content types, and event receivers. However, there is only one SharePoint project type. The project types that appear in the **New Project** dialog box are only templates that bundle together one or more SharePoint project items. Because there is only one SharePoint project type, extensions created for one project apply to all SharePoint projects. You cannot, for example, create an extension that applies to only a **Content Type** project.  
  
 To access a specific project instance, handle one of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> events of the *projectService* parameter in your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize*> method. For example, to determine when a SharePoint project is added to a solution, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectAdded> event. For more information, see [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md).  
  
## See Also  
 [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md)   
 [How to: Add a Shortcut Menu Item to SharePoint Projects](../VS_officedev/how-to--add-a-shortcut-menu-item-to-sharepoint-projects.md)   
 [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md)   
 [Walkthrough: Creating a SharePoint Project Extension](../VS_officedev/walkthrough--creating-a-sharepoint-project-extension.md)   
 [Defining Custom SharePoint Project Item Types](../VS_officedev/defining-custom-sharepoint-project-item-types.md)   
 [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md)   
 [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md)   
 [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md)  
  
  