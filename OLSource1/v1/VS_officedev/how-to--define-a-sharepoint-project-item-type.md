---
title: "How to: Define a SharePoint Project Item Type"
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
ms.assetid: 18b56e7c-4efb-47a2-abfc-e9018ae38267
caps.latest.revision: 28
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
# How to: Define a SharePoint Project Item Type
  Define a project item type when you want to create a custom SharePoint project item. For more information, see [Defining Custom SharePoint Project Item Types](../VS_officedev/defining-custom-sharepoint-project-item-types.md).  
  
### To define a project item type  
  
1.  Create a class library project.  
  
2.  Add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.SharePoint  
  
    -   System.ComponentModel.Composition  
  
3.  Create a class that implements the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface.  
  
4.  Add the following attributes to the class:  
  
    -   \<xref:System.ComponentModel.Composition.ExportAttribute>. This attribute enables Visual Studio to discover and load your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation. Pass the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> type to the attribute constructor.  
  
    -   \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute>. In a project item type definition, this attribute specifies the string identifier for the new project item. We recommend that you use the format *company name*.*feature name* to help make sure that all project items have a unique name.  
  
    -   \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemIconAttribute>. This attribute specifies the icon to display for this project item in **Solution Explorer**. This attribute is optional; if you do not apply it to your class, Visual Studio displays a default icon for your project item. If you set this attribute, pass the fully qualified name of an icon or bitmap that is embedded in your assembly.  
  
5.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType*> method, use members of the *projectItemTypeDefinition* parameter to define the behavior of the project item type. This parameter is an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition> object that provides access to the events defined in the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFileEvents> interfaces. To access a specific instance of your project item type, handle \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents> events such as \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemAdded> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemInitialized>.  
  
## Example  
 The following code example demonstrates how to define a simple project item type. This project item type writes a message to the **Output** window and **Error List** window when a user adds a project item of this type to a project.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#2](../VS_officedev/codesnippet/VisualBasic/how-to--define-a-sharepoint-project-item-type_1.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#2](../VS_officedev/codesnippet/CSharp/how-to--define-a-sharepoint-project-item-type_1.cs)]  
  
 This example uses the SharePoint project service to write the message to the **Output** window and **Error List** window. For more information, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Project Item  
 To enable other developers to use your project item, create a project template or a project item template. For more information, see [Creating Item Templates and Project Templates for SharePoint Project Items](../VS_officedev/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).  
  
 To deploy the project item, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly, the template, and any other files that you want to distribute with the project item. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Defining Custom SharePoint Project Item Types](../VS_officedev/defining-custom-sharepoint-project-item-types.md)   
 [Creating Item Templates and Project Templates for SharePoint Project Items](../VS_officedev/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)   
 [Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 1](../VS_officedev/walkthrough--creating-a-custom-action-project-item-with-an-item-template--part-1.md)   
 [Walkthrough: Creating a Site Column Project Item with a Project Template, Part 1](../VS_officedev/walkthrough--creating-a-site-column-project-item-with-a-project-template--part-1.md)   
 [How to: Add a Property to a Custom SharePoint Project Item Type](../VS_officedev/how-to--add-a-property-to-a-custom-sharepoint-project-item-type.md)   
 [How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type](../VS_officedev/how-to--add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type.md)  
  
  