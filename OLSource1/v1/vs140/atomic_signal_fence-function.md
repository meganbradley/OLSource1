---
title: "atomic_signal_fence Function"
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
  - "atomic/std::atomic_signal_fence"
dev_langs: 
  - "C++"
ms.assetid: a2aafe4d-ebcc-4cec-a5b0-8ffa1a5185a0
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atomic_signal_fence Function
Acts as a *fence*—which is a memory synchronization primitive that enforces ordering between load/store operations—between other fences in a calling thread that have signal handlers that are executed in the same thread.  
  
## Syntax  
  
```  
inline void atomic_signal_fence(  
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
 [atomic_thread_fence](../vs140/atomic_thread_fence-function.md)