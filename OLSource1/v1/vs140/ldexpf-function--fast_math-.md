---
title: "ldexpf Function (fast_math)"
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
  - amp_math/Concurrency::fast_math::ldexpf
dev_langs: 
  - C++
ms.assetid: d3e46d8a-1b8b-4534-8ef4-2e7becd31ca0
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ldexpf Function (fast_math)
Computes a real number from the mantissa and exponent  
  
## Syntax  
  
```  
inline float ldexpf(  
   float _X,  
   int _Exp  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value, mentissa  
  
 `_Exp`  
 Integer exponent  
  
## Return Value  
 Returns _X * 2^_Exp  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)