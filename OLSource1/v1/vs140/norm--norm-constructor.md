---
title: "norm::norm Constructor"
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
  - "amp/Concurrency::graphics::norm::norm"
dev_langs: 
  - "C++"
ms.assetid: 8e0ef61f-f0a9-4e2a-802f-59330677a93a
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# norm::norm Constructor
Default constructor. Initialize to 0.0f.  
  
## Syntax  
  
```  
norm(  
   void  
) restrict(amp,cpu);  
explicit norm(  
   float _V  
) restrict(amp,cpu);  
explicit norm(  
   unsigned int _V  
) restrict(amp,cpu);  
explicit norm(  
   int _V  
) restrict(amp,cpu);  
explicit norm(  
   double _V  
) restrict(amp,cpu);  
norm(  
   const norm& _Other  
) restrict(amp,cpu);  
norm(  
   const unorm& _Other  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_V`  
 The value used to initialize.  
  
 `_Other`  
 The object used to initialize.  
  
## Requirements  
 **Header:** amp_short_vectors.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [norm Class](../vs140/norm-class.md)