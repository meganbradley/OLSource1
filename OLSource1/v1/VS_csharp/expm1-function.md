---
title: "expm1 Function"
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
  - "amp_math/Concurrency::precise_math::expm1"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "expm1 function"
ms.assetid: db9024be-e691-4bd2-92d1-94ff36595c44
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# expm1 Function
Calculates the base-e exponential of the argument, minus 1  
  
## Syntax  
  
```  
inline float expm1(  
   float exponent  
) restrict(amp);  
  
inline double expm1(  
   double exponent  
) restrict(amp);  
```  
  
#### Parameters  
 `exponent`  
 The exponential term *n* of the mathematical expression `e`<sup>n</sup>, where `e` is the base of the natural logarithm.  
  
## Return Value  
 Returns the base-e exponential of the argument, minus 1  
  
## Remarks  
 The result of the function call `expm1(n)` is the same as the result of the expression `exp(n) – 1.0f` if *n* is a single-precision floating-point number, or the expression `exp(n) – 1.0` if *n* is a double-precision floating-point number.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)