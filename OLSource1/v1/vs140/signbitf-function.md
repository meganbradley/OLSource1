---
title: "signbitf Function"
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
  - "amp_math/Concurrency::precise_math::signbitf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "signbitf function"
ms.assetid: 45832301-61d9-4d9f-ae0a-d0611dd88041
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# signbitf Function
Determines whether the sign of _X is negative  
  
## Syntax  
  
```  
inline int signbitf(  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns a nonzero value if and only if the sign of _X is negative  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)