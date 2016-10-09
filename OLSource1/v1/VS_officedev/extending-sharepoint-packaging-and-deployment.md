---
title: "Extending SharePoint Packaging and Deployment"
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
ms.assetid: 4789ebb2-12bc-42b9-9427-e63d77137765
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
# Extending SharePoint Packaging and Deployment
  You can extend the packaging and deployment process for SharePoint projects.  
  
 [!INCLUDE[autoOutline](../Token/autoOutline_md.md)]  
  
##  <a name="creating_deployment_steps"></a> Creating Deployment Steps  
 When you deploy a SharePoint project, [!INCLUDE[vs_current_short](../VS_officedev/includes/vs_current_short_md.md)] executes a series of deployment steps. Visual Studio includes built-in deployment steps for many tasks, such as retracting and adding solutions. However, you can also create your own deployment steps.  
  
 For a walkthrough that demonstrates how to create a deployment step, see [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../VS_officedev/walkthrough--creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
##  <a name="creating_deployment_configurations"></a> Creating Deployment Configurations  
 A deployment configuration is a set of deployment steps that is executed for a given project but can affect all SharePoint project items. Every deployment configuration includes one set of steps that is executed when the project is deployed, and another set that is executed when the project is retracted. [!INCLUDE[vs_current_short](../VS_officedev/includes/vs_current_short_md.md)] includes two built-in deployment configurations, but you can also create your own. When you create a deployment configuration, you can include built-in deployment steps and deployment steps that you create.  
  
 For a walkthrough that demonstrates how to create a deployment configuration, see [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../VS_officedev/walkthrough--creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
##  <a name="run_code_before_and_after_each_deployment_step"></a> Run Code When a SharePoint Solution is Deployed or Retracted  
 You can handle events to perform additional tasks when a SharePoint solution is deployed or retracted. Visual Studio raises events that you can handle in the following scenarios:  
  
-   Before and after each deployment step is executed for a SharePoint project item. For more information, see [How to: Run Code When Deployment Steps are Executed](../VS_officedev/how-to--run-code-when-deployment-steps-are-executed.md).  
  
-   Before and after a SharePoint project is deployed or retracted. For more information, see [How to: Run Code When a SharePoint Project is Deployed or Retracted](../VS_officedev/how-to--run-code-when-a-sharepoint-project-is-deployed-or-retracted.md).  
  
##  <a name="deployment_conflicts"></a> Handling Deployment Conflicts  
 Some types of SharePoint project items, including modules, Web parts, list instances, and content types, provide built-in deployment conflict resolution. When you deploy a solution that contains one of these project items, Visual Studio first checks whether a file already exists on the SharePoint site with the same name, URL, or ID as a file in the item you are deploying. If a conflict exists, Visual Studio can automatically resolve the conflict, or it can prompt you to determine whether you want to have Visual Studio resolve the conflict or cancel the deployment. For more information, see [Troubleshooting SharePoint Packaging and Deployment](../VS_officedev/troubleshooting-sharepoint-packaging-and-deployment.md).  
  
 You can extend this feature by providing your own code that checks for and resolves deployment conflicts. For more information, see [How to: Handle Deployment Conflicts](../VS_officedev/how-to--handle-deployment-conflicts.md).  
  
##  <a name="run_command_line_operations_before_or_after_a_project_is_deployed"></a> Run Command Line Operations Before or After a Project is Deployed  
 If you want to run a command line operation when a SharePoint solution is deployed, you can set the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.PreDeploymentCommand*> and \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.PostDeploymentCommand*> properties of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object. Visual Studio executes these commands before and after the project is deployed.  
  
 In some cases, you may see deployment conflicts. There are several different ways to resolve conflicts. For more information, see [Troubleshooting SharePoint Packaging and Deployment](../VS_officedev/troubleshooting-sharepoint-packaging-and-deployment.md).  
  
##  <a name="customizing_validation_rules"></a> Customizing Validation Rules  
 Before you deploy a solution package (.wsp), you can create custom Feature and package validation rules to verify that the Feature or package is valid. For example, you can report information, warnings, or errors to developers to help them fix validation problems. For more information, see [How to: Create Custom Feature and Package Validation Rules for SharePoint Solutions](../VS_officedev/how-to--create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).  
  
## See Also  
 [How to: Run Code When Deployment Steps are Executed](../VS_officedev/how-to--run-code-when-deployment-steps-are-executed.md)   
 [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../VS_officedev/walkthrough--creating-a-custom-deployment-step-for-sharepoint-projects.md)   
 [How to: Create Custom Feature and Package Validation Rules for SharePoint Solutions](../VS_officedev/how-to--create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md)   
 [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md)  
  
  