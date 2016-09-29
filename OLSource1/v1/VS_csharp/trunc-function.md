---
title: "trunc Function"
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
  - "amp_math/Concurrency::precise_math::trunc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "trunc function"
ms.assetid: ddeea8d7-694a-45d1-9ff5-c496381097fd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# trunc Function
Truncates the argument to the integer component  
  
## Syntax  
  
```  
inline float trunc(  
   float _X  
) restrict(amp);  
inline double trunc(  
   double _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns the integer component of the argument  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)