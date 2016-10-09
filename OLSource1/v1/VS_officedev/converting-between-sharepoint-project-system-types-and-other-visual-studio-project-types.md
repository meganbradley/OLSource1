---
title: "Converting Between SharePoint Project System Types and Other Visual Studio Project Types"
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
  - "SharePoint project service"
ms.assetid: ad5d8ab2-1659-4e6a-8783-47e0dad44b11
caps.latest.revision: 13
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
# Converting Between SharePoint Project System Types and Other Visual Studio Project Types
  In some cases you might have an object in the SharePoint project system and you want to use features of a corresponding object in the Visual Studio automation object model or integration object model, or vice versa. In these cases, you can use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert*> method of the SharePoint project service to convert the object to a different object model.  
  
 For example, you might have an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object, but you want to use methods that are only available on an \<xref:EnvDTE.Project> or \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject> object. In this case, you can use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert*> method to convert the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> to an \<xref:EnvDTE.Project> or \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject>.  
  
 For more information about the Visual Studio automation object model and the Visual Studio integration object model, see [Overview of the Programming Model of SharePoint Tools Extensions](../VS_officedev/overview-of-the-programming-model-of-sharepoint-tools-extensions.md).  
  
## Types of Conversions  
 The following table lists the types that this method can convert between the SharePoint project system and the other Visual Studio object models.  
  
|SharePoint project system type|Corresponding types in the automation and integration object models|  
|------------------------------------|-------------------------------------------------------------------------|  
|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject>|\<xref:EnvDTE.Project><br /><br /> or<br /><br /> Any interface in the Visual Studio integration object model that is implemented by the underlying COM object for the project. These interfaces include \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>, \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject> (or a derived interface), and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage>. For a list of the main interfaces that are implemented by projects, see [Project Model Core Components](../Topic/Project%20Model%20Core%20Components.md).|  
|\<xref:Microsoft.VisualStudio.SharePoint.IMappedFolder><br /><br /> \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem><br /><br /> \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFile><br /><br /> \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectFeature><br /><br /> \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectFeatureResourceFile><br /><br /> \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectPackage>|\<xref:EnvDTE.ProjectItem><br /><br /> or<br /><br /> A\<xref:System.UInt32> value (also called a VSITEMID) that identifies the project member in the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> that contains it. This value can be passed to the *itemid* parameter of some \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> methods.|  
  
## Example  
 The following code example demonstrates how to use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert*> method to convert an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object to an \<xref:EnvDTE.Project>.  
  
 [!code[SPExtensibility.ProjectService.FromDTE#2](../VS_officedev/codesnippet/CSharp/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types_1.cs)]
[!code[SPExtensibility.ProjectService.FromDTE#2](../VS_officedev/codesnippet/VisualBasic/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types_1.vb)]  
  
 This example requires:  
  
-   An extension of the SharePoint project system that has a reference to the EnvDTE.dll assembly. For more information, see [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md).  
  
-   Code that registers the `projectService_ProjectAdded` method to handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectAdded> event of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object. For an example, see [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md).  
  
## See Also  
 [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md)   
 [How to: Retrieve the SharePoint Project Service](../VS_officedev/how-to--retrieve-the-sharepoint-project-service.md)   
 [Overview of the Programming Model of SharePoint Tools Extensions](../VS_officedev/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)  
  
  