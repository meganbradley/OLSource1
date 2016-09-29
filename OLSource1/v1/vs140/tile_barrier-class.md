---
title: "tile_barrier Class"
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
  - "amp/Concurrency::tile_barrier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tile_barrier class"
ms.assetid: b4ccdccb-0032-4e11-b7bd-dc9d43445dee
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tile_barrier Class
Synchronizes the execution of threads that are running in the thread group (the tile) by using `wait` methods. Only the runtime can instantiate this class.  
  
## Syntax  
  
```  
class tile_barrier;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[tile_barrier::tile_barrier Constructor](../vs140/tile_barrier--tile_barrier-constructor.md)|Initializes a new instance of the `tile_barrier` class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[tile_barrier::wait Method](../vs140/tile_barrier--wait-method.md)|Instructs all threads in the thread group (tile) to stop executing until all threads in the tile have finished waiting.|  
|[tile_barrier::wait_with_all_memory_fence Function](../vs140/tile_barrier--wait_with_all_memory_fence-method.md)|Blocks execution of all threads in a tile until all memory accesses have been completed and all threads in the tile have reached this call.|  
|[tile_barrier::wait_with_global_memory_fence Function](../vs140/tile_barrier--wait_with_global_memory_fence-method.md)|Blocks execution of all threads in a tile until all global memory accesses have been completed and all threads in the tile have reached this call.|  
|[tile_barrier::wait_with_tile_static_memory_fence Function](../vs140/tile_barrier--wait_with_tile_static_memory_fence-method.md)|Blocks execution of all threads in a tile until all `tile_static` memory accesses have been completed and all threads in the tile have reached this call.|  
  
## Inheritance Hierarchy  
 `tile_barrier`  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)