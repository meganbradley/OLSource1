---
title: "lgammaf Function"
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
  - "amp_math/Concurrency::precise_math::lgammaf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lgammaf function"
ms.assetid: 579eec2f-fcd6-46dd-84f8-03e3077a8bd6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lgammaf Function
Computes the natural logarithm of the absolute value of gamma of the argument  
  
## Syntax  
  
```  
inline float lgammaf(  
   float _X,  
   _Out_ int * _Sign  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Sign`  
 Returns the sign  
  
## Return Value  
 Returns the natural logarithm of the absolute value of gamma of the argument  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)