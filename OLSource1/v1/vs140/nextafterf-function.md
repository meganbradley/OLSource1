---
title: "nextafterf Function"
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
  - "amp_math/Concurrency::precise_math::nextafterf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nextafterf function"
ms.assetid: 199a9da9-051c-44dd-88d9-ea6e259bacbc
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nextafterf Function
Determine the next representable value, in the type of the function, after _X in the direction of _Y  
  
## Syntax  
  
```  
inline float nextafterf(  
   float _X,  
   float _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Y`  
 Floating-point value  
  
## Return Value  
 Returns the next representable value, in the type of the function, after _X in the direction of _Y  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)