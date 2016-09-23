---
title: "fmodf Function"
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
  - amp_math/Concurrency::precise_math::fmodf
dev_langs: 
  - C++
helpviewer_keywords: 
  - fmodf function
ms.assetid: 5fbd325e-bfc2-4aca-87d2-08e65ffe55f3
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# fmodf Function
Computes the remainder of the first specified argument divided by the second specified argument.  
  
## Syntax  
  
```  
inline float fmodf(  
   float _X,  
   float _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 The first floating-point argument.  
  
 `_Y`  
 The second floating-point argument.  
  
## Return Value  
 The remainder of `_X` divided by `_Y`; that is, the value of `_X` - `_Y`*n*, where *n* is a whole integer such that the magnitude of `_X` - `_Y`*n* is less than the magnitude of `_Y`.  
  
## Remarks  
 This function is identical to the function overload [fmod(float, float)](../vs140/fmod-function--c---amp-.md). It’s provided for source-level compatibility with source code that uses the C Standard Library function `fmodf`.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)