---
title: "ldexpf Function"
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
  - amp_math/Concurrency::precise_math::ldexpf
dev_langs: 
  - C++
helpviewer_keywords: 
  - ldexpf function
ms.assetid: e5696a8a-9f10-479a-b6e0-2d37a1f357d3
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ldexpf Function
Computes a real number from the specified mantissa and exponent.  
  
## Syntax  
  
```  
inline float ldexpf(  
   float _X,  
   int _Exp  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value, mantissa  
  
 `_Exp`  
 Integer value, exponent  
  
## Return Value  
 Returns _X * 2^_Exp  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)