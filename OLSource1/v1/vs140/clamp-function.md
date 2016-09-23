---
title: "clamp Function"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp/Concurrency::direct3d::clamp
dev_langs: 
  - C++
helpviewer_keywords: 
  - clamp function
ms.assetid: 39f4e2ea-7684-444f-965c-2dc728689cbb
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# clamp Function
Computes the value of the first specified argument clamped to a range defined by the second and third specified arguments.  
  
## Syntax  
  
```  
inline float clamp(  
   float _X,  
   float _Min,  
   float _Max  
) restrict(amp);  
inline int clamp(  
   int _X,  
   int _Min,  
   int _Max  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 The value to be clamped  
  
 `_Min`  
 The lower bound of the clamping range.  
  
 `_Max`  
 The upper bound of the clamping range.  
  
## Return Value  
 The clamped value of `_X`.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)