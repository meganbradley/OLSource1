---
title: "nearbyint Function"
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
  - "amp_math/Concurrency::precise_math::nearbyint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nearbyint function"
ms.assetid: c119dd98-6d73-4852-8a26-c0fa9705fefe
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nearbyint Function
Rounds the argument to an integer value in floating-point format, using the current rounding direction.  
  
## Syntax  
  
```  
inline float nearbyint(  
   float _X  
) restrict(amp);  
inline double nearbyint(  
   double _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns the rounded integer value.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)