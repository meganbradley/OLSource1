---
title: "unorm_4::unorm_4 Constructor"
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
  - "amp/Concurrency::graphics::unorm_4::unorm_4"
dev_langs: 
  - "C++"
ms.assetid: 8685e980-415f-4b15-a66c-5f17a0457fa8
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unorm_4::unorm_4 Constructor
Default constructor, initializes all elements with 0.  
  
## Syntax  
  
```  
unorm_4() restrict(amp,cpu);  
unorm_4(  
   unorm _V0,  
   unorm _V1,  
   unorm _V2,  
   unorm _V3  
) restrict(amp,cpu);  
unorm_4(  
   float _V0,  
   float _V1,  
   float _V2,  
   float _V3  
) restrict(amp,cpu);  
unorm_4(  
   unorm _V  
) restrict(amp,cpu);  
explicit unorm_4(  
   float _V  
) restrict(amp,cpu);  
unorm_4(  
   const unorm_4& _Other  
) restrict(amp,cpu);  
explicit inline unorm_4(  
   const uint_4& _Other  
) restrict(amp,cpu);  
explicit inline unorm_4(  
   const int_4& _Other  
) restrict(amp,cpu);  
explicit inline unorm_4(  
   const float_4& _Other  
) restrict(amp,cpu);  
explicit inline unorm_4(  
   const norm_4& _Other  
) restrict(amp,cpu);  
explicit inline unorm_4(  
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
 [unorm_4 Class](../VS_csharp/unorm_4-class.md)