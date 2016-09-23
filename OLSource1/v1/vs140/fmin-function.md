---
title: "fmin Function"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp_math/Concurrency::precise_math::fmin
dev_langs: 
  - C++
helpviewer_keywords: 
  - fmin function
ms.assetid: 41594e91-8298-4ddd-aa1f-1995eb858cb7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# fmin Function
Determine the minimum numeric value of the arguments  
  
## Syntax  
  
```  
inline float fmin(  
   float _X,  
   float _Y  
) restrict(amp);  
inline double fmin(  
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
 Return the minimum numeric value of the arguments  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)