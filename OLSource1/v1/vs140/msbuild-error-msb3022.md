---
title: "MSBuild Error MSB3022"
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
  - "MSBuild.Copy.ExactlyOneTypeOfDestination"
helpviewer_keywords: 
  - "MSB3022"
ms.assetid: 74ebcced-8a56-4502-8fef-43d36c79a640
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3022
**Both "'\<attribute>'" and "'\<attribute>'" were specified as input parameters in the project file. Please choose one or the other.**  
  
 For the `Copy` task, you must specify either `DestinationFiles` or `DestinationDirectory`,but not both task attributes.  
  
### To correct this error  
  
-   Specify either `DestinationFiles` or `DestinationDirectory` for the `Copy` task in the project file.  
  
## See Also  
 [Copy Task](../vs140/copy-task.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)