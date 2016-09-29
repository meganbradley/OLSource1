---
title: "modff Function"
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
  - "amp_math/Concurrency::precise_math::modff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "modff function"
ms.assetid: fc650947-160e-4ddb-b2d5-4b36f9d3c929
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# modff Function
Splits the specified argument into fractional and integer parts.  
  
## Syntax  
  
```  
inline float modff(  
   float _X,  
   _Out_ float * _Iptr  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Iptr`  
 The integer portion of `_X`, as a floating-point value.  
  
## Return Value  
 Returns the signed fractional portion of `_X`.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)