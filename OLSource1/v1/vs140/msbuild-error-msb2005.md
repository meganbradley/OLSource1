---
title: "MSBuild Error MSB2005"
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
  - "MSBuild.NoRootProjectElement"
helpviewer_keywords: 
  - "MSB2005"
ms.assetid: 62db2963-3811-4a92-8f4d-ff9145cb53ef
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB2005
**Element <{0}> cannot contain attributes.**  
  
 The element specified in the message cannot contain attributes.  
  
### To correct this error  
  
-   Delete the attributes from the specified element.  
  
-   Check whether the project file has been modified or corrupted. If it has been modified or corrupted, open the project in the version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in which it was created, save it, and then attempt to convert it again.  
  
## See Also  
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)