---
title: "MSBuild Error MSB1016"
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
  - "MSBuild.MissingVerbosityError"
helpviewer_keywords: 
  - "MSB1016"
ms.assetid: 967a9757-0513-48ae-bf1d-b1b019993c70
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB1016
**Specify the verbosity level.**  
  
 A verbosity level must be specified for the **/verbosity** switch.  
  
### To correct this error  
  
1.  Specify the verbosity level using the format <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. The available verbosity levels are: q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic], for example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)