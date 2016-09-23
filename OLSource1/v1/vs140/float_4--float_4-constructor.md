---
title: "float_4::float_4 Constructor"
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
  - amp/Concurrency::graphics::float_4::float_4
dev_langs: 
  - C++
ms.assetid: 41965ab6-8f5d-4a89-bbb9-8fc8ca395a18
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# float_4::float_4 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
float_4() restrict(amp,cpu);  
float_4(  
   float _V0,  
   float _V1,  
   float _V2,  
   float _V3  
) restrict(amp,cpu);  
float_4(  
   float _V  
) restrict(amp,cpu);  
float_4(  
   const float_4& _Other  
) restrict(amp,cpu);  
explicit inline float_4(  
   const uint_4& _Other  
) restrict(amp,cpu);  
explicit inline float_4(  
   const int_4& _Other  
) restrict(amp,cpu);  
explicit inline float_4(  
   const unorm_4& _Other  
) restrict(amp,cpu);  
explicit inline float_4(  
   const norm_4& _Other  
) restrict(amp,cpu);  
explicit inline float_4(  
   const double_4& _Other  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_V0`  
 The value to initialize element 0.  
  
 `_V1`  
 The value to initialize element 1.  
  
 `_V2`  
 The value to initialize element 2.  
  
 `_V3`  
 The value to initialize element 3.  
  
 `_V`  
 The value for initialization.  
  
 `_Other`  
 The object used to initialize.  
  
## Requirements  
 **Header:** amp_short_vectors.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [float_4 Class](../vs140/float_4-class.md)