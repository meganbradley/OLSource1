---
title: "structured_task_group::run Method"
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
  - "ppl/concurrency::structured_task_group::run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run method"
ms.assetid: c818124d-0316-48ff-98dd-7aa854f99f94
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# structured_task_group::run Method
Schedules a task on the `structured_task_group` object. The caller manages the lifetime of the `task_handle` object passed in the `_Task_handle` parameter. The version that takes the parameter `_Placement` causes the task to be biased towards executing at the location specified by that parameter.  
  
## Syntax  
  
```  
template<  
   class _Function  
>  
void run(  
   task_handle<_Function>& _Task_handle  
);  
  
template<  
   class _Function  
>  
void run(  
   task_handle<_Function>& _Task_handle,  
   location& _Placement  
);  
```  
  
#### Parameters  
 `_Function`  
 The type of the function object that will be invoked to execute the body of the task handle.  
  
 `_Task_handle`  
 A handle to the work being scheduled. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until either the `wait` or `run_and_wait` method has been called on this `structured_task_group` object.  
  
 `_Placement`  
 A reference to the location where the task represented by the `_Task_handle` parameter should execute.  
  
## Remarks  
 The runtime creates a copy of the work function that you pass to this method. Any state changes that occur in a function object that you pass to this method will not appear in your copy of that function object.  
  
 If the `structured_task_group` destructs as the result of stack unwinding from an exception, you do not need to guarantee that a call has been made to either the `wait` or `run_and_wait` method. In this case, the destructor will appropriately cancel and wait for the task represented by the `_Task_handle` parameter to complete.  
  
 Throws an [invalid_multiple_scheduling](../VS_csharp/invalid_multiple_scheduling-class.md) exception if the task handle given by the `_Task_handle` parameter has already been scheduled onto a task group object via the `run` method and there has been no intervening call to either the `wait` or `run_and_wait` method on that task group.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [structured_task_group Class](../VS_csharp/structured_task_group-class.md)   
 [structured_task_group::wait Method](../VS_csharp/structured_task_group--wait-method.md)   
 [structured_task_group::run_and_wait Method](../VS_csharp/structured_task_group--run_and_wait-method.md)   
 [Task Parallelism](../VS_csharp/task-parallelism--concurrency-runtime-.md)   
 [location class](../VS_csharp/location-class.md)