---
title: "modf Function (fast_math)"
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
  - amp_math/Concurrency::fast_math::modf
dev_langs: 
  - C++
ms.assetid: bcaee455-243c-419d-af92-8de5253f0662
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# modf Function (fast_math)
Splits _X into fractional and integer parts.  
  
## Syntax  
  
```  
inline float modf(  
   float _X,  
   float * _Ip  
) restrict(amp);  
  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Ip`  
  
## Return Value  
 Returns the signed fractional portion of _X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)