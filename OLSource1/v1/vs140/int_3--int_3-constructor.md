---
title: "int_3::int_3 Constructor"
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
  - "amp/Concurrency::graphics::int_3::int_3"
dev_langs: 
  - "C++"
ms.assetid: 3416e61c-4755-4f54-996d-206e11ffa730
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# int_3::int_3 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
int_3() restrict(amp,cpu);  
int_3(  
   int _V0,  
   int _V1,  
   int _V2  
) restrict(amp,cpu);  
int_3(  
   int _V  
) restrict(amp,cpu);  
int_3(  
   const int_3& _Other  
) restrict(amp,cpu);  
explicit inline int_3(  
   const uint_3& _Other  
) restrict(amp,cpu);  
explicit inline int_3(  
   const float_3& _Other  
) restrict(amp,cpu);  
explicit inline int_3(  
   const unorm_3& _Other  
) restrict(amp,cpu);  
explicit inline int_3(  
   const norm_3& _Other  
) restrict(amp,cpu);  
explicit inline int_3(  
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
 [int_3 Class](../vs140/int_3-class.md)