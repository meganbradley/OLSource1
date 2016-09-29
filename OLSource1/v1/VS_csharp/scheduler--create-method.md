---
title: "Scheduler::Create Method"
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
  - "concrt/concurrency::Scheduler::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: cedf71a9-e1f4-4e7e-9e01-6a2e74df65c8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::Create Method
Creates a new scheduler whose behavior is described by the `_Policy` parameter, places an initial reference on the scheduler, and returns a pointer to it.  
  
## Syntax  
  
```  
static Scheduler * __cdecl Create(  
   const SchedulerPolicy& _Policy  
);  
```  
  
#### Parameters  
 `_Policy`  
 The scheduler policy that describes behavior of the newly created scheduler.  
  
## Return Value  
 A pointer to a newly created scheduler. This `Scheduler` object has an initial reference count placed on it.  
  
## Remarks  
 After a scheduler is created with the `Create` method, you must call the `Release` method at some point in the future in order to remove the initial reference count and allow the scheduler to shut down.  
  
 A scheduler created with this method is not attached to the calling context. It can be attached to a context using the [Attach](../VS_csharp/scheduler--attach-method.md) method.  
  
 This method can throw a variety of exceptions, including [scheduler_resource_allocation_error](../VS_csharp/scheduler_resource_allocation_error-class.md) and [invalid_scheduler_policy_value](../VS_csharp/invalid_scheduler_policy_value-class.md).  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../VS_csharp/scheduler-class.md)   
 [Scheduler::Release Method](../VS_csharp/scheduler--release-method.md)   
 [Scheduler::Attach Method](../VS_csharp/scheduler--attach-method.md)   
 [CurrentScheduler::Create Method](../VS_csharp/currentscheduler--create-method.md)   
 [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md)   
 [Task Scheduler (Concurrency Runtime)](../VS_csharp/task-scheduler--concurrency-runtime-.md)