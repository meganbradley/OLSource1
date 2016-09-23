---
title: "tgamma Function"
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
  - amp_math/Concurrency::precise_math::tgamma
dev_langs: 
  - C++
helpviewer_keywords: 
  - tgamma function
ms.assetid: c5565d2f-dcd9-49e8-8f48-d149b94cf763
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# tgamma Function
Computes the gamma function of _X  
  
## Syntax  
  
```  
inline float tgamma(  
   float _X  
) restrict(amp);  
inline double tgamma(  
   double _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns the result of gamma function of _X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)