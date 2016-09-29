---
title: "structured_task_group::wait Method"
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
  - "ppl/concurrency::structured_task_group::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: 91da1999-6ba4-4ebd-9811-6e1ecf5cf29b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# structured_task_group::wait Method
Waits until all work on the `structured_task_group` has completed or is canceled.  
  
## Syntax  
  
```  
task_group_status wait();  
```  
  
## Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see [task_group_status](../vs140/task_group_status-enumeration.md)  
  
## Remarks  
 Note that one or more of the tasks scheduled to this `structured_task_group` object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this `structured_task_group` object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the `wait` method.  
  
 After this function returns, the `structured_task_group` object is considered in a final state and should not be used. Note that utilization after the `wait` method returns will result in undefined behavior.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the `run_and_wait` method before the destructor of the `structured_task_group` executes.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [structured_task_group::wait Method](../vs140/structured_task_group--wait-method.md)   
 [structured_task_group::run_and_wait Method](../vs140/structured_task_group--run_and_wait-method.md)   
 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md)