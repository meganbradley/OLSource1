---
title: "sincosf Function"
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
  - "amp_math/Concurrency::precise_math::sincosf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sincosf function"
ms.assetid: 4753e5a7-f654-4c25-8150-da4a34e2cab2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sincosf Function
Calculates sine and cosine value of _X  
  
## Syntax  
  
```  
inline void sincosf(  
   float _X,  
   _Out_ float * _S,  
   _Out_ float * _C  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_S`  
 Returns the sine value of _X  
  
 `_C`  
 Returns the cosine value of _X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../VS_csharp/concurrency--precise_math-namespace.md)