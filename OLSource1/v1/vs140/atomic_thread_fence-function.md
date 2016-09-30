---
title: "atomic_thread_fence Function"
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
  - "atomic/std::atomic_thread_fence"
dev_langs: 
  - "C++"
ms.assetid: 14d2d5fc-e490-4160-9b1e-4711d78b0577
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_thread_fence Function
Acts as a *fence*—which is a memory synchronization primitive that enforces ordering between load/store operations—without an associated atomic operation.  
  
## Syntax  
  
```  
inline void atomic_thread_fence(  
   memory_order Order  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Order`  
 A memory ordering constraint that determines fence type.  
  
## Remarks  
 The `Order` argument determines fence type.  
  
|||  
|-|-|  
|`memory_order_relaxed`|The fence has no effect.|  
|`memory_order_consume`|The fence is an acquire fence.|  
|`memory_order_acquire`|The fence is an acquire fence.|  
|`memory_order_release`|The fence is a release fence.|  
|`memory_order_acq_rel`|The fence is both an acquire fence and a release fence.|  
|`memory_order_seq_cst`|The fence is both an acquire fence and a release fence, and is sequentially consistent.|  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_signal_fence](../vs140/atomic_signal_fence-function.md)