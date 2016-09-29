---
title: "copysign Function"
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
  - "amp_math/Concurrency::precise_math::copysign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copysign function"
ms.assetid: 62130931-82ee-4c3f-b816-cbb878736c27
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copysign Function
Produces a value with the magnitude of _X and the sign of _Y  
  
## Syntax  
  
```  
inline float copysign(  
   float _X,  
   float _Y  
) restrict(amp);  
inline double copysign(  
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
 Returns a value with the magnitude of _X and the sign of _Y  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)