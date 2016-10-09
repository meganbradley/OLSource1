---
title: "How to: Run Code When Deployment Steps are Executed"
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
ms.assetid: 6b0a52e5-e0ba-41bc-9e8a-1013e51fd3ba
caps.latest.revision: 21
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
# How to: Run Code When Deployment Steps are Executed
  If you want to perform additional tasks for a deployment step in a SharePoint project, you can handle events that are raised by SharePoint project items before and after Visual Studio executes each deployment step. For more information, see [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md).  
  
### To run code when deployment steps are executed  
  
1.  Create a project item extension, a project extension, or a definition of a new project item type. For more information, see the following topics:  
  
    -   [How to: Create a SharePoint Project Item Extension](../VS_officedev/how-to--create-a-sharepoint-project-item-extension.md)  
  
    -   [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md)  
  
    -   [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md)  
  
2.  In the extension, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepCompleted> events of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType> object (in a project item extension or project extension) or an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition> object (in a definition of a new project item type).  
  
3.  In the event handlers, use the \<xref:Microsoft.VisualStudio.SharePoint.DeploymentStepStartedEventArgs> and \<xref:Microsoft.VisualStudio.SharePoint.DeploymentStepCompletedEventArgs> parameters to get information about the deployment step. For example, you can determine which deployment step is executing and whether the solution is being deployed or retracted.  
  
## Example  
 The following code example demonstrates how to handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepCompleted> events in an extension for the List Instance project item. This extension writes an additional message to the **Output** window when Visual Studio recycles the application pool while deploying and retracting the solution.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#4](../VS_officedev/codesnippet/VisualBasic/how-to--run-code-when-deployment-steps-are-executed_1.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#4](../VS_officedev/codesnippet/CSharp/how-to--run-code-when-deployment-steps-are-executed_1.cs)]  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md)   
 [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../VS_officedev/walkthrough--creating-a-custom-deployment-step-for-sharepoint-projects.md)   
 [How to: Run Code When a SharePoint Project is Deployed or Retracted](../VS_officedev/how-to--run-code-when-a-sharepoint-project-is-deployed-or-retracted.md)  
  
  