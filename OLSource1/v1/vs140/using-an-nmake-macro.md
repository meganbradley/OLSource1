---
title: "Using an NMAKE Macro"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "macros, NMAKE"
  - "NMAKE macros, using"
ms.assetid: 95c87fbc-76e6-48c0-8536-9bfe179f328e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using an NMAKE Macro
To use a macro, enclose its name in parentheses preceded by a dollar sign ($) as follows.  
  
## Syntax  
  
```  
$(macroname)  
```  
  
## Remarks  
 No spaces are allowed. The parentheses are optional if *macroname* is a single character. The definition string replaces $(*macroname*); an undefined macro is replaced by a null string.  
  
## What do you want to know more about?  
 [Macro substitution](../vs140/macro-substitution.md)  
  
## See Also  
 [Macros and NMAKE](../vs140/macros-and-nmake.md)