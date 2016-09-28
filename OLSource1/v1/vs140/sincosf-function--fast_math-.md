---
title: "sincosf Function (fast_math)"
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
  - "amp_math/Concurrency::fast_math::sincosf"
dev_langs: 
  - "C++"
ms.assetid: 59b8a66d-0073-409c-a7de-ee75d4962131
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sincosf Function (fast_math)
Calculates sine and cosine value of _X  
  
## Syntax  
  
```  
inline void sincosf(  
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