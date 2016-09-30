---
title: "atan2 Function"
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
  - "amp_math/Concurrency::precise_math::atan2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atan2 function"
ms.assetid: 92cc3291-2067-4996-9748-03bed8cbab43
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atan2 Function
Calculates the arctangent of _Y/_X  
  
## Syntax  
  
```  
inline float atan2(  
   float _Y,  
   float _X  
) restrict(amp);  
inline double atan2(  
   double _Y,  
   double _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_Y`  
 Floating-point value  
  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns the arctangent value of _Y/_X  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)