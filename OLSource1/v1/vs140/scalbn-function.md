---
title: "scalbn Function"
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
  - "amp_math/Concurrency::precise_math::scalbn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scalbn function"
ms.assetid: a583d7ef-e412-41c7-97b0-0ac1c5844825
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scalbn Function
Multiplies _X by FLT_RADIX to the power _Y  
  
## Syntax  
  
```  
inline float scalbn(  
   float _X,  
   int _Y  
) restrict(amp);  
inline double scalbn(  
   double _X,  
   int _Y  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
 `_Y`  
 Integer value  
  
## Return Value  
 Returns _X * (FLT_RADIX ^ _Y)  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)