---
title: "atomic_fetch_max Function"
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
  - "amp/Concurrency::atomic_fetch_max"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atomic_fetch_max function"
ms.assetid: 09f54a53-fe36-4c98-a90a-51f89f347904
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_max Function
Atomically computes the maximum value between the value stored at the memory location specified in the first argument and the value specified in the second argument, and stores it at the same memory location.  
  
## Syntax  
  
```  
inline int atomic_fetch_max(  
   _Inout_ int * _Dest,  
   int _Value  
) restrict(amp);  
  
inline unsigned int atomic_fetch_max(  
   _Inout_ unsigned int * _Dest,  
   unsigned int _Value  
) restrict(amp);  
```  
  
#### Parameters  
 `_Dest`  
 The location from which one of the values to be compared is read, and to which the maximum of the two values is to be stored.  
  
 `_Value`  
 The value to be compared to the value at the specified location.  
  
## Return Value  
 The original value stored at the specified location location.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../VS_csharp/concurrency-namespace--c---amp-.md)