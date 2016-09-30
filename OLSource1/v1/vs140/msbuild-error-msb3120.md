---
title: "MSBuild Error MSB3120"
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
  - "GenerateManifest.FileAssociationExtensionTooLong"
helpviewer_keywords: 
  - "MSB3120"
ms.assetid: 20bc64f5-aadc-4eec-9915-a87a3d7f81ea
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3120
**MSB3120: File association extension '\<extension>' exceeds the maximum allowed length of \<maximumlength>.**  
  
 The number of characters in the file association extension must not exceed the indicated number.  
  
### To correct this error  
  
-   Set the [\<fileAssociation> Element](../vs140/clickonce-deployment-manifest.md)<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> attribute to a value that does not contain more characters than the allowed limit for the target operating system.  
  
## See Also  
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)