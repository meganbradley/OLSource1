---
title: "CurrentScheduler::Create Method"
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
  - "concrt/concurrency::CurrentScheduler::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 3cce2755-d7af-4613-ba11-6783e9bf0a62
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::Create Method
Creates a new scheduler whose behavior is described by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter and attaches it to the calling context. The newly created scheduler will become the current scheduler for the calling context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The scheduler policy that describes the behavior of the newly created scheduler.  
  
## Remarks  
 The attachment of the scheduler to the calling context implicitly places a reference count on the scheduler.  
  
 After a scheduler is created with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, you must call the [CurrentScheduler::Detach](../vs140/currentscheduler--detach-method.md) method at some point in the future in order to allow the scheduler to shut down.  
  
 If this method is called from a context that is already attached to a different scheduler, the existing scheduler is remembered as the previous scheduler, and the newly created scheduler becomes the current scheduler. When you call the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method at a later point, the previous scheduler is restored as the current scheduler.  
  
 This method can throw a variety of exceptions, including [scheduler_resource_allocation_error](../vs140/scheduler_resource_allocation_error-class.md) and [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md).  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [CurrentScheduler::Detach Method](../vs140/currentscheduler--detach-method.md)   
 [Scheduler::Reference Method](../vs140/scheduler--reference-method.md)   
 [Scheduler::Release Method](../vs140/scheduler--release-method.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)