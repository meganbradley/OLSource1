---
title: "MSBuild Error MSB3072"
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
  - "MSBuild.Exec.MissingCommandError"
helpviewer_keywords: 
  - "MSB3072"
ms.assetid: c8468e1c-d8c7-441c-b274-123ac856f147
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3072
**The "Exec" task needs a command to execute.**  
  
 The attribute `Command` is a required attribute for the `Exec` task.  
  
### To correct this error  
  
1.  In the project file, specify the attribute `Command` for the `Exec` task.  
  
## See Also  
 [Exec Task](../vs140/exec-task.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)