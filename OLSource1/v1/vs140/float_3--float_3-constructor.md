---
title: "float_3::float_3 Constructor"
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
  - "amp/Concurrency::graphics::float_3::float_3"
dev_langs: 
  - "C++"
ms.assetid: 675cae30-2e5b-497d-b199-974bcfe0408d
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# float_3::float_3 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
float_3() restrict(amp,cpu);  
float_3(  
   float _V0,  
   float _V1,  
   float _V2  
) restrict(amp,cpu);  
float_3(  
   float _V  
) restrict(amp,cpu);  
float_3(  
   const float_3& _Other  
) restrict(amp,cpu);  
explicit inline float_3(  
   const uint_3& _Other  
) restrict(amp,cpu);  
explicit inline float_3(  
   const int_3& _Other  
) restrict(amp,cpu);  
explicit inline float_3(  
   const unorm_3& _Other  
) restrict(amp,cpu);  
explicit inline float_3(  
   const norm_3& _Other  
) restrict(amp,cpu);  
explicit inline float_3(  
   const double_3& _Other  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_V0`  
 The value to initialize element 0.  
  
 `_V1`  
 The value to initialize element 1.  
  
 `_V2`  
 The value to initialize element 2.  
  
 `_V`  
 The value for initialization.  
  
 `_Other`  
 The object used to initialize.  
  
## Requirements  
 **Header:** amp_short_vectors.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [float_3 Class](../vs140/float_3-class.md)