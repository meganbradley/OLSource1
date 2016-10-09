---
title: "Using the SharePoint Project Service"
ms.custom: na
ms.date: "08/09/2016"
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
  - "SharePoint development in Visual Studio, extensibility features"
ms.assetid: bfb6cbc7-6c28-4e1a-abb4-88f149e7712c
caps.latest.revision: 34
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
# Using the SharePoint Project Service
  The SharePoint project system includes a project service that you can use to perform tasks related to the project system. The project service is an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object.  
  
 You can access the SharePoint project service in any SharePoint tools extension. You can also access it in other types of Visual Studio extensions, such as add-ins and VSPackages. For more information, see [How to: Retrieve the SharePoint Project Service](../VS_officedev/how-to--retrieve-the-sharepoint-project-service.md).  
  
## Project Service Features  
 The following table lists the tasks that you can perform by using the SharePoint project service and the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> method or property to use to perform each task.  
  
|Task|Member to use|  
|----------|-------------------|  
|Access any SharePoint project that is open in Visual Studio.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Projects*> property.|  
|Access all of the SharePoint project item types that are available (including built-in and custom project item types).|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.ProjectItemTypes*> property.|  
|Access all of the deployment steps that are available to SharePoint projects (including built-in and custom deployment steps).|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.DeploymentSteps*> property.|  
|Access events that are raised when a developer refactors code in a SharePoint project.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.CodeRefactoringEvents*> property.|  
|Execute a custom *SharePoint command* that calls into the SharePoint server object model. For more information about SharePoint commands, see [Calling into the SharePoint Object Models](../VS_officedev/calling-into-the-sharepoint-object-models.md).|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.SharePointConnection*> property.|  
|Convert a type in the SharePoint project system to a type in the Visual Studio automation object model or integration object model, and vice versa. For more information, see [Converting Between SharePoint Project System Types and Other Visual Studio Project Types](../VS_officedev/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md).|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert*> method.|  
|Write messages to the **Output** window or **Error List** window in Visual Studio.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Logger*> property.|  
|Access other services that are available in Visual Studio.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.ServiceProvider*> property.|  
|Retrieve the path to the installation folder of the local SharePoint site that is used for debugging the solution.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.SharePointInstallPath*> property.|  
|Determine whether [!INCLUDE[moss_14_long](../VS_officedev/includes/moss_14_long_md.md)] or [!INCLUDE[wss_14_long](../VS_officedev/includes/wss_14_long_md.md)] is installed on the computer.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.IsSharePointInstalled*> property.|  
|Validate a feature or package in a SharePoint solution.|\<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.PackageValidationProvider*> property.|  
  
## See Also  
 [Converting Between SharePoint Project System Types and Other Visual Studio Project Types](../VS_officedev/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md)   
 [How to: Retrieve the SharePoint Project Service](../VS_officedev/how-to--retrieve-the-sharepoint-project-service.md)   
 [Extending the SharePoint Tools in Visual Studio](../VS_officedev/extending-the-sharepoint-tools-in-visual-studio.md)   
 [Overview of the Programming Model of SharePoint Tools Extensions](../VS_officedev/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)   
 [How to: Get a Service from the DTE Object](http://msdn.microsoft.com/library/bb166401.aspx)  
  
  