---
title: "MSBuild Error MSB3181"
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
  - MSBuild.GenerateManifest.DuplicateTargetPath
helpviewer_keywords: 
  - MSB3181
ms.assetid: 49349fc2-3fa1-470d-a5cb-6ad72b93f408
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3181
**MSB3181: Two or more files have the same target path '<path\>'.**  
  
 This warning is generated during application manifest generation when two or more of the referenced assemblies or files share the same target path. The path includes the file name and all these assemblies will overwrite each other at deployment time.  
  
## See Also  
 [<PackageFiles\> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)