---
title: "atomic_fetch_add Function (C++ AMP)"
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
  - "amp/Concurrency::atomic_fetch_add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atomic_fetch_add function"
ms.assetid: ff4d90a4-c07b-432a-a84f-8550025cdbfd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_add Function (C++ AMP)
Atomically add a value to the value of a memory location.  
  
## Syntax  
  
```  
inline int atomic_fetch_add(  
   _Inout_ int * _Dest,  
   int _Value                       
) restrict(amp);  
  
inline unsigned int atomic_fetch_add(  
   _Inout_ unsigned int * _Dest,  
   unsigned int _Value                       
) restrict(amp);  
```  
  
#### Parameters  
 `_Dest`  
 Pointer to the memory location.  
  
 `_Value`  
 The value to be added.  
  
## Return Value  
 The original value of the memory location.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)