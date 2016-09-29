---
title: "ISchedulerProxy::RequestInitialVirtualProcessors Method"
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
  - "concrtrm/concurrency::ISchedulerProxy::RequestInitialVirtualProcessors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RequestInitialVirtualProcessors method"
ms.assetid: bbcc68a6-9f69-4d93-a76e-3c751db15fea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISchedulerProxy::RequestInitialVirtualProcessors Method
Requests an initial allocation of virtual processor roots. Every virtual processor root represents the ability to execute one thread that can perform work for the scheduler.  
  
## Syntax  
  
```  
virtual IExecutionResource * RequestInitialVirtualProcessors(  
   bool doSubscribeCurrentThread  
) =0;  
```  
  
#### Parameters  
 `doSubscribeCurrentThread`  
 Whether to subscribe the current thread and account for it during resource allocation.  
  
## Return Value  
 The `IExecutionResource` interface for the current thread, if the parameter `doSubscribeCurrentThread` has the value `true`. If the value is `false`, the method returns `NULL`.  
  
## Remarks  
 Before a scheduler executes any work, it should use this method to request virtual processor roots from the Resource Manager. The Resource Manager will access the scheduler's policy using [IScheduler::GetPolicy](../vs140/ischeduler--getpolicy-method.md) and use the values for the policy keys `MinConcurrency`, `MaxConcurrency` and `TargetOversubscriptionFactor` to determine how many hardware threads to assign to the scheduler initially and how many virtual processor roots to create for every hardware thread. For more information on how scheduler policies are used to determine a scheduler's initial allocation, see [PolicyElementKey](../vs140/policyelementkey-enumeration.md).  
  
 The Resource Manager grants resources to a scheduler by calling the method [IScheduler::AddVirtualProcessors](../vs140/ischeduler--addvirtualprocessors-method.md) with a list of virtual processor roots. The method is invoked as a callback into the scheduler before this method returns.  
  
 If the scheduler requested subscription for the current thread by setting the parameter `doSubscribeCurrentThread` to `true`, the method returns an `IExecutionResource` interface. The subscription must be terminated at a later point by using the [IExecutionResource::Remove](../vs140/iexecutionresource--remove-method.md) method.  
  
 When determining which hardware threads are selected, the Resource Manager will attempt to optimize for processor node affinity. If subscription is requested for the current thread, it is an indication that the current thread intends to participate in the work assigned to this scheduler. In such a case, the allocated virtual processors roots are located on the processor node the current thread is executing on, if possible.  
  
 The act of subscribing a thread increases the subscription level of the underlying hardware thread by one. The subscription level is reduced by one when the subscription is terminated. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)