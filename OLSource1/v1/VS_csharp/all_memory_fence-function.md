---
title: "all_memory_fence Function"
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
  - "amp/Concurrency::direct3d::all_memory_fence"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "all_memory_fence function"
ms.assetid: dba73687-b1c9-40b6-8ee6-1851e7e95236
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# all_memory_fence Function
Blocks execution of all threads in a tile until all memory accesses have been completed. This ensures that all memory accesses are visible to other threads in the thread tile, and are executed in program order.  
  
## Syntax  
  
```  
inline void all_memory_fence(  
   const tile_barrier & _Barrier  
) restrict(amp);  
```  
  
#### Parameters  
 `_Barrier`  
 A `tile_barrier` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../VS_csharp/concurrency--direct3d-namespace.md)