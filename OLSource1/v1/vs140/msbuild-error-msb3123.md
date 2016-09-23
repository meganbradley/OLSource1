---
title: "MSBuild Error MSB3123"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - GenerateManifest.FileAssociationsCountExceedsMaximum
helpviewer_keywords: 
  - MSB3123
ms.assetid: 343aa8a8-9ab9-4dd5-be59-8eccf1f3c012
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3123
**MSB3123: The number of file associations exceeds the limit of <limit\>.**  
  
 Each file is allowed only a fixed number of associated file name extensions. This error occurs when you try to associate more file name extensions than the number allowed for the target operating system.  
  
### To correct this error  
  
-   Limit the number of file associations to the specified number.  
  
## See Also  
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)