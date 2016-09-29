---
title: "nextafter Function"
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
  - "amp_math/Concurrency::precise_math::nextafter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nextafter function"
ms.assetid: d0b7e07c-6a1b-444e-af5d-9663a3662256
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nextafter Function
Determine the next representable value, in the type of the function, after _X in the direction of _Y  
  
## Syntax  
  
```  
inline float nextafter(  
   float _X,  
   float _Y  
) restrict(amp);  
inline double nextafter(  
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
 Returns the next representable value, in the type of the function, after _X in the direction of _Y  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)