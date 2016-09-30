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
Creates a new scheduler whose behavior is described by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter, places an initial reference on the scheduler, and returns a pointer to it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The scheduler policy that describes behavior of the newly created scheduler.  
  
## Return Value  
 A pointer to a newly created scheduler. This <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object has an initial reference count placed on it.  
  
## Remarks  
 After a scheduler is created with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method, you must call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method at some point in the future in order to remove the initial reference count and allow the scheduler to shut down.  
  
 A scheduler created with this method is not attached to the calling context. It can be attached to a context using the [Attach](../vs140/scheduler--attach-method.md) method.  
  
 This method can throw a variety of exceptions, including [scheduler_resource_allocation_error](../vs140/scheduler_resource_allocation_error-class.md) and [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md).  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Scheduler::Release Method](../vs140/scheduler--release-method.md)   
 [Scheduler::Attach Method](../vs140/scheduler--attach-method.md)   
 [CurrentScheduler::Create Method](../vs140/currentscheduler--create-method.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)