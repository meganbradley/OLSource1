---
title: "How to: Set SharePoint Deployment Commands"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, deploying"
ms.assetid: 289c8c33-a603-434e-889f-a0d0a1736ecb
caps.latest.revision: 12
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
# How to: Set SharePoint Deployment Commands
  You can customize the deployment process by setting pre-deployment and post-deployment commands. These commands run before and after other deployment actions when you debug SharePoint solutions from Visual Studio.  
  
### To add a pre-deployment command  
  
1.  On the menu bar, choose **Project**, *ProjectName***Properties**.  
  
2.  Choose the **SharePoint** tab.  
  
3.  In the **Pre-deployment Command Line** text box, enter MS-DOS or MSBuild commands to customize this step.  
  
     For example, to list the directory contents before deployment is completed, enter **dir**.  
  
### To add a post-deployment command  
  
1.  On the menu bar, choose **Project**, *ProjectName***Properties**.  
  
2.  Choose the **SharePoint** tab.  
  
3.  In the **Post-deployment Command Line** text box, enter MS-DOS or MSBuild commands to customize this step.  
  
     For example, to list the directory contents after deployment is completed, enter **dir**. To use a MSBuild variable to copy the assembly from the build directory, enter **copy $(TargetPath) c:\DeploymentDirectory**.  
  
## See Also  
 [Packaging and Deploying SharePoint Solutions](../VS_officedev/packaging-and-deploying-sharepoint-solutions.md)  
  
  