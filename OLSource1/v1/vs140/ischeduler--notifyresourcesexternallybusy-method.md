---
title: "IScheduler::NotifyResourcesExternallyBusy Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrtrm/concurrency::IScheduler::NotifyResourcesExternallyBusy
dev_langs: 
  - C++
helpviewer_keywords: 
  - NotifyResourcesExternallyBusy method
ms.assetid: 34f0befa-c866-47a1-86ad-2acaa240fe3e
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IScheduler::NotifyResourcesExternallyBusy Method
Notifies this scheduler that the hardware threads represented by the set of virtual processor roots in the array `ppVirtualProcessorRoots` are now being used by other schedulers.  
  
## Syntax  
  
```  
virtual void NotifyResourcesExternallyBusy(  
   _In_reads_(count) IVirtualProcessorRoot ** ppVirtualProcessorRoots,  
   unsigned int count  
) =0;  
```  
  
#### Parameters  
 `ppVirtualProcessorRoots`  
 An array of `IVirtualProcessorRoot` interfaces associated with the hardware threads on which other schedulers have become busy.  
  
 `count`  
 The number of `IVirtualProcessorRoot` interfaces in the array.  
  
## Remarks  
 It is possible for a particular hardware thread to be assigned to multiple schedulers at the same time. One reason for this could be that there are not enough hardware threads on the system to satisfy the minimum concurrency for all schedulers, without sharing resources. Another possibility is that resources are temporarily assigned to other schedulers when the owning scheduler is not using them, by way of all its virtual processor roots on that hardware thread being deactivated.  
  
 The subscription level of a hardware thread is denoted by the number of subscribed threads and activated virtual processor roots associated with that hardware thread. From a particular scheduler's point of view, the external subscription level of a hardware thread is the portion of the subscription other schedulers contribute to. Notifications that resources are externally busy are sent to a scheduler when the external subscription level for a hardware thread moves from zero into positive territory.  
  
 Notifications via this method are only sent to schedulers that have a policy where the value for the `MinConcurrency` policy key is equal to the value for the `MaxConcurrency` policy key. For more information on scheduler policies, see [SchedulerPolicy](../vs140/schedulerpolicy-class.md).  
  
 A scheduler that qualifies for notifications gets a set of initial notifications when it is created, informing it whether the resources it was just assigned are externally busy or idle.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IExecutionResource::CurrentSubscriptionLevel Method](../vs140/iexecutionresource--currentsubscriptionlevel-method.md)   
 [IScheduler::NotifyResourcesExternallyIdle Method](../vs140/ischeduler--notifyresourcesexternallyidle-method.md)