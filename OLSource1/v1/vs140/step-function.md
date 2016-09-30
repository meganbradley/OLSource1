---
title: "step Function"
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
  - "amp/Concurrency::direct3d::step"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "step function"
ms.assetid: f9432540-8e3d-41d2-b0df-3e5af76aa7b0
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# step Function
Compares two values, returning 0 or 1 based on which value is greater  
  
## Syntax  
  
```  
inline float step(  
   float _Y,  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_Y`  
 Floating-point value  
  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns 1 if the _X is greater than or equal to _Y; otherwise, 0  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)