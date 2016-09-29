---
title: "ISchedulerProxy::SubscribeCurrentThread Method"
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
  - "concrtrm/concurrency::ISchedulerProxy::SubscribeCurrentThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SubscribeCurrentThread method"
ms.assetid: db681bf8-476c-4d0e-bff4-acc593be77e1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISchedulerProxy::SubscribeCurrentThread Method
Registers the current thread with the Resource Manager, associating it with this scheduler.  
  
## Syntax  
  
```  
virtual IExecutionResource * SubscribeCurrentThread() =0;  
```  
  
## Return Value  
 The `IExecutionResource` interfacing representing the current thread in the runtime.  
  
## Remarks  
 Use this method if you want the Resource Manager to account for the current thread while allocating resources to your scheduler and other schedulers. It is especially useful when the thread plans to participate in the work queued to your scheduler, along with the virtual processor roots the scheduler receives from the Resource Manager. The Resource Manager uses information to prevent unnecessary oversubscription of hardware threads on the system.  
  
 The execution resource received via this method should be returned to the Resource Manager using the [IExecutionResource::Remove](../vs140/iexecutionresource--remove-method.md) method. The thread that calls the `Remove` method must be the same thread that previously called the `SubscribeCurrentThread` method.  
  
 The act of subscribing a thread increases the subscription level of the underlying hardware thread by one. The subscription level is reduced by one when the subscription is terminated. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)