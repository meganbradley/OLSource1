---
title: "expm1f Function"
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
  - "amp_math/Concurrency::precise_math::expm1f"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "expm1f function"
ms.assetid: d1a805ec-8c4b-4d81-8bea-454767b1375e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# expm1f Function
Calculates the base-e exponential of the argument, minus 1  
  
## Syntax  
  
```  
inline float expm1f(  
   float exponent  
) restrict(amp);  
```  
  
#### Parameters  
 `exponent`  
 The exponential term *n* of the mathematical expression `e`<sup>n</sup>, where `e` is the base of the natural logarithm.  
  
## Return Value  
 Returns the base-e exponential of the argument, minus 1  
  
## Remarks  
 The result of the function call `expm1f(n)` is the same as the result of the expression `expf(n) – 1.0f`.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)