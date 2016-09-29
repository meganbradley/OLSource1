---
title: "int_2::int_2 Constructor"
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
  - "amp/Concurrency::graphics::int_2::int_2"
dev_langs: 
  - "C++"
ms.assetid: bbf5ed37-6b54-4641-adc8-06099528beee
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# int_2::int_2 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
int_2() restrict(amp,cpu);  
int_2(  
   int _V0,  
   int _V1  
) restrict(amp,cpu);  
int_2(  
   int _V  
) restrict(amp,cpu);  
int_2(  
   const int_2& _Other  
) restrict(amp,cpu);  
explicit inline int_2(  
   const uint_2& _Other  
) restrict(amp,cpu);  
explicit inline int_2(  
   const float_2& _Other  
) restrict(amp,cpu);  
explicit inline int_2(  
   const unorm_2& _Other  
) restrict(amp,cpu);  
explicit inline int_2(  
   const norm_2& _Other  
) restrict(amp,cpu);  
explicit inline int_2(  
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
 [int_2 Class](../vs140/int_2-class.md)