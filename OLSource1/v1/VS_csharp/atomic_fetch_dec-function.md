---
title: "atomic_fetch_dec Function"
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
  - "amp/Concurrency::atomic_fetch_dec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atomic_fetch_dec function"
ms.assetid: 0af9113f-6c31-47ab-a9bf-7170a965e982
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_dec Function
Atomically decrements the value stored at the specified memory location.  
  
## Syntax  
  
```  
inline int atomic_fetch_dec(  
   _Inout_ int * _Dest  
) restrict(amp);  
  
inline unsigned int atomic_fetch_dec(  
   _Inout_ unsigned int * _Dest  
) restrict(amp);  
```  
  
#### Parameters  
 `_Dest`  
 The location in memory of the value to be decremented.  
  
## Return Value  
 The original value stored at the memory location.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../VS_csharp/concurrency-namespace--c---amp-.md)