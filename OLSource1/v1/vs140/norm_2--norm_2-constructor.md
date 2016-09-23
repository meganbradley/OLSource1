---
title: "norm_2::norm_2 Constructor"
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
  - amp/Concurrency::graphics::norm_2::norm_2
dev_langs: 
  - C++
ms.assetid: 63497e97-d1af-48e3-aeb7-a4eba3811bce
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# norm_2::norm_2 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
norm_2() restrict(amp,cpu);  
norm_2(  
   norm _V0,  
   norm _V1  
) restrict(amp,cpu);  
norm_2(  
   float _V0,  
   float _V1  
) restrict(amp,cpu);  
norm_2(  
   unorm _V0,  
   unorm _V1  
) restrict(amp,cpu);  
norm_2(  
   norm _V  
) restrict(amp,cpu);  
explicit norm_2(  
   float _V  
) restrict(amp,cpu);  
norm_2(  
   const norm_2& _Other  
) restrict(amp,cpu);  
explicit inline norm_2(  
   const uint_2& _Other  
) restrict(amp,cpu);  
explicit inline norm_2(  
   const int_2& _Other  
) restrict(amp,cpu);  
explicit inline norm_2(  
   const float_2& _Other  
) restrict(amp,cpu);  
explicit inline norm_2(  
   const unorm_2& _Other  
) restrict(amp,cpu);  
explicit inline norm_2(  
   const double_2& _Other  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_V0`  
 The value to initialize element 0.  
  
 `_V1`  
 The value to initialize element 1.  
  
 `_V`  
 The value for initialization.  
  
 `_Other`  
 The object used to initialize.  
  
## Requirements  
 **Header:** amp_short_vectors.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [norm_2 Class](../vs140/norm_2-class.md)