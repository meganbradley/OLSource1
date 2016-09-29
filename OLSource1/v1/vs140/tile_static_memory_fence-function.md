---
title: "tile_static_memory_fence Function"
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
  - "amp/Concurrency::tile_static_memory_fence"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tile_static_memory_fence function"
ms.assetid: 9d144a14-9b89-4764-8583-ae99194c6488
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tile_static_memory_fence Function
Blocks execution of all threads in a tile until all outstanding `tile_static` memory accesses have been completed. This ensures that `tile_static` memory accesses are visible to other threads in the thread tile, and that accesses are executed in program order.  
  
## Syntax  
  
```  
inline void tile_static_memory_fence(  
   const tile_barrier & _Barrier  
) restrict(amp);  
```  
  
#### Parameters  
 `_Barrier`  
 A tile_barrier object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)