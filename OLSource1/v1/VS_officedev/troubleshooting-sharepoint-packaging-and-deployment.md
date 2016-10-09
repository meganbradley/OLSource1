---
title: "Troubleshooting SharePoint Packaging and Deployment"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VSTO.WorkflowDeployment.Troubleshooting"
  - "VS.SharePointTools.Project.PackageRetraction"
  - "VS.SharePointTools.Deployment.Troubleshooting"
  - "VS.SharePointTools.Deploying.Troubleshooting"
  - "VS.SharePointTools.Project.DeploymentTroubleshooting"
  - "VS.SharePointTools.Project.SharePointNotInstalled"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, packaging"
  - "SharePoint development in Visual Studio, troubleshooting"
  - "SharePoint development in Visual Studio, deployment conflict resolution"
ms.assetid: eff72675-59e6-4395-bc80-4255da77f523
caps.latest.revision: 25
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Troubleshooting SharePoint Packaging and Deployment
  This topic covers various problems that you might encounter when you package and deploy SharePoint solutions.  
  
 [!INCLUDE[autoOutline](../Token/autoOutline_md.md)]  
  
## Enabling Enhanced Debugging  
 To diagnose between Visual Studio, SharePoint, and other layers, you can use the EnableDiagnostics registry key to view the stack trace. For more information, see [Debugging SharePoint Solutions](../VS_officedev/debugging-sharepoint-solutions.md).  
  
## Adding Project Output to the Solution Package  
 You can add the project output to a package through the Package Designer. However, when you add the project output, make sure that the platform of the project matches the platform of the SharePoint solution. We recommend that you use the **Any CPU** platform target for the assemblies that you want to deploy to a SharePoint server. For more information, see [Compile Page, Project Designer &#40;Visual Basic&#41;](../Topic/Compile%20Page,%20Project%20Designer%20(Visual%20Basic).md) and [Advanced Compiler Settings Dialog Box &#40;Visual Basic&#41;](../Topic/Advanced%20Compiler%20Settings%20Dialog%20Box%20(Visual%20Basic).md).  
  
## Validation Warnings and Errors  
 The SharePoint development tools in Visual Studio perform validation steps to verify that the solution package is correctly formed. You can also create custom validation steps for your Features and packages. For more information, see [How to: Create Custom Feature and Package Validation Rules for SharePoint Solutions](../VS_officedev/how-to--create-custom-feature-and-package-validation-rules-for-sharepoint-solutions.md).  
  
## Deployment Conflict Resolution  
 When you deploy a SharePoint solution, you may find collisions when an item on the server has the same name, URL, or ID as an item in your solution package. You can change the **Deployment Conflict Resolution** property to resolve, report, or ignore collisions for modules, Web parts, list instances, and content types.  
  
 The following table demonstrates the settings for the **Deployment Conflict Resolution** property.  
  
|Value|Description|  
|-----------|-----------------|  
|Automatic|Detects collisions and resolves the conflicts automatically.|  
|Prompt|Detects collisions and reports them to the developer before resolving the conflicts.|  
|None|Does not detect collisions.|  
  
## Differences between F5 Deployment  
 When you use [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] to deploy your SharePoint project to the local SharePoint server for testing and debugging, there are some additional steps that are performed by [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
1.  Reset the Internet Information Service (IIS) during the deployment step.  
  
2.  Automatically associate workflows.  
  
3.  Set the feature activation order according to the hierarchy in the Package Designer.  
  
 You can add custom deployment steps to further change the F5 behavior. For more information, see [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../VS_officedev/walkthrough--creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
## Delay Displaying SharePoint Page When Deploying Visual Web Part  
 The SharePoint page takes a long time to appear when deploying a Visual Web part to the Bin folder on [!INCLUDE[wiprlhext](../VS_officedev/includes/wiprlhext_md.md)], [!INCLUDE[win7](../VS_officedev/includes/win7_md.md)], or [!INCLUDE[winsvr08](../VS_officedev/includes/winsvr08_md.md)]. If you change any files in a top-level [!INCLUDE[vstecasp](../VS_officedev/includes/vstecasp_md.md)] directory, such as the Bin directory, the entire Web application recompiles. This can cause a delay of up to 25 seconds for the SharePoint page to render.  
  
### Error Message  
 None.  
  
### Resolution  
 To work around this problem, perform the following steps:  
  
1.  Install update KB967535 as outlined in the Microsoft Support article [FIX: A hotfix is available to fix two problems in ASP.NET on IIS 7.0 for Windows Vista and Windows Server 2008](http://go.microsoft.com/fwlink/?LinkId=179055).  
  
2.  Add the following line to the Web.config file:  
  
    ```  
    <compilation batch="false" optimizeCompilations="true">  
    ```  
  
## SharePoint Project Deployment Fails With Error "Failed to extract the cab file in the solution"  
 If the name of any SharePoint project item contains parentheses, its solution fails on deployment with an error.  
  
### Error Message  
 Error occurred in deployment step 'Add Solution': Failed to extract the cab file in the solution.  
  
### Resolution  
 To work around this problem, remove any parentheses in the names of SharePoint project items.  
  
## Error Appears When Deploying a Visual Web Part to a Site On a Different Web Application  
 The first time that you deploy a visual Web part to a site on a Web application other than the one on which it is currently deployed (by changing the visual Web part's SiteUrl property), you get an error.  
  
### Error Message  
 Error occurred in deployment step 'Add Solution': A feature with ID [#] has already been installed in this farm. Use the force attribute to explicitly re-install the feature.  
  
### Resolution  
 This error occurs due to the way visual Web part features are retracted in SharePoint. To successfully deploy the visual Web part, deploy the solution again by choosing the F5 key.  
  
## Warning Appears When Deploying Nested User Controls  
 This warning occurs when you deploy a SharePoint solution that has nested user controls, such as a visual Web part that contains a user control or a user control that contains a visual Web part or another user control. This warning occurs whether you add a control to a designer by dragging it from the Toolbox or by using the @Register directive in the Source view.  
  
### Error Message  
 Warning 1 Element '[*Control Name*]' is not a known element. This can occur if there is a compilation error in the Web site, or the web.config file is missing.  
  
### Resolution  
 If the [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] project system is not aware of a nested user control, it cannot provide Intellisense and it emits the warning. The project system is unaware of a nested user control if the project is not built and the designer is not closed and re-opened, or if the auto-retract option is enabled, which causes the user control to be retracted from the SharePoint hive after debugging.  
  
 To remove this warning, either build the project and then close and then reopen the designer, or disable the auto-retract option for the project. To do this, clear the **Auto-retract after debugging** check box on the **SharePoint** tab of the project properties dialog box.  
  
## See Also  
 [Packaging and Deploying SharePoint Solutions](../VS_officedev/packaging-and-deploying-sharepoint-solutions.md)  
  
  