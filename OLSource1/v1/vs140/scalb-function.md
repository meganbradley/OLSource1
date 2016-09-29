---
title: "scalb Function"
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
  - "amp_math/Concurrency::precise_math::scalb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scalb function"
ms.assetid: 79140f81-2c1c-4085-a148-899ff9bf1977
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scalb Function
Multiplies _X by FLT_RADIX to the power _Y  
  
## Syntax  
  
```  
inline float scalb(  
   float _X,  
   float _Y  
) restrict(amp);  
inline double scalb(  
   double _X,  
   double _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Y`  
 Floating-point value  
  
## Return Value  
 Returns _X * (FLT_RADIX ^ _Y)  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)