---
title: "uint_2::uint_2 Constructor"
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
  - "amp/Concurrency::graphics::uint_2::uint_2"
dev_langs: 
  - "C++"
ms.assetid: 9d313243-8a7d-46e7-b57c-05606331978d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uint_2::uint_2 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
uint_2() restrict(amp,cpu);  
uint_2(  
   unsigned int _V0,  
   unsigned int _V1  
) restrict(amp,cpu);  
uint_2(  
   unsigned int _V  
) restrict(amp,cpu);  
uint_2(  
   const uint_2& _Other  
) restrict(amp,cpu);  
explicit inline uint_2(  
   const int_2& _Other  
) restrict(amp,cpu);  
explicit inline uint_2(  
   const float_2& _Other  
) restrict(amp,cpu);  
explicit inline uint_2(  
   const unorm_2& _Other  
) restrict(amp,cpu);  
explicit inline uint_2(  
   const norm_2& _Other  
) restrict(amp,cpu);  
explicit inline uint_2(  
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
 [uint_2 Class](../vs140/uint_2-class.md)