---
title: "fmodf Function (fast_math)"
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
  - "amp_math/Concurrency::fast_math::fmodf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fast_modf function"
ms.assetid: 2bddb864-bb35-40d9-9808-2e23b8891418
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fmodf Function (fast_math)
Calculates the floating-point remainder of _X/_Y.  
  
## Syntax  
  
```  
inline float fmodf(  
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
 Returns the floating-point remainder of _X/_Y  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)