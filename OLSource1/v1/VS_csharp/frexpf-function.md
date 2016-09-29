---
title: "frexpf Function"
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
  - "amp_math/Concurrency::precise_math::frexpf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frexpf function"
ms.assetid: 8b17253c-dda3-481d-a9b7-949171c695fe
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# frexpf Function
Gets the mantissa and exponent of _X  
  
## Syntax  
  
```  
inline float frexpf(  
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
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)