---
title: "How to: Handle Deployment Conflicts"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, extending deployment"
ms.assetid: 8e545873-3fed-46cf-a95f-27b5fc0d5f83
caps.latest.revision: 14
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
# How to: Handle Deployment Conflicts
  You can provide your own code to handle deployment conflicts for a SharePoint project item. For example, you might determine whether any files in the current project item already exist in the deployment location, and then delete the deployed files before the current project item is deployed. For more information about deployment conflicts, see [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md).  
  
### To handle a deployment conflict  
  
1.  Create a project item extension, a project extension, or a definition of a new project item type. For more information, see the following topics:  
  
    -   [How to: Create a SharePoint Project Item Extension](../VS_officedev/how-to--create-a-sharepoint-project-item-extension.md)  
  
    -   [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md)  
  
    -   [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md)  
  
2.  In the extension, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> event of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType> object (in a project item extension or project extension) or an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition> object (in a definition of a new project item type).  
  
3.  In the event handler, determine whether there is a conflict between the project item that is being deployed and the deployed solution on the SharePoint site, based on criteria that apply to your scenario. You can use the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemEventArgs.ProjectItem*> property of the event arguments parameter to analyze the project item that is being deployed, and you can analyze the files at the deployment location by calling a SharePoint command that you define for this purpose.  
  
     For many types of conflicts, you might first want to determine which deployment step is executing. You can do this by using the \<xref:Microsoft.VisualStudio.SharePoint.DeploymentStepStartedEventArgs.DeploymentStepInfo*> property of the event arguments parameter. Although it typically makes sense to detect conflicts during the built-in \<xref:Microsoft.VisualStudio.SharePoint.Deployment.DeploymentStepIds.AddSolution> deployment step, you can check for conflicts during any deployment step.  
  
4.  If a conflict exists, use the \<xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentConflictCollection.Add*> method of the \<xref:Microsoft.VisualStudio.SharePoint.DeploymentStepStartedEventArgs.Conflicts*> property of the event arguments to create a new \<xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentConflict> object. This object represents the deployment conflict. In your call to the \<xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentConflictCollection.Add*> method, also specify the method that is called to resolve the conflict.  
  
## Example  
 The following code example demonstrates the basic process for handling a deployment conflict in a project item extension for list definition project items. To handle a deployment conflict for a different type of project item, pass a different string to the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute>. For more information, see [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md).  
  
 For simplicity, the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> event handler in this example assumes that a deployment conflict exists (that is, it always adds a new \<xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentConflict> object), and the `Resolve` method simply returns **true** to indicate that the conflict was resolved. In a real scenario, your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.DeploymentStepStarted> event handler would first determine if a conflict exists between a file in the current project item and a file at the deployment location, and then add an \<xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentConflict> object only if a conflict exists. For example, you might use the `e.ProjectItem.Files` property in the event handler to analyze the files in the project item, and you might call a SharePoint command to analyze the files at the deployment location. Similarly, in a real scenario the `Resolve` method might call a SharePoint command to resolve the conflict on the SharePoint site. For more information about creating SharePoint commands, see [How to: Create a SharePoint Command](../VS_officedev/how-to--create-a-sharepoint-command.md).  
  
 [!code[SPExtensibility.ProjectItemExtension.DeploymentConflict#1](../VS_officedev/codesnippet/VisualBasic/how-to--handle-deployment-conflicts_1.vb)]
[!code[SPExtensibility.ProjectItemExtension.DeploymentConflict#1](../VS_officedev/codesnippet/CSharp/how-to--handle-deployment-conflicts_1.cs)]  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md)   
 [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md)   
 [How to: Run Code When Deployment Steps are Executed](../VS_officedev/how-to--run-code-when-deployment-steps-are-executed.md)   
 [How to: Create a SharePoint Command](../VS_officedev/how-to--create-a-sharepoint-command.md)  
  
  