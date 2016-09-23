---
title: "unorm::unorm Constructor"
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
  - amp/Concurrency::graphics::unorm::unorm
dev_langs: 
  - C++
ms.assetid: 4ad3f565-4e8c-437b-8c35-0d69d29f5ed9
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unorm::unorm Constructor
Default constructor. Initialize to 0.0f.  
  
## Syntax  
  
```  
unorm(  
   void  
) restrict(amp,cpu);  
explicit unorm(  
   float _V  
) restrict(amp,cpu);  
explicit unorm(  
   unsigned int _V  
) restrict(amp,cpu);  
explicit unorm(  
   int _V  
) restrict(amp,cpu);  
explicit unorm(  
   double _V  
) restrict(amp,cpu);  
unorm(  
   const unorm& _Other  
) restrict(amp,cpu);  
inline explicit unorm(  
   const norm& _Other  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_V`  
 The value used to initialize.  
  
 `_Other`  
 The norm object used to initialize.  
  
## Requirements  
 **Header:** amp_short_vectors.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [unorm Class](../vs140/unorm-class.md)