---
title: "push_macro"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc-pragma.push_macro
  - push_macro_CPP
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - pragmas, push_macro
  - push_macro pragma
ms.assetid: ac89efc9-afd1-4dfe-bfd1-497229b3e81d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# push_macro
Saves the value of the *macro_name* macro on the top of the stack for this macro.  
  
## Syntax  
  
```  
  
#pragma push_macro("  
macro_name  
")  
  
```  
  
## Remarks  
 You can retrieve the value for *macro_name* with **pop_macro**.  
  
 See [pop_macro](../vs140/pop_macro.md) for a sample.  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)