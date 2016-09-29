---
title: "MSBuild Error MSB3122"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "GenerateManifest.FileAssociationsApplicationNotFullTrust"
helpviewer_keywords: 
  - "MSB3122"
ms.assetid: 523e4160-f165-437a-9f19-fb2ec77d46f5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3122
**MSB3122: Use of file associations requires full trust.**  
  
 Publishing an application that configures file associations requires that the application be a full trust application.  
  
### To correct this error  
  
-   Enable ClickOnce security settings and set the application to a full trust application. For more information, see [How to: Enable ClickOnce Security Settings](../vs140/how-to--enable-clickonce-security-settings.md).  
  
## See Also  
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)   
 [Code Access Security for ClickOnce Applications](../vs140/code-access-security-for-clickonce-applications.md)