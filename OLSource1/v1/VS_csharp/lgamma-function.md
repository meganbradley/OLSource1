---
title: "lgamma Function"
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
  - "amp_math/Concurrency::precise_math::lgamma"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lgamma function"
ms.assetid: 05c2b608-77a0-4100-a977-2b5227e688b3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lgamma Function
Computes the natural logarithm of the absolute value of gamma of the argument  
  
## Syntax  
  
```  
inline float lgamma(  
   float _X,  
   _Out_ int * _Sign  
) restrict(amp);  
inline double lgamma(  
   double _X,  
   _Out_ int * _Sign  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Sign`  
 Returns the sign  
  
## Return Value  
 Returns the natural logarithm of the absolute value of gamma of the argument  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)