---
title: "MSBuild Error MSB3124"
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
  - "GenerateManifest.FileAssociationsDuplicateExtensions"
helpviewer_keywords: 
  - "MSB3124"
ms.assetid: d8365103-aa9d-400e-9c24-0a43e2bfbd14
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3124
**MSB3124: A file association has already been created for extension '\<extensionname>'.**  
  
 This error occurs when a duplicate file association extension is encountered.  
  
### To correct this error  
  
-   Remove [\<fileAssociation> Element](../vs140/clickonce-deployment-manifest.md)`extension` attributes that are not unique. Each listed \<fileAssociation> element's extension attributes must be unique.  
  
## See Also  
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)