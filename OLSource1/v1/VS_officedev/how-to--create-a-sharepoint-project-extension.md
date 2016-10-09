---
title: "How to: Create a SharePoint Project Extension"
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
ms.assetid: ceecb9cb-4a5d-44c9-992f-9624737ac996
caps.latest.revision: 29
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
# How to: Create a SharePoint Project Extension
  Create a project extension when you want to add functionality to any SharePoint project that is open in Visual Studio. For more information, see [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md).  
  
### To create a project extension  
  
1.  Create a class library project.  
  
2.  Add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.SharePoint  
  
    -   System.ComponentModel.Composition  
  
3.  Create a class that implements the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface.  
  
4.  Add the \<xref:System.ComponentModel.Composition.ExportAttribute> to the class. This attribute enables Visual Studio to discover and load your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> implementation. Pass the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> type to the attribute constructor.  
  
5.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize*> method, use members of the *projectService* parameter to define the behavior of your extension. This parameter is an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object that provides access to the events defined in the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> interface.  
  
## Example  
 The following code example demonstrates how to create a simple project extension that handles most of the SharePoint project events that are defined by the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents> interface. To test the code, create a SharePoint project in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] and then add more projects to the solution, change project property values, or delete or exclude a project. The extension notifies you of the events by writing messages to the **Output** window and **Error List** window.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#3](../VS_officedev/codesnippet/VisualBasic/how-to--create-a-sharepoint-project-extension_1.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#3](../VS_officedev/codesnippet/VisualBasic/how-to--create-a-sharepoint-project-extension_1.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#3](../VS_officedev/codesnippet/CSharp/how-to--create-a-sharepoint-project-extension_1.cs)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window and **Error List** window. For more information, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
 For examples that demonstrate how to handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectMenuItemsRequested> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectPropertiesRequested> events, see [How to: Add a Shortcut Menu Item to SharePoint Projects](../VS_officedev/how-to--add-a-shortcut-menu-item-to-sharepoint-projects.md) and [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md).  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md)   
 [How to: Add a Shortcut Menu Item to SharePoint Projects](../VS_officedev/how-to--add-a-shortcut-menu-item-to-sharepoint-projects.md)   
 [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md)   
 [Walkthrough: Creating a SharePoint Project Extension](../VS_officedev/walkthrough--creating-a-sharepoint-project-extension.md)  
  
  