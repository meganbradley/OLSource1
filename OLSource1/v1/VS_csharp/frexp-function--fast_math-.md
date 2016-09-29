---
title: "frexp Function (fast_math)"
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
  - "amp_math/Concurrency::fast_math::frexp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fast_frexp function"
ms.assetid: afa379bc-5edd-477c-a722-6dd576e7c950
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# frexp Function (fast_math)
Gets the mantissa and exponent of _X  
  
## Syntax  
  
```  
inline float frexp(  
   float _X,  
   _Out_ int * _Exp  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Exp`  
 Returns the integer exponent of _X in floating-point value  
  
## Return Value  
 Returns the mantissa _X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../VS_csharp/concurrency--fast_math-namespace.md)