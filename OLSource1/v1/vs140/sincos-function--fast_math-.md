---
title: "sincos Function (fast_math)"
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
  - "amp_math/Concurrency::fast_math::sincos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fast_sincos function"
ms.assetid: f35ae426-6ae7-46d4-a894-dedb76566c3e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sincos Function (fast_math)
Calculates sine and cosine value of _X  
  
## Syntax  
  
```  
inline void sincos(  
   float _X,  
   float * _S,  
   float * _C  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_S`  
 Returns the sine value of _X  
  
 `_C`  
 Returns the cosine value of _X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)