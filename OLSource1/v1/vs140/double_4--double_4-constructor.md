---
title: "double_4::double_4 Constructor"
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
  - "amp/Concurrency::graphics::double_4::double_4"
dev_langs: 
  - "C++"
ms.assetid: e0e99056-2b2b-4845-9b1e-085d0cb46fd3
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# double_4::double_4 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
double_4() restrict(amp, cpu);  
double_4(  
   double _V0,  
   double _V1,  
   double _V2,  
   double _V3  
) restrict(amp, cpu);  
double_4(  
   double _V  
) restrict(amp, cpu);  
double_4(  
   const double_4& _Other  
) restrict(amp, cpu);  
explicit inline double_4(  
   const uint_4& _Other  
) restrict(amp, cpu);  
explicit inline double_4(  
   const int_4& _Other  
) restrict(amp, cpu);  
explicit inline double_4(  
   const float_4& _Other  
) restrict(amp, cpu);  
explicit inline double_4(  
   const unorm_4& _Other  
) restrict(amp, cpu);  
explicit inline double_4(  
   const norm_4& _Other  
) restrict(amp, cpu);  
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
 [double_4 Class](../vs140/double_4-class.md)