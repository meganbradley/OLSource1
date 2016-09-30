---
title: "log1p Function"
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
  - "amp_math/Concurrency::precise_math::log1p"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "log1p function"
ms.assetid: 16a3b40a-5323-4ac1-9816-29aea218a9f2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# log1p Function
Calculates the base-e logarithm of 1 plus the argument  
  
## Syntax  
  
```  
inline float log1p(  
   float _X  
) restrict(amp);  
inline double log1p(  
   double _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns the base-e logarithm of 1 plus the argument  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)