---
title: "IVirtualProcessorRoot::Deactivate Method"
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
  - "concrtrm/concurrency::IVirtualProcessorRoot::Deactivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Deactivate method"
ms.assetid: 76b23cb5-8c6e-43d6-adf9-99981fe9de6b
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IVirtualProcessorRoot::Deactivate Method
Causes the thread proxy currently executing on this virtual processor root to stop dispatching the execution context. The thread proxy will resume executing on a call to the `Activate` method.  
  
## Syntax  
  
```  
virtual bool Deactivate(  
   _Inout_ IExecutionContext * pContext  
) =0;  
```  
  
#### Parameters  
 `pContext`  
 The context which is currently being dispatched by this root.  
  
## Return Value  
 A boolean value. A value of `true` indicates that the thread proxy returned from the `Deactivate` method in response to a call to the `Activate` method. A value of `false` indicates that the thread proxy returned from the method in response to a notification event in the Resource Manager. On a user-mode schedulable (UMS) thread scheduler, this indicates that items have appeared on the scheduler's completion list, and the scheduler is required to handle them.  
  
## Remarks  
 Use this method to temporarily stop executing a virtual processor root when you cannot find any work in your scheduler. A call to the `Deactivate` method must originate from within the `Dispatch` method of the execution context that the virtual processor root was last activated with. In other words, the thread proxy invoking the `Deactivate` method must be the one that is currently executing on the virtual processor root. Calling the method on a virtual processor root you are not executing on could result in undefined behavior.  
  
 A deactivated virtual processor root may be woken up with a call to the `Activate` method, with the same argument that was passed in to the `Deactivate` method. The scheduler is responsible for ensuring that calls to the `Activate` and `Deactivate` methods are paired, but they are not required to be received in a specific order. The Resource Manager can handle receiving a call to the `Activate` method before it receives a call to the `Deactivate` method it was meant for.  
  
 If a virtual processor root awakens and the return value from the `Deactivate` method is the value `false`, the scheduler should query the UMS completion list via the `IUMSCompletionList::GetUnblockNotifications` method, act on that information, and then subsequently call the `Deactivate` method again. This should be repeated until such time as the `Deactivate` method returns the value `true`.  
  
 `invalid_argument` is thrown if the argument `pContext` has the value `NULL`.  
  
 `invalid_operation` is thrown if the virtual processor root has never been activated, or the argument `pContext` does not represent the execution context that was most recently dispatched by this virtual processor root.  
  
 The act of deactivating a virtual processor root decreases the subscription level of the underlying hardware thread by one. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IVirtualProcessorRoot::Activate Method](../vs140/ivirtualprocessorroot--activate-method.md)   
 [IExecutionResource::CurrentSubscriptionLevel Method](../vs140/iexecutionresource--currentsubscriptionlevel-method.md)   
 [IUMSCompletionList::GetUnblockNotifications Method](../vs140/iumscompletionlist--getunblocknotifications-method.md)