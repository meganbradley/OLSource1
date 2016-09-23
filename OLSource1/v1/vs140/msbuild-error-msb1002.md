---
title: "MSBuild Error MSB1002"
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
  - MSBuild.UnexpectedParametersError
helpviewer_keywords: 
  - MSB1002
ms.assetid: 798c9690-6d99-4f21-a491-ab44d3f3c552
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB1002
**This switch does not take any parameters.**  
  
 Parameters cannot be defined for this switch. Only the name of the switch is required and it must not be followed by a colon.  
  
### To correct this error  
  
-   Type the command without parameters for this switch, that is, instead of typing `msbuild /<switch>:<parameters>`, type `msbuild /<switch>`  
  
-   Remove the colon after the name of the switch, that is, instead of typing `msbuild /<switch>:`, type `msbuild /<switch>`  
  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)