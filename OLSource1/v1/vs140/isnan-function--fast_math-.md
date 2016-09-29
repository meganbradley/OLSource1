---
title: "isnan Function (fast_math)"
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
  - "amp_math/Concurrency::fast_math::isnan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fast_isnan function"
ms.assetid: 86d7a8d7-2607-4097-a399-801ebfe74730
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isnan Function (fast_math)
Determines whether the argument is a NaN  
  
## Syntax  
  
```  
inline int isnan(  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns a nonzero value if and only if the argument has a NaN value  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::fast_math  
  
## See Also  
 [Concurrency::fast_math Namespace](../vs140/concurrency--fast_math-namespace.md)