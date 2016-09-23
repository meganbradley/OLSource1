---
title: "signbitf Function (fast_math)"
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
  - amp_math/Concurrency::fast_math::signbitf
dev_langs: 
  - C++
ms.assetid: b4c1602c-6088-492b-9732-80b7d0deb6cd
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# signbitf Function (fast_math)
Determines whether the sign of _X is negative  
  
## Syntax  
  
```  
inline int signbitf(  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns a nonzero value if and only if the sign of _X is negative  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)