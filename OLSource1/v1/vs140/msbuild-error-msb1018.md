---
title: "MSBuild Error MSB1018"
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
  - "MSBuild.InvalidVerbosityError"
helpviewer_keywords: 
  - "MSB1018"
ms.assetid: fb4deacc-a799-44e8-8980-d70d9da4caa1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB1018
**Verbosity level is not valid.**  
  
 The verbosity level specified is not one of the available verbosity levels.  
  
### To correct this error  
  
1.  Check the spelling of the verbosity level. The available verbosity levels are: q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic], for example, `/verbosity:quiet`, `/verbosity:q`, or `/v:q`  
  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)   
 [How To: Write a Logger](../vs140/build-loggers.md)