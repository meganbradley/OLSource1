---
title: "&lt;limits&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.<limits>"
  - "std::<limits>"
  - "limits/std::<limits>"
  - "<limits>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "limits header"
ms.assetid: e07d6379-5b00-4a3d-a789-40d41538b59e
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;limits&gt;
Defines the template class `numeric_limits` and two enumerations concerning floating-point representations and rounding.  
  
## Syntax  
  
```  
#include <limits>  
  
```  
  
## Remarks  
 Explicit specializations of the `numeric_limits` class describe many properties of the fundamental types, including the character, integer, and floating-point types and `bool` that are implementation defined rather than fixed by the rules of the C++ language. Properties described in <limits\> include accuracy, minimum and maximum sized representations, rounding, and signaling type errors.  
  
### Enumerations  
  
|||  
|-|-|  
|[float_denorm_style](../vs140/-limits--enums.md#float_denorm_style_enumeration)|The enumeration describes the various methods that an implementation can choose for representing a denormalized floating-point value — one too small to represent as a normalized value:|  
|[float_round_style](../vs140/-limits--enums.md#float_round_style_enumeration)|The enumeration describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.|  
  
### Classes  
  
|||  
|-|-|  
|[numeric_limits Class](../vs140/numeric_limits-class.md)|The template class describes arithmetic properties of built-in numerical types.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)