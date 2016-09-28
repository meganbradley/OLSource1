---
title: "Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.interop_unsupported_x64"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: e4b0216c-7006-4832-883f-08e982ba8d3f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater
To debug mixed native and managed code in a 64-bit process, you must have [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] version 4. Mixed-mode debugging of 64-bit processes with [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] versions earlier than 4 is not supported.  
  
### To correct this error  
  
-   Perform one of the following steps:  
  
    -   Upgrade your [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] to version 4.  
  
    -   Build a 32-bit version of your application for debugging.  
  
## See Also  
 [How to: Set Up Remote Debugging](../vs140/set-up-the-remote-tools-on-the-device.md)