---
title: "isnormal Function"
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
  - "amp_math/Concurrency::precise_math::isnormal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isnormal function"
ms.assetid: a8fef126-f182-49e6-aa4e-8d63df0c15ac
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isnormal Function
Determines whether the argument is a normal  
  
## Syntax  
  
```  
inline int isnormal(  
   float _X  
) restrict(amp);  
inline int isnormal(  
   double _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns a nonzero value if and only if the argument has a normal value  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)