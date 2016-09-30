---
title: "Scheduler::Attach Method"
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
  - "concrt/concurrency::Scheduler::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
ms.assetid: 6a341a45-016a-4dc6-b615-0ac7a67a8b2d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::Attach Method
Attaches the scheduler to the calling context. After this method returns, the calling context is managed by the scheduler and the scheduler becomes the current scheduler.  
  
## Syntax  
  
```  
virtual void Attach() =0;  
```  
  
## Remarks  
 Attaching a scheduler implicitly places a reference on the scheduler.  
  
 At some point in the future, you must call the [CurrentScheduler::Detach](../vs140/currentscheduler--detach-method.md) method in order to allow the scheduler to shut down.  
  
 If this method is called from a context that is already attached to a different scheduler, the existing scheduler is remembered as the previous scheduler, and the newly created scheduler becomes the current scheduler. When you call the `CurrentScheduler::Detach` method at a later point, the previous scheduler is restored as the current scheduler.  
  
 This method will throw an [improper_scheduler_attach](../vs140/improper_scheduler_attach-class.md) exception if this scheduler is the current scheduler of the calling context.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)   
 [CurrentScheduler::Detach Method](../vs140/currentscheduler--detach-method.md)