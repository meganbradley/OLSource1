---
title: "atomic_fetch_xor Function (C++ AMP)"
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
  - amp/Concurrency::atomic_fetch_xor
dev_langs: 
  - C++
helpviewer_keywords: 
  - atomic_fetch_xor function
ms.assetid: 47d1fb7f-94fc-4815-8fe6-0879f13ab8fb
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# atomic_fetch_xor Function (C++ AMP)
Atomically peforms an bitwise XOR operation of a value and a memory location.  
  
## Syntax  
  
```  
inline int atomic_fetch_xor(  
   _Inout_ int * _Dest,  
   int _Value                       
) restrict(amp);  
  
inline unsigned int atomic_fetch_xor(  
   _Inout_ unsigned int * _Dest,  
   unsigned int _Value                       
) restrict(amp);  
```  
  
#### Parameters  
 `_Dest`  
 Pointer to the memory location.  
  
 `_Value`  
 The value to use in the XOR calculation.  
  
## Return Value  
 The original value of the memory location.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)