---
title: "scalbnf Function"
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
  - amp_math/Concurrency::precise_math::scalbnf
dev_langs: 
  - C++
helpviewer_keywords: 
  - scalbnf function
ms.assetid: e2bf9fa6-d748-41e4-9f28-9117d73f4294
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# scalbnf Function
Multiplies _X by FLT_RADIX to the power _Y  
  
## Syntax  
  
```  
inline float scalbnf(  
   float _X,  
   int _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Y`  
 Integer value  
  
## Return Value  
 Returns _X * (FLT_RADIX ^ _Y)  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)