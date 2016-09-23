---
title: "nanf Function"
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
  - amp_math/Concurrency::precise_math::nanf
dev_langs: 
  - C++
helpviewer_keywords: 
  - nanf function
ms.assetid: 82abb93e-5732-4148-b2da-7e1aec9c3d59
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# nanf Function
Returns a quiet NaN  
  
## Syntax  
  
```  
inline float nanf(  
   int _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Integer value  
  
## Return Value  
 Returns a quiet NaN, if available, with the content indicated in _X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)