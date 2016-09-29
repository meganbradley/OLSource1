---
title: "tile_barrier::wait_with_tile_static_memory_fence Method"
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
  - "amp/Concurrency::tile_barrier::wait_with_tile_static_memory_fence"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait_with_tile_static_memory_fence function"
ms.assetid: 65109506-63a0-4219-ae61-03974355c09c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tile_barrier::wait_with_tile_static_memory_fence Method
Blocks execution of all threads in a tile until all threads in a tile have reached this call. This ensures that `tile_static`memory accesses are visible to other threads in the thread tile, and have been executed in program order.  
  
## Syntax  
  
```  
void wait_with_tile_static_memory_fence() const restrict(amp);  
```  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tile_barrier Class](../VS_csharp/tile_barrier-class.md)