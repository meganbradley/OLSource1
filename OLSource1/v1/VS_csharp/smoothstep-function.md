---
title: "smoothstep Function"
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
  - "amp/Concurrency::direct3d::smoothstep"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "smoothstep function"
ms.assetid: 66e259e8-16c6-4879-81e1-e6c33525c774
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# smoothstep Function
Returns a smooth Hermite interpolation between 0 and 1, if _X is in the range [_Min, _Max].  
  
## Syntax  
  
```  
inline float smoothstep(  
   float _Min,  
   float _Max,  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_Min`  
 Floating-point value  
  
 `_Max`  
 Floating-point value  
  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns 0 if _X is less than _Min; 1 if _X is greater than _Max; otherwise, a value between 0 and 1 if _X is in the range [_Min, _Max]  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../VS_csharp/concurrency--direct3d-namespace.md)