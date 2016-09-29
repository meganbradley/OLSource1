---
title: "hypot Function"
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
  - "amp_math/Concurrency::precise_math::hypot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hypot function"
ms.assetid: 65742040-165a-4fb7-8644-9eaf8e4c15d7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hypot Function
Computes the square root of the sum of the squares of _X and _Y  
  
## Syntax  
  
```  
inline float hypot(  
   float _X,  
   float _Y  
) restrict(amp);  
inline double hypot(  
   double _X,  
   double _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Y`  
 Floating-point value  
  
## Return Value  
 Returns the square root of the sum of the squares of _X and _Y  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)