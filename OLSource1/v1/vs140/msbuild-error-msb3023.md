---
title: "MSBuild Error MSB3023"
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
  - "MSBuild.Copy.NeedsDestination"
helpviewer_keywords: 
  - "MSB3023"
ms.assetid: 3505ad1e-d54f-4cb4-a299-ac03684cb391
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3023
**No destination specified for Copy. Please supply either "'\<attribute>'" or "'\<attribute>'".**  
  
 A destination must be specified for the `Copy` task using one of the task attributes `DestinationFiles`and`DestinationDirectory`.  
  
### To correct this error  
  
-   Specify either `DestinationFiles`or`DestinationDirectory`for the `Copy` task.  
  
## See Also  
 [Copy Task](../vs140/copy-task.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)