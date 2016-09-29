---
title: "fdimf Function"
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
  - "amp_math/Concurrency::precise_math::fdimf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fdimf function"
ms.assetid: ee499280-d640-460c-bf8e-2ecbb3f2c641
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fdimf Function
Computes the positive difference between the arguments.  
  
## Syntax  
  
```  
inline float fdimf(  
   float _X,  
   float _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Y`  
 Floating-point value  
  
## Return Value  
 The difference between `_X` and `_Y` if `_X` is greater than `_Y`; otherwise, `+0`.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)