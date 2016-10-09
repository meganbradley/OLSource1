---
title: "How to: Create a SharePoint Project Item Extension"
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
ms.assetid: 163738b9-e25a-49c9-8f33-4b57a2da6b07
caps.latest.revision: 31
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
# How to: Create a SharePoint Project Item Extension
  Create a project item extension when you want to add functionality to a SharePoint project item that is already installed in Visual Studio. For more information, see [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md).  
  
### To create a project item extension  
  
1.  Create a class library project.  
  
2.  Add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.SharePoint  
  
    -   System.ComponentModel.Composition  
  
3.  Create a class that implements the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> interface.  
  
4.  Add the following attributes to the class:  
  
    -   \<xref:System.ComponentModel.Composition.ExportAttribute>. This attribute enables Visual Studio to discover and load your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> implementation. Pass the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> type to the attribute constructor.  
  
    -   \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute>. In a project item extension, this attribute identifies the project item you want to extend. Pass the ID of the project item to the attribute constructor. For a list of the IDs of the project items that are included with Visual Studio, see [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md).  
  
5.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize*> method, use members of the *projectItemType* parameter to define the behavior of your extension. This parameter is an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType> object that provides access to the events defined in the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFileEvents> interfaces. To access a specific instance of the project item type you are extending, handle \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> events such as \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemAdded> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemInitialized>.  
  
## Example  
 The following code example demonstrates how to create a simple extension for the Event Receiver project item. Each time the user adds an Event Receiver project item to a SharePoint project, this extension writes a message to the **Output** window and **Error List** window.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#1](../VS_officedev/codesnippet/CSharp/how-to--create-a-sharepoint-project-item-extension_1.cs)]
[!code[SPExtensibility.ProjectSystemExtension.General#1](../VS_officedev/codesnippet/VisualBasic/how-to--create-a-sharepoint-project-item-extension_1.vb)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window and **Error List** window. For more information, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md)   
 [Walkthrough: Extending a SharePoint Project Item Type](../VS_officedev/walkthrough--extending-a-sharepoint-project-item-type.md)  
  
  