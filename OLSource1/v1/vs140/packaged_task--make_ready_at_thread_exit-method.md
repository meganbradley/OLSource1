---
title: "packaged_task::make_ready_at_thread_exit Method"
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
  - "future/std::packaged_task::make_ready_at_thread_exit"
dev_langs: 
  - "C++"
ms.assetid: f28f27cc-a110-48ee-86b8-8a1bbf56c3f5
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# packaged_task::make_ready_at_thread_exit Method
Calls the callable object that's stored in the *associated asynchronous state* and atomically stores the returned value.  
  
## Syntax  
  
```cpp  
void make_ready_at_thread_exit(ArgTypes... args);  
```  
  
## Remarks  
 If the `packaged_task` object doesn't have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of `no_state`.  
  
 If this method or [make_ready_at_thread_exit](../vs140/packaged_task--make_ready_at_thread_exit-method.md) has already been called for a `packaged_task` object that has the same associated asynchronous state, the method throws a `future_error` that has an error code of `promise_already_satisfied`.  
  
 Otherwise, this operator calls `INVOKE(fn, args..., Ty)`, where *fn* is the callable object that's stored in the associated asynchronous state. Any returned value is stored atomically as the returned result of the associated asynchronous state.  
  
 In contrast to [packaged_task::operator() Operator](../vs140/packaged_task--operator---operator.md), the associated asynchronous state is not set to `ready` until after all thread-local objects in the calling thread have been destroyed. Typically, threads that are blocked on the associated asynchronous state are not unblocked until the calling thread exits.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [packaged_task Class](../vs140/packaged_task-class.md)   
 [<future\>](../vs140/-future-.md)