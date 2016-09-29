---
title: "memory_order Enum"
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
  - "atomic/std::memory_order"
dev_langs: 
  - "C++"
ms.assetid: 55c584b6-c9b3-422d-8e68-9077ae3cc4dd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memory_order Enum
Supplies symbolic names for synchronization operations on memory locations. These operations affect how assignments in one thread become visible in another.  
  
## Syntax  
  
```  
typedef enum memory_order {  
   memory_order_relaxed,  
   memory_order_consume,  
   memory_order_acquire,  
   memory_order_release,  
   memory_order_acq_rel,  
   memory_order_seq_cst,  
} memory_order;  
```  
  
## Remarks  
  
|||  
|-|-|  
|`memory_order_relaxed`|No ordering required.|  
|`memory_order_consume`|A load operation acts as a consume operation on the memory location.|  
|`memory_order_acquire`|A load operation acts as an acquire operation on the memory location.|  
|`memory_order_release`|A store operation acts as a release operation on the memory location.|  
|`memory_order_acq_rel`|Combines `memory_order_acquire` and `memory_order_release`.|  
|`memory_order_seq_cst`|Combines `memory_order_acquire` and `memory_order_release`. Memory accesses that are marked as `memory_order_seq_cst` must be sequentially consistent.|  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)