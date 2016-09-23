---
title: "uint_4::uint_4 Constructor"
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
  - amp/Concurrency::graphics::uint_4::uint_4
dev_langs: 
  - C++
ms.assetid: 1f9cb0da-7a7e-4353-a9b7-de114eb68c56
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# uint_4::uint_4 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
uint_4() restrict(amp,cpu);  
uint_4(  
   unsigned int _V0,  
   unsigned int _V1,  
   unsigned int _V2,  
   unsigned int _V3  
) restrict(amp,cpu);  
uint_4(  
   unsigned int _V  
) restrict(amp,cpu);  
uint_4(  
   const uint_4& _Other  
) restrict(amp,cpu);  
explicit inline uint_4(  
   const int_4& _Other  
) restrict(amp,cpu);  
explicit inline uint_4(  
   const float_4& _Other  
) restrict(amp,cpu);  
explicit inline uint_4(  
   const unorm_4& _Other  
) restrict(amp,cpu);  
explicit inline uint_4(  
   const norm_4& _Other  
) restrict(amp,cpu);  
explicit inline uint_4(  
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
 [uint_4 Class](../vs140/uint_4-class.md)