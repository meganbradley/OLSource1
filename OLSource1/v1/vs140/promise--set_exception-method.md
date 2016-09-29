---
title: "promise::set_exception Method"
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
  - "future/std::promise::set_exception"
dev_langs: 
  - "C++"
ms.assetid: b36ff679-7806-4ac8-b605-47d371e87a49
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# promise::set_exception Method
Atomically stores an exception as the result of this `promise` object and sets the *associated asynchronous state* to *ready*.  
  
## Syntax  
  
```  
void set_exception(exception_ptr Exc);  
```  
  
#### Parameters  
 `Exc`  
 An [exception_ptr](../vs140/transporting-exceptions-between-threads.md) that's stored by this method as the exception result.  
  
## Remarks  
 If the `promise` object has no associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of `no_state`.  
  
 If `set_exception`, [set_exception_at_thread_exit](../Topic/promise::set_exception_at_thread_exit%20Method_deleted.md), [set_value](../vs140/promise--set_value-method.md), or [set_value_at_thread_exit](../Topic/promise::set_value_at_thread_exit%20Method_deleted.md) has already been called for a `promise` object that has the same associated asynchronous state, this method throws a `future_error` that has an error code of `promise_already_satisfied`.  
  
 As a result of this method, any threads that are blocked on the associated asynchronous state become unblocked.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [promise Class](../vs140/promise-class.md)   
 [<future\>](../vs140/-future-.md)