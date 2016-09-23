---
title: "isfinite Function (fast_math)"
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
  - amp_math/Concurrency::fast_math::isfinite
dev_langs: 
  - C++
helpviewer_keywords: 
  - fast_isfinite function
ms.assetid: 47061f49-f6d4-4c33-8bdf-96bd4f908c78
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# isfinite Function (fast_math)
Determines whether the argument has a finite value  
  
## Syntax  
  
```  
inline int isfinite(  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns a nonzero value if and only if the argument has a finite value  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)