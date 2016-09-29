---
title: "frexp Function"
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
  - "amp_math/Concurrency::precise_math::frexp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frexp function"
ms.assetid: f437222e-f6bb-4b0c-ae19-e65955256c66
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# frexp Function
Gets the mantissa and exponent of _X  
  
## Syntax  
  
```  
inline float frexp(  
   float _X,  
   _Out_ int * _Exp  
) restrict(amp);  
inline double frexp(  
   double _X,  
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
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)