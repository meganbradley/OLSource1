---
title: "How to: Run Code When a SharePoint Project is Deployed or Retracted"
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
  - "SharePoint development in Visual Studio, extending deployment"
ms.assetid: 353bbe6d-9b76-48ad-9fba-7e3c3712452f
caps.latest.revision: 5
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
# How to: Run Code When a SharePoint Project is Deployed or Retracted
  If you want to perform additional tasks when a SharePoint project is deployed or retracted, you can handle events that are raised by Visual Studio. For more information, see [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md).  
  
### To run code when a SharePoint project is deployed or retracted  
  
1.  Create a project item extension, a project extension, or a definition of a new project item type. For more information, see the following topics:  
  
    -   [How to: Create a SharePoint Project Item Extension](../VS_officedev/how-to--create-a-sharepoint-project-item-extension.md)  
  
    -   [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md)  
  
    -   [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md)  
  
2.  In the extension, access the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object. For more information, see [How to: Retrieve the SharePoint Project Service](../VS_officedev/how-to--retrieve-the-sharepoint-project-service.md).  
  
3.  Handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentStarted> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentCompleted> events of the project service.  
  
4.  In the event handlers, use the \<xref:Microsoft.VisualStudio.SharePoint.DeploymentEventArgs> parameter to get information about the current deployment session. For example, you can determine which project is in the current deployment session and whether it is being deployed or retracted.  
  
 The following code example demonstrates how to handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentStarted> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.DeploymentCompleted> events in a project extension. This extension writes an additional message to the **Output** window when deployment starts and completes for a SharePoint project.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#12](../VS_officedev/codesnippet/CSharp/how-to--run-code-when-a-sharepoint-project-is-deployed-or-retracted_1.cs)]
[!code[SPExtensibility.ProjectSystemExtension.General#12](../VS_officedev/codesnippet/VisualBasic/how-to--run-code-when-a-sharepoint-project-is-deployed-or-retracted_1.vb)]  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md)   
 [How to: Run Code When Deployment Steps are Executed](../VS_officedev/how-to--run-code-when-deployment-steps-are-executed.md)  
  
  