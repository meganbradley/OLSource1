---
title: "tile_barrier::wait_with_all_memory_fence Method"
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
  - "amp/Concurrency::tile_barrier::wait_with_all_memory_fence"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait_with_all_memory_fence function"
ms.assetid: 2116d010-fdbb-4eea-af46-de3d82276932
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tile_barrier::wait_with_all_memory_fence Method
Blocks execution of all threads in a tile until all threads in a tile have reached this call. This ensures that all memory accesses are visible to other threads in the thread tile, and have been executed in program order.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tile_barrier Class](../vs140/tile_barrier-class.md)