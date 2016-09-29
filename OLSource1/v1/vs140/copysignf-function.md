---
title: "copysignf Function"
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
  - "amp_math/Concurrency::precise_math::copysignf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copysignf function"
ms.assetid: ac935ebb-3d00-4adb-9e78-b8135626cf62
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copysignf Function
Produces a value with the magnitude of _X and the sign of _Y  
  
## Syntax  
  
```  
inline float copysignf(  
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
 Returns a value with the magnitude of _X and the sign of _Y  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)